using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rh_Web_app.Models
{
    public class Vagas
    {
        public int id_vaga { get; set; }
        public string NmVaga { get; set; }
        public string Descricao { get; set; }
        public int id_Conhecimentos { get; set; }
        public int id_curriculo { get; set; }
    }
}
