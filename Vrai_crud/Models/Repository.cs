using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vrai_crud.Models
{
    public interface Repository
    {
        List<Utilisateur> GetUtilisateurs();

    }
}
