using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vrai_crud.Models;
using System.Data.SqlClient;
using System.Data;
namespace Vrai_crud.Context
{
    public class dal_frais
    {
        readonly string connetionString = "Data Source = DESKTOP-5A1D6KD; Initial Catalog = Payement_des_etudiants; Integrated Security = SSPI; User ID = sa; Password = aurelkisuba@123;";
        public IEnumerable<Frais> Aff_frais()
        {
            var FraisList = new List<Frais>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Select_frais", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var frais = new Frais();
                   frais.id = Convert.ToInt32(dr["Id"].ToString());
                   frais.faculte = dr["Nom_facultes"].ToString();
                   frais.promotion = dr["Nom_promotion"].ToString();
                   frais.inscritpion = dr["Inscription"].ToString();
                   frais.t1 = dr["Tranche1"].ToString();
                   frais.t2 = dr["Tranche2"].ToString();
                   frais.t3 = dr["Tranche3"].ToString();
                   
                    FraisList.Add(frais);

                }

                con.Close();
            }
            return FraisList;
        }
    }
}
