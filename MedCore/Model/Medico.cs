using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCore.Model
{
    public class Medico
    {
        public string nome { get; set; }
        public string sexo { get; set; }
        public string dataNasc { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string crm { get; set; }
        public string area { get; set; }
        public string estadoCivil { get; set; }
        public string telefone { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }


        public Medico(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }

        public Medico()
        {
        }
    }
}
