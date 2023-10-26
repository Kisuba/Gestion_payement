using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vrai_crud.Models
{
    public class Payement
    {
        public int id { get; set; }
        public string matricule { get; set; }
        public string noms { get; set; }
        public string prenom { get; set; }
        public string montant { get; set; }
        public string faculte { get; set; }
        public string promotion { get; set; }
        public string datepaye { get; set; }
        public string reste { get; set; }
        public string photo { get; set; }
        public string datetime { get; set; }
        public string total { get; set; }
        public string numrecu { get; set; }

    }
}
