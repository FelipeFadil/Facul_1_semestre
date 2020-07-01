using Db4objects.Db4o;
using MedCore.Model;
using MedCore.Repositorio;
using System;
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
    public partial class TelaInicialMedico : Form
    {
        Medico medResposavel;
        public TelaInicialMedico(string usuario, string senha)
        {
            InitializeComponent();
            medResposavel = new Medico();
            medResposavel = this.BuscarMedico(usuario, senha);
            lblNomeMedico.Text = medResposavel.nome.ToString();
        }

        private void TelaInicialMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void txtInicialMedPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtInicialMedPesquisa.Text))
                {
                    MessageBox.Show("O CPF do Paciente deve ser informados!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                try
                {
                    if (this.ValidaPaciente(txtInicialMedPesquisa.Text) == true)
                    {
                        TelaRegistro telaRegistro = new TelaRegistro(txtInicialMedPesquisa.Text, medResposavel.crm);
                        txtInicialMedPesquisa.Text = "";
                        this.Hide();
                        telaRegistro.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Paciente Não Cadastrado!", "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
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

        public Medico BuscarMedico(string usuario, string senha)
        {
            try
            {
                Medico medResposavel = new Medico();
                medResposavel.usuario = usuario;
                medResposavel.senha = senha;
                IObjectSet result = DbConexao.getConexao().QueryByExample(medResposavel);
                if (result.HasNext())
                {
                    medResposavel = (Medico)result.Next();
                    return medResposavel;
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
