using MedCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using MedCore.Repositorio;
using MedCore.Matematica;

namespace MedCore
{
    public partial class TelaCadastroPaciente : Form
    {
        public TelaCadastroPaciente()
        {
            InitializeComponent();
        }

        //Método construtor com uma sobrecarga, responsável por chamar o metodo que carrega os dados do paciente na tela de cadastro
        public TelaCadastroPaciente(string codigo)
        {
            InitializeComponent();
            btnCadPacienteCad.Text = "Alterar";

            this.carregaDados(codigo);
        }

        private void btnCadPacienteCanc_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCadPacienteCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacaoDosCampos() == false)
                {
                    MessageBox.Show("Todos os campos devem ser informados!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Validacaocpf.validacaoCPF(txtCadPacienteCPF.Text) == true)
                    {
                        this.IncluirPaciente();
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCadPacienteExc_Click(object sender, EventArgs e)
        {
            try
            {
                this.excluirPaciente();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //******************** SEÇÃO DE MÉTODOS ********************


        //Metodo de validação dos campos da tela 
        public bool validacaoDosCampos()
        {
            try
            {

                if (String.IsNullOrEmpty(txtCadPacienteNome.Text) | comboBoxCadPacienteSexo.SelectedIndex == -1 |
                String.IsNullOrEmpty(txtCadPacienteNasc.Text) | String.IsNullOrEmpty(txtCadPacienteEnd.Text) |
                String.IsNullOrEmpty(txtCadPacienteNumero.Text) | String.IsNullOrEmpty(txtCadPacienteBairro.Text) |
                comboBoxCadPacienteCidade.SelectedIndex == -1 | comboBoxCadPacienteEstado.SelectedIndex == -1 |
                String.IsNullOrEmpty(txtCadPacienteCPF.Text) | String.IsNullOrEmpty(txtCadPacienteTel.Text) |
                comboBoxCadPacienteEstadoCivil.SelectedIndex == -1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        //metodo incluir paciente 
        private void IncluirPaciente()
        {
            if (MessageBox.Show("Confirma gravação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Paciente paciente = new Paciente();
            paciente.nome = this.txtCadPacienteNome.Text;
            paciente.sexo = this.comboBoxCadPacienteSexo.SelectedItem.ToString();
            paciente.dataNasc = this.txtCadPacienteNasc.Text;
            paciente.endereco = this.txtCadPacienteEnd.Text;
            paciente.numero = this.txtCadPacienteNumero.Text;
            paciente.bairro = this.txtCadPacienteBairro.Text;
            paciente.cidade = comboBoxCadPacienteCidade.SelectedItem.ToString();
            paciente.estado = comboBoxCadPacienteEstado.SelectedItem.ToString();
            paciente.cpf = txtCadPacienteCPF.Text;
            paciente.tipoSang = comboBoxCadPacienteTipoSang.SelectedItem.ToString();
            paciente.estadoCivil = comboBoxCadPacienteEstadoCivil.SelectedItem.ToString();
            paciente.telefone = txtCadPacienteTel.Text;

            try
            {
                if (this.IncluirPaciente(paciente))
                {
                    MessageBox.Show("Paciente salvo com sucesso!", "Cadastro paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Paciente não foi atualizado!", "Cadastro paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        //Metodo incluir paciente com sobrecarga 
        public bool IncluirPaciente(Paciente paciente)
        {
            Paciente p = this.BuscarPaciente(paciente.cpf);

            try
            {
                if (p != null)
                {
                    if (MessageBox.Show("Paciente já cadastrado! Deseja atualizar o cadastro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return false;
                    }

                    p.nome = paciente.nome;
                    p.sexo = paciente.sexo;
                    p.dataNasc = paciente.dataNasc;
                    p.endereco = paciente.endereco;
                    p.numero = paciente.numero;
                    p.bairro = paciente.bairro;
                    p.cidade = paciente.cidade;
                    p.estado = paciente.estado;
                    p.cpf = paciente.cpf;
                    p.estadoCivil = paciente.estadoCivil;
                    p.telefone = paciente.telefone;
                    return this.Alterar(p);
                }
                else
                {
                    return Incluir(paciente);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo que verifica se paciente existe no banco de dados
        public Paciente BuscarPaciente(string cpf)
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
                }
                else
                {
                    paciente = null;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return paciente;
        }

        //Metodo para armazenar os dados do paciente no banco
        public bool Incluir(Paciente paciente)
        {
            try
            {
                DbConexao.getConexao().Store(paciente);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo que altera os dados do paciente armazenados no banco
        public bool Alterar(Paciente paciente)
        {
            try
            {
                DbConexao.getConexao().Store(paciente);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo que exclui cadastro do paciente
        private void excluirPaciente()
        {
            if (MessageBox.Show("Deseja realmente excluir o cadastro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string cpf = txtCadPacienteCPF.Text;
            try
            {
                if (this.excluirPaciente(cpf))
                {
                    MessageBox.Show("Paciente excluído com sucesso!", "Cadastro paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não existe cadastro com o CPF informado!", "Cadastro paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo excluir paciente com sobrecarga
        public bool excluirPaciente(string cpf)
        {
            Paciente paciente = this.BuscarPaciente(cpf);
            try
            {
                if (paciente != null)
                {
                    return this.Excluir(paciente);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return false;
        }

        //Metodo que exclui o cadastro do paciente do banco de dados
        public bool Excluir(Paciente paciente)
        {
            try
            {
                DbConexao.getConexao().Delete(paciente);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Metodo responsável por carregar os dados na tela de cadastro
        public void carregaDados(string codigo)
        {
            Paciente paciente = this.BuscarPaciente(codigo);

            this.txtCadPacienteNome.Text = paciente.nome.ToString();
            this.comboBoxCadPacienteSexo.Text = paciente.sexo.ToString();
            this.txtCadPacienteNasc.Text = paciente.dataNasc.ToString();
            this.txtCadPacienteEnd.Text = paciente.endereco.ToString();
            this.txtCadPacienteNumero.Text = paciente.numero.ToString();
            this.txtCadPacienteBairro.Text = paciente.bairro.ToString();
            this.comboBoxCadPacienteCidade.Text = paciente.cidade.ToString();
            this.comboBoxCadPacienteEstado.Text = paciente.estado.ToString();
            this.txtCadPacienteCPF.Text = paciente.cpf.ToString();
            this.txtCadPacienteTel.Text = paciente.telefone.ToString();
            this.comboBoxCadPacienteEstadoCivil.Text = paciente.estadoCivil.ToString();
            this.comboBoxCadPacienteTipoSang.Text = paciente.tipoSang.ToString();
        }

        private void TelaCadastroPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
