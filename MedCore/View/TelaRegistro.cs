using Db4objects.Db4o;
using MedCore.Model;
using MedCore.Repositorio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCore.View
{
    public partial class TelaRegistro : Form
    {
        string medResponsavel;
        string cpfPaciente;

        public TelaRegistro()
        {
            InitializeComponent();
        }

        public TelaRegistro(string cpf, string crm)
        {
            InitializeComponent();
            medResponsavel = crm;
            cpfPaciente = cpf;
            this.CarregaRegistro(cpf, crm);
        }

        private void btnRegistroAlterar_Click(object sender, EventArgs e)
        {
            this.AlterarRegistro();
        }

        private void btnRegistroExcluir_Click(object sender, EventArgs e)
        {
            this.ExcluirRegistro();
        }

        private void TelaRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        //******************** SEÇÃO DE MÉTODOS ********************


        //Metodo que carrega os dados do registro na tela
        public void CarregaRegistro(string cpf, string crm)
        {
            Registro registro = this.BuscarRegistro(cpf, crm);
            try
            {
                if (registro == null)
                {
                    MessageBox.Show("Primeiro registro do Paciente", "Registro paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtRegistroNomePaciente.Text = this.BuscarPaciente(cpf);


                }
                else
                {
                    this.txtRegistroTratamento.Text = registro.tratamento.ToString();
                    this.txtRegistroAlergias.Text = registro.alergia.ToString();
                    this.txtRegistroCronicas.Text = registro.doenca.ToString();
                    this.txtRegistroMedicamentos.Text = registro.medicamento.ToString();
                    this.txtRegistroCirurgias.Text = registro.cirurgia.ToString();
                    this.txtRegistroNomePaciente.Text = this.BuscarPaciente(cpf);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        //Metodo que busca dados de registro vinculados com o paciente
        public Registro BuscarRegistro(string cpf, string crm)
        {
            Registro registro;
            try
            {
                registro = new Registro();
                registro.cpfPaciente = cpf;
                registro.medicoResponsavel = crm;
                IObjectSet result = DbConexao.getConexao().QueryByExample(registro);
                if (result.HasNext())
                {
                    registro = (Registro)result.Next();
                }
                else
                {
                    registro = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return registro;
        }

        //Metodo para alterar registros
        private void AlterarRegistro()
        {
            if (MessageBox.Show("Confirma gravação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Registro registro = new Registro();
            registro.tratamento = this.txtRegistroTratamento.Text;
            registro.alergia = this.txtRegistroAlergias.Text;
            registro.doenca = this.txtRegistroCronicas.Text;
            registro.medicamento = this.txtRegistroMedicamentos.Text;
            registro.cirurgia = this.txtRegistroCirurgias.Text;
            registro.cpfPaciente = cpfPaciente;
            registro.medicoResponsavel = medResponsavel;

            try
            {
                if (this.AlterarRegistro(registro))
                {
                    MessageBox.Show("Registro salvo com sucesso!", "Cadastro registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Registro não foi atualizado!", "Cadastro registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo para alterar registro com sobrecarga
        public bool AlterarRegistro (Registro registro)
        {
            Registro reg = this.BuscarRegistro(registro.cpfPaciente, registro.medicoResponsavel);

            try
            {
                if (reg != null)
                {
                    reg.cpfPaciente = registro.cpfPaciente;
                    reg.tratamento = registro.tratamento;
                    reg.alergia = registro.alergia;
                    reg.doenca = registro.doenca;
                    reg.medicamento = registro.medicamento;
                    reg.cirurgia = registro.cirurgia;
                    reg.medicoResponsavel = registro.medicoResponsavel;
                    return this.Alterar(reg);
                }
                else
                {
                    return this.Incluir(registro);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo que inclui registro no banco de dados
        public bool Incluir(Registro registro)
        {
            try
            {
                DbConexao.getConexao().Store(registro);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo alterar registro no banco de dados
        public bool Alterar(Registro registro)
        {
            try
            {
                DbConexao.getConexao().Store(registro);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo para excluir registros
        public void ExcluirRegistro()
        {
            if (MessageBox.Show("Deseja realmente excluir o registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string cpf = cpfPaciente;
            string crm = medResponsavel;

            try
            {
                if (this.ExcluirRegistro(cpf, crm))
                {
                    MessageBox.Show("Registro excluído com sucesso!", "Cadastro registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Registro não foi excluído!", "Cadastro registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo que exclui o registro com sobrecarga
        public bool ExcluirRegistro(string cpf, string crm)
        {
            Registro registro = this.BuscarRegistro(cpf, crm);

            try
            {
                if (registro != null)
                {
                    return this.Excluir(registro);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return false;
        }

        //Metodo que exclui o registro do paciente do banco de dados
        public bool Excluir(Registro registro)
        {
            try
            {
                DbConexao.getConexao().Delete(registro);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string BuscarPaciente(string cpf)
        {
            Paciente paciente;
            try
            {
                paciente = new Paciente();
                paciente.cpf = cpf;
                IObjectSet result = DbConexao.getConexao().QueryByExample(paciente);
                if (result.HasNext())
                {
                    paciente = (Paciente)result.Next();
                    return paciente.nome;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
