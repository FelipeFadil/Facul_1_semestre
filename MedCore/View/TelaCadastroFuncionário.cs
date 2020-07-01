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
    public partial class TelaCadastroFuncionario : Form
    {
        private Funcionario funcionario;
        public TelaCadastroFuncionario()
        {
            InitializeComponent();
        }

        public TelaCadastroFuncionario(string codigo)
        {
            InitializeComponent();
            btnCadFuncionarioCad.Text = "Alterar";
            this.carregaDados(codigo);
        }

        private void btnCadFuncionarioCanc_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCadFuncionarioCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacaoDosCampos() == false)
                {
                    MessageBox.Show("Todos os campos devem ser informados!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.IncluirFuncionario();                                       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IncluirFuncionario()
        {
            if (MessageBox.Show("Confirma gravação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            funcionario = new Funcionario();
            funcionario.nome = this.txtCadFuncionarioNome.Text;
            funcionario.sexo = this.comboBoxCadFuncionarioSexo.SelectedItem.ToString();
            funcionario.dataNasc = this.txtCadFuncionarioNasc.Text;
            funcionario.endereco = this.txtCadFuncionarioEnd.Text;
            funcionario.numero = this.txtCadFuncionarioNum.Text;
            funcionario.bairro = this.txtCadFuncionarioBairro.Text;
            funcionario.cidade = this.comboBoxCadFuncionarioCidade.SelectedItem.ToString();
            funcionario.estado = this.comboBoxCadFuncionarioEstado.SelectedItem.ToString();
            funcionario.codigo = this.txtCadFuncionarioCPF.Text;
            funcionario.estadoCivil = this.comboBoxCadFuncionarioEstadoCivil.SelectedItem.ToString();
            funcionario.telefone = this.txtCadFuncionarioTel.Text;
            funcionario.usuario = this.txtCadFuncionarioUsuario.Text;
            funcionario.senha = this.txtCadFuncionarioSenha.Text;

            try
            {
                if (this.IncluirFuncionario(funcionario))
                {
                    MessageBox.Show("Funcionário salvo com sucesso!", "Cadastro funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Funcionário não foi atualizado!", "Cadastro funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool IncluirFuncionario(Funcionario funcionario)
        {
            Funcionario f = this.BuscarCadastro(funcionario.codigo);

            try
            {
                if (f != null)
                {
                    if (MessageBox.Show("Funcionário já cadastrado! Deseja atualizar o cadastro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return false;
                    }

                    f.nome = funcionario.nome;
                    f.sexo = funcionario.sexo;
                    f.dataNasc = funcionario.dataNasc;
                    f.endereco = funcionario.endereco;
                    f.numero = funcionario.numero;
                    f.bairro = funcionario.bairro;
                    f.cidade = funcionario.cidade;
                    f.estado = funcionario.estado;
                    f.codigo = funcionario.codigo;
                    f.estadoCivil = funcionario.estadoCivil;
                    f.telefone = funcionario.telefone;
                    f.usuario = funcionario.usuario;
                    f.senha = funcionario.senha;
                    return this.Alterar(f);
                }
                else
                {
                    return Incluir(funcionario);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Funcionario BuscarCadastro(string codigo)
        {
            Funcionario funcionario;
            try
            {
                funcionario = new Funcionario();
                funcionario.codigo = codigo;
                IObjectSet result = DbConexao.getConexao().QueryByExample(funcionario);
                if (result.HasNext())
                {
                    funcionario = (Funcionario)result.Next();
                }
                else
                {
                    funcionario = null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return funcionario;
        }

        public Boolean Incluir(Funcionario funcionario)
        {
            try
            {
                DbConexao.getConexao().Store(funcionario);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Boolean Alterar(Funcionario funcionario)
        {
            try
            {
                DbConexao.getConexao().Store(funcionario);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool validacaoDosCampos()
        {
            try
            {

                if (String.IsNullOrEmpty(txtCadFuncionarioNome.Text) | comboBoxCadFuncionarioSexo.SelectedIndex == -1 |
                String.IsNullOrEmpty(txtCadFuncionarioNasc.Text) | String.IsNullOrEmpty(txtCadFuncionarioEnd.Text) |
                String.IsNullOrEmpty(txtCadFuncionarioNum.Text) | String.IsNullOrEmpty(txtCadFuncionarioBairro.Text) |
                comboBoxCadFuncionarioCidade.SelectedIndex == -1 | comboBoxCadFuncionarioEstado.SelectedIndex == -1 |
                String.IsNullOrEmpty(txtCadFuncionarioCPF.Text) | String.IsNullOrEmpty(txtCadFuncionarioTel.Text) |
                comboBoxCadFuncionarioEstadoCivil.SelectedIndex == -1 | String.IsNullOrEmpty(txtCadFuncionarioUsuario.Text) |
                String.IsNullOrEmpty(txtCadFuncionarioSenha.Text))
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

        private void TelaCadastroFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnCadFuncionarioExc_Click(object sender, EventArgs e)
        {
            try
            {
                this.excluiCadastro();
                this.Dispose();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void excluiCadastro()
        {
            if (MessageBox.Show("Deseja realmente excluir o cadastro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string codigo = txtCadFuncionarioCPF.Text;
            try
            {
                if (this.excluirCadastro(codigo))
                {
                    MessageBox.Show("Funcionário excluído com sucesso!", "Cadastro funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não existe cadastro com o Código informado!", "Cadastro funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool excluirCadastro(string codigo)
        {
            Funcionario funcionario;
            try
            {
                funcionario = this.BuscarCadastro(codigo);
                if (funcionario != null)
                {
                    return this.Excluir(funcionario);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return false;
        }

        public bool Excluir(Funcionario funcionario)
        {
            try
            {
                DbConexao.getConexao().Delete(funcionario);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void carregaDados(string codigo)
        {
            Funcionario funcionario = this.BuscarCadastro(codigo);

            this.txtCadFuncionarioNome.Text = funcionario.nome.ToString();
            this.comboBoxCadFuncionarioSexo.Text = funcionario.sexo.ToString();
            this.txtCadFuncionarioNasc.Text = funcionario.dataNasc.ToString();
            this.txtCadFuncionarioEnd.Text = funcionario.endereco.ToString();
            this.txtCadFuncionarioNum.Text = funcionario.numero.ToString();
            this.txtCadFuncionarioBairro.Text = funcionario.bairro.ToString();
            this.comboBoxCadFuncionarioCidade.Text = funcionario.cidade.ToString();
            this.comboBoxCadFuncionarioEstado.Text = funcionario.estado.ToString();
            this.txtCadFuncionarioCPF.Text = funcionario.codigo.ToString();
            this.txtCadFuncionarioTel.Text = funcionario.telefone.ToString();
            this.comboBoxCadFuncionarioEstadoCivil.Text = funcionario.estadoCivil.ToString();
            this.txtCadFuncionarioUsuario.Text = funcionario.usuario.ToString();
            this.txtCadFuncionarioSenha.Text = funcionario.senha.ToString();
        }

    }
}
