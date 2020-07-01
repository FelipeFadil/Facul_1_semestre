using Db4objects.Db4o;
using MedCore.Repositorio;
using MedCore.Model;
using MedCore.View;
using MedCore.Matematica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCore
{
    public partial class TelaCadastroMedico : Form
    {
        private Medico medico;
        public TelaCadastroMedico()
        {
            InitializeComponent();
        }

        public TelaCadastroMedico(string crm)
        {
            InitializeComponent();
            btnCadMedicoCad.Text = "Alterar";

            this.MetCarregaDados(crm);
        }

        private void TelaCadastroMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        //******************** SEÇÃO DE MÉTODOS ********************

        // Método para Carregar os Dados do Médico na tela de cadastro do Médico (TelaCadastroMédico.cs)
        public void MetCarregaDados(string crm)
        {
            Medico medico = this.MetBuscarCadBanco(crm);

            this.txtCadMedicoNome.Text = medico.nome.ToString();
            this.comboBoxCadMedicoSexo.Text = medico.sexo.ToString();
            this.txtCadMedicoNasc.Text = medico.dataNasc.ToString();
            this.txtCadMedicoEnd.Text = medico.endereco.ToString();
            this.txtCadMedNum.Text = medico.numero.ToString();
            this.txtCadMedicoBairro.Text = medico.bairro.ToString();
            this.comboBoxCadMedicoCidade.Text = medico.cidade.ToString();
            this.comboBoxCadMedicoEstado.Text = medico.estado.ToString();
            this.txtCadMedicoCRM.Text = medico.crm.ToString();
            this.txtCadMedicoTel.Text = medico.telefone.ToString();
            this.comboBoxCadMedicoCivil.Text = medico.estadoCivil.ToString();
            this.txtCadMedUsuario.Text = medico.usuario.ToString();
            this.txtCadMedSenha.Text = medico.senha.ToString();
            this.comboBoxCadMedicoArea.Text = medico.area.ToString();
        }

        /* Método para Incluir um novo Médico. Se já houver cadastro do Médico,
         * Retornará uma mensagem perguntando se deseja atualizar o cadastro já
         * existente.
         */
        public Medico MetBuscarCadBanco(string crm)
        {
            Medico medico;

            try
            {
                medico = new Medico();
                medico.crm = crm;
                IObjectSet result = DbConexao.getConexao().QueryByExample(medico);
                if (result.HasNext())
                {
                    medico = (Medico)result.Next();
                }
                else
                {
                    medico = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return medico;
        }

        /* Método para Incluir um novo Médico. Se já houver cadastro do Médico,
         * Retornará uma mensagem perguntando se deseja atualizar o cadastro já
         * existente.
         */

        private void MetIncluirMedico()
        {
            if (MessageBox.Show("Confirma gravação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            medico = new Medico();
            medico.nome = this.txtCadMedicoNome.Text;
            medico.sexo = this.comboBoxCadMedicoSexo.SelectedItem.ToString();
            medico.dataNasc = this.txtCadMedicoNasc.Text;
            medico.endereco = this.txtCadMedicoEnd.Text;
            medico.numero = this.txtCadMedNum.Text;
            medico.bairro = this.txtCadMedicoBairro.Text;
            medico.cidade = this.comboBoxCadMedicoCidade.SelectedItem.ToString();
            medico.estado = this.comboBoxCadMedicoEstado.SelectedItem.ToString();
            medico.crm = this.txtCadMedicoCRM.Text;
            medico.estadoCivil = this.comboBoxCadMedicoCivil.SelectedItem.ToString();
            medico.telefone = this.txtCadMedicoTel.Text;
            medico.usuario = this.txtCadMedUsuario.Text;
            medico.senha = this.txtCadMedSenha.Text;
            medico.area = this.comboBoxCadMedicoArea.SelectedItem.ToString();

            try
            {
                if (this.MetIncluirMedico(medico))
                {
                    MessageBox.Show("Médico salvo com sucesso!", "Cadastro médico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O cadastro não foi atualizado!", "Cadastro médico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool MetIncluirMedico(Medico medico)
        {
            Medico m = this.MetBuscarCadBanco(medico.crm);

            try
            {
                if (m != null)
                {
                    if (MessageBox.Show("Médico já cadastrado! Deseja atualizar o cadastro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return false;
                    }

                    m.nome = medico.nome;
                    m.sexo = medico.sexo;
                    m.dataNasc = medico.dataNasc;
                    m.endereco = medico.endereco;
                    m.numero = medico.numero;
                    m.bairro = medico.bairro;
                    m.cidade = medico.cidade;
                    m.estado = medico.estado;
                    m.crm = medico.crm;
                    m.estadoCivil = medico.estadoCivil;
                    m.telefone = medico.telefone;
                    m.usuario = medico.usuario;
                    m.senha = medico.senha;

                    return this.MetAlterarBanco(m);
                }
                else
                {
                    return MetGravarBanco(medico);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // Método para validar se todos os campos do cadastro estão preenchidos
        public bool MetValidarCampos()
        {
            try
            {
                if (String.IsNullOrEmpty(txtCadMedicoNome.Text) | comboBoxCadMedicoSexo.SelectedIndex == -1 |
                String.IsNullOrEmpty(txtCadMedicoNasc.Text) | String.IsNullOrEmpty(txtCadMedicoEnd.Text) |
                String.IsNullOrEmpty(txtCadMedNum.Text) | String.IsNullOrEmpty(txtCadMedicoBairro.Text) |
                comboBoxCadMedicoCidade.SelectedIndex == -1 | comboBoxCadMedicoEstado.SelectedIndex == -1 |
                String.IsNullOrEmpty(txtCadMedicoCRM.Text) | String.IsNullOrEmpty(txtCadMedicoTel.Text) |
                comboBoxCadMedicoArea.SelectedIndex == -1 | comboBoxCadMedicoCivil.SelectedIndex == -1 | 
                String.IsNullOrEmpty(txtCadMedUsuario.Text) | String.IsNullOrEmpty(txtCadMedSenha.Text))
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

        // Métodos que realizam ações no banco (db4o):

        // Método para Gravar/Inserir novos dados no banco
        public bool MetGravarBanco(Medico medico)
        {
            try
            {
                DbConexao.getConexao().Store(medico);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // Método para Alterar dados no banco
        public bool MetAlterarBanco(Medico medico)
        {
            try
            {
                DbConexao.getConexao().Store(medico);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // Método para excluir dados no banco 3
        public bool Excluir(Medico medico)
        {
            try
            {
                DbConexao.getConexao().Delete(medico);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // Método para excluir dados no banco 2
        public bool MetExcluirCadBanco(string crm)
        {
            Medico medico;
            try
            {
                medico = this.MetBuscarCadBanco(crm);
                if (medico != null)
                {
                    return this.Excluir(medico);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return false;
        }

        // Método para excluir dados no banco 3
        private void MetExcluir()
        {
            if (MessageBox.Show("Deseja realmente excluir o cadastro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string crm = txtCadMedicoCRM.Text;
            try
            {
                if (this.MetExcluirCadBanco(crm))
                {
                    MessageBox.Show("Médico excluído com sucesso!", "Cadastro médico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não existe cadastro com o CRM informado!", "Cadastro médico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //******************** BOTÕES ********************

        private void btnCadMedicoCanc_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCadMedicoCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetValidarCampos() == false)
                {
                    MessageBox.Show("Todos os campos devem ser informados!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(txtCadMedicoCRM.TextLength) < 4)
                {
                    MessageBox.Show("O CRM deve ter no mínimo 4 dígitos!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    this.MetIncluirMedico();
                    this.Dispose();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btnCadMedicoExc_Click(object sender, EventArgs e)
        {
            try
            {
                this.MetExcluir();
                this.Dispose();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
