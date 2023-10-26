using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vrai_crud.Models
{
    public class etudiant
    {
       
       // public int ideutilisateur { get; set; }
        public int id { get; set; }
        public string idfaculte { get; set; }
        public string idpromotion { get; set; }
        public string noms { get; set; }
        public string prenom { get; set; }
        public string nomrespo { get; set; }
        public string contactresp { get; set; }
        public string datenaiss { get; set; }
        public string sexe { get; set; }
        public string contact { get; set; }
        public string photo { get; set; }
        public string adressemail { get; set; }
        public string adresse { get; set; }
        public string matricule { get; set; }

        public string montant { get; set; }
    }
}
