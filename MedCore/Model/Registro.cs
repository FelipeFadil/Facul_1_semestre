using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCore.Model
{
    public class Registro
    {
        public string cpfPaciente { get; set; }
        public string medicamento { get; set; }
        public string alergia { get; set; }
        public string doenca { get; set; }
        public string tratamento { get; set; }
        public string cirurgia { get; set; }
        public string medicoResponsavel { get; set; }
    }
}
