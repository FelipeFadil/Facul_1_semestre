using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCore.Matematica
{
    class Validacaocpf
    {
        public static bool validacaoCPF(string cpf)
        {
            try
            {
                cpf = cpf.Trim().Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;

                string cpfSemDigito = cpf.Substring(0, 9);
                int soma = 0;
                int multiplicador = 10;

                foreach (char n in cpfSemDigito)
                {
                    soma += int.Parse(n.ToString()) * multiplicador;
                    multiplicador -= 1;
                }

                int resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                string digito = resto.ToString();
                cpfSemDigito += digito; 
                soma = 0;
                multiplicador = 11;

                foreach (char n in cpfSemDigito)
                {
                    soma += int.Parse(n.ToString()) * multiplicador;
                    multiplicador -= 1;
                }

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito += resto.ToString();

                if (digito == cpf.Substring(9, 2))
                    return true;
                    
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

                return false;
        }
    }
}
