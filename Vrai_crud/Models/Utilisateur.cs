using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vrai_crud.Models
{
    public class Utilisateur
    {
        public int id { get; set; }
        public int typeutilisateur_id { get; set; }
        public string typeuser { get; set; }
        public string noms { get; set; }
        public string Nom_utilisateur { get; set; }
        public string motdepasse { get; set; }
        public string adressemail { get; set; }
        public string contact { get; set; }
        public string adresse { get; set; }


    }
}
