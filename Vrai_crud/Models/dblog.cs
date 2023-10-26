using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 
using System.Configuration;
using Vrai_crud.Models;
namespace Vrai_crud.Models
{
        public class dblog
    {
        readonly string connetionString = "Data Source = DESKTOP-5A1D6KD; Initial Catalog = Payement_des_etudiants; Integrated Security = SSPI; User ID = sa; Password = aurelkisuba@123;";
        public int LoginCheck(login ad)
        {
            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand com = new SqlCommand("login_user", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nomuser", ad.nom);
            com.Parameters.AddWithValue("@mtdpasse", ad.mot_de_passe);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@isvalid";
            oblogin.SqlDbType = SqlDbType.Bit;
            oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;

        }
    }
}
