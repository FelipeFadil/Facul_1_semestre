using Db4objects.Db4o;
using MedCore.Model;
using MedCore.Repositorio;
using MedCore.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCore
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            try
            {
                DbConexao.getConexao();
                if (!this.IncluirFuncionarioPadrao() & !this.IncluirMedicoAdmin())
                {
                    MessageBox.Show("Não foi possível verificar a existência do usuário padrão");
                    Application.Exit();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();
            }

            InitializeComponent();
            this.txtLogin001.Focus();
        }

        public Boolean IncluirFuncionarioPadrao()
        {
            Funcionario funcionario;
            try
            {
                funcionario = new Funcionario();
                funcionario.usuario = "ADMIN";
                funcionario.senha = "ADMIN";
                IObjectSet result = DbConexao.getConexao().QueryByExample(funcionario);
                if (result.HasNext())
                {
                    return true;
                }

                return this.Incluir(new Funcionario { usuario = "ADMIN", senha = "ADMIN" });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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

        public Boolean IncluirMedicoAdmin()
        {
            Medico medico;
            try
            {
                medico = new Medico();
                medico.usuario = "ADMIN";
                medico.senha = "ADMIN";
                IObjectSet result = DbConexao.getConexao().QueryByExample(medico);
                if (result.HasNext())
                {
                    return true;
                }

                return this.IncluirMedico(new Medico { usuario = "ADMIN", senha = "ADMIN" });
  
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Boolean IncluirMedico(Medico medico)
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

        private void BotãoLogin001_Click(object sender, EventArgs e)
        {
            /*
             * VALIDAÇÃO DOS CAMPOS
             */

            if (String.IsNullOrEmpty(txtLogin001.Text))
            {
                MessageBox.Show("O usuario deve ser informado!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin001.Focus();

                return;
            }
            if (String.IsNullOrEmpty(txtLogin002.Text))
            {
                MessageBox.Show("A senha deve ser informado!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin002.Focus();

                return;
            }
            if (comboBoxLogin0001.SelectedIndex == -1)
            {
                MessageBox.Show("A área deve ser informado!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxLogin0001.Focus();

                return;
            }

            try
            {
                if (comboBoxLogin0001.SelectedIndex == 1)
                {
                    if (this.Logar(new Funcionario(txtLogin001.Text, txtLogin002.Text)) != null)
                    {
                        TelaInicialFuncionário telaInicialFuncionário = new TelaInicialFuncionário();
                        this.Hide();
                        telaInicialFuncionário.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário Não Cadastrado!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxLogin0001.SelectedIndex == 0)
                {
                    if (this.Logar(new Medico(txtLogin001.Text, txtLogin002.Text)) != null)
                    {
                        TelaInicialMedico telaInicialMedico = new TelaInicialMedico(txtLogin001.Text, txtLogin002.Text);
                        this.Hide();
                        telaInicialMedico.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário Não Cadastrado!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                Application.Exit();
            }
        }

        public Funcionario Logar(Funcionario funcionario)
        {
            Funcionario funcionarioRetorno = null;

            try
            {
                IObjectSet result = DbConexao.getConexao().QueryByExample(funcionario);
                if (result.HasNext())
                {
                    funcionarioRetorno = (Funcionario)result.Next();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return funcionarioRetorno;
        }

        public Medico Logar(Medico medico)
        {
            Medico medicoRetorno = null;

            try
            {
                IObjectSet result = DbConexao.getConexao().QueryByExample(medico);
                if (result.HasNext())
                {
                    medicoRetorno = (Medico)result.Next();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return medicoRetorno;
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DbConexao.Desconectar();
            Application.Exit();
        }
    }
}
