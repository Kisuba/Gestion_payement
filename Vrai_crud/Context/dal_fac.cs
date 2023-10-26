using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Vrai_crud.Models;

namespace Vrai_crud.Context
{
    public class dal_fac
    {
        readonly string connetionString = "Data Source = DESKTOP-5A1D6KD; Initial Catalog = Payement_des_etudiants; Integrated Security = SSPI; User ID = sa; Password = aurelkisuba@123;";
        public IEnumerable<Faclute> Aff_fac()
        {
            var FactList = new List<Faclute>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("aff_faculte", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var faculte = new Faclute();
                    faculte.id = Convert.ToInt32(dr["Id"].ToString());
                    faculte.nom_faculte = dr["Nom_facultes"].ToString();
                    faculte.sigle = dr["Sigle"].ToString();


                    FactList.Add(faculte);

                }

                con.Close();
            }
            return FactList;
        }
    }
}
