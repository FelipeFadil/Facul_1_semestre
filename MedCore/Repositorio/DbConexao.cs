using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;

namespace MedCore.Repositorio
{
    class DbConexao
    {
        private static IObjectContainer conexao = null;
        private static string localizacaoBanco = Application.StartupPath + @"\banco.db";

        static public IObjectContainer getConexao()
        {
            if (conexao == null)
            {
                try
                {
                    conexao = Db4oFactory.OpenFile(localizacaoBanco);
                }
                catch (Exception e)
                {
                    conexao = null;
                    throw new Exception("Não foi possível abrir conexão com o banco de dados: " + e.Message);
                }
            }

            return conexao;
        }

        static public void Desconectar()
        {
            if (conexao != null)
            {
                try
                {
                    conexao.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Não foi possível desconectar com banco de dados: " + e.Message);
                }
            }
        }
    }
}
