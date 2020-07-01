using Db4objects.Db4o;
using MedCore.Repositorio;
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
using System.Runtime.Remoting;

namespace MedCore
{
    public partial class TelaInicialFuncionário : Form
    {
        
        public TelaInicialFuncionário()
        {
            InitializeComponent();
        }

        private void btTelaCadastroPaciente_Click(object sender, EventArgs e)
        {
            TelaCadastroPaciente telaCadastroPaciente = new TelaCadastroPaciente();
            this.Hide();
            telaCadastroPaciente.ShowDialog();
            this.Show();
        }

        private void btTelaCadastroMedico_Click(object sender, EventArgs e)
        {
            TelaCadastroMedico telaCadastroMedico = new TelaCadastroMedico();
            this.Hide();
            telaCadastroMedico.ShowDialog();
            this.Show();
        }

        private void btTelaCadastroFuncionario_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncionario telaCadastroFuncionario = new TelaCadastroFuncionario();
            this.Hide();
            telaCadastroFuncionario.ShowDialog();
            this.Show();
        }

        private void TelaInicialFuncionário_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void txtInicialFuncPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtInicialFuncPesquisa.Text))
                {
                    MessageBox.Show("Os dados para pesquisa devem ser informados!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                
                try
                {
                    this.CarregaTela(txtInicialFuncPesquisa.Text);

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }

            }
        }

        public void CarregaTela(string codigo)
        {
            try
            {
                if (codigo.Length == 11)
                {
                    if (this.ValidaPaciente(codigo) == true)
                    {
                        TelaCadastroPaciente telaCadastroPaciente = new TelaCadastroPaciente(codigo);
                        txtInicialFuncPesquisa.Text = "";
                        this.Hide();
                        telaCadastroPaciente.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Paciente não Cadastrado!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (codigo.Length >= 4 && codigo.Length <= 10)
                {
                    if (this.ValidaMedico(codigo) == true)
                    {
                        TelaCadastroMedico telaCadastroMedico = new TelaCadastroMedico(codigo);
                        txtInicialFuncPesquisa.Text = "";
                        this.Hide();
                        telaCadastroMedico.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Médico não Cadastrado!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (codigo.Length >= 1 && codigo.Length <= 3)
                {
                    if (this.ValidaFuncionario(codigo) == true)
                    {
                        TelaCadastroFuncionario telaCadastroFuncionario = new TelaCadastroFuncionario(codigo);
                        txtInicialFuncPesquisa.Text = "";
                        this.Hide();
                        telaCadastroFuncionario.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não Cadastrado!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ValidaPaciente(string cpf)
        {
            Paciente paciente;
            try
            {
                paciente = new Paciente();
                paciente.cpf = cpf;
                IObjectSet result = DbConexao.getConexao().QueryByExample(paciente);
                if (result.HasNext())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ValidaMedico(string crm)
        {
            Medico medico;
            try
            {
                medico = new Medico();
                medico.crm = crm;
                IObjectSet result = DbConexao.getConexao().QueryByExample(medico);
                if (result.HasNext())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ValidaFuncionario(string codigo)
        {
            Funcionario funcionario;
            try
            {
                funcionario = new Funcionario();
                funcionario.codigo = codigo;
                IObjectSet result = DbConexao.getConexao().QueryByExample(funcionario);
                if (result.HasNext())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
