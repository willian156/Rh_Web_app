using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rh_Web_app.Models
{
    public class Curriculos
    {
        public int id_curriculo { get; set; }
        public string nmPessoa { get; set; }
        public string PessDescricao { get; set; }
        public int id_Conhecimentos { get; set; }
    }
}
