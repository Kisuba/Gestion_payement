using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Vrai_crud.Models;

namespace Vrai_crud.Context
{

    public class dal_utilisateur
    {
        readonly string connetionString = "Data Source = DESKTOP-5A1D6KD; Initial Catalog = Payement_des_etudiants; Integrated Security = SSPI; User ID = sa; Password = aurelkisuba@123;";
        public List<Utilisateur> GetUtilisateurs()
        {
            List<Utilisateur> userList = new List<Utilisateur>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select_typeutilisateur", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            userList.Add(new Utilisateur
                            {
                                id = Convert.ToInt32(dr["Typeutilisateurid"].ToString()),
                                noms = dr["Nomtype"].ToString()
                            });

                        }
                    }
                    con.Close();
                }
                
            }
            return userList;
        }
        public IEnumerable<Utilisateur> Affutilisateur()
        {
            var utilisateurtList = new List<Utilisateur>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Select_utilisateur", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var utilisateur= new Utilisateur();
                    
                    utilisateur.typeuser = dr["Nomtype"].ToString();
                    utilisateur.noms = dr["Noms"].ToString();
                    utilisateur.Nom_utilisateur = dr["Nom_utilisateur"].ToString();
                    utilisateur.contact = dr["Numero_tel"].ToString();
                    utilisateur.adressemail = dr["Adresse_mail"].ToString();
                    utilisateur.adresse = dr["Adresse"].ToString();
                   
                    utilisateurtList.Add(utilisateur); 

                }
               
                con.Close();
            }
            return utilisateurtList;
        }
        /// <summary>
        /// insertion d'un utilisateur
        /// </summary>
        /// <param name="utilisateur"></param>

        public void Create_utilisateur(Utilisateur utilisateur)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Create_utilisateur", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@typeutilisateurid", utilisateur.typeutilisateur_id);
                cmd.Parameters.AddWithValue("@noms", utilisateur.noms);
                cmd.Parameters.AddWithValue("@nom_utilisateur", utilisateur.Nom_utilisateur);
                cmd.Parameters.AddWithValue("@motedepasse", utilisateur.motdepasse);
                cmd.Parameters.AddWithValue("@numerotel", utilisateur.contact);
                cmd.Parameters.AddWithValue("@mail", utilisateur.adressemail);
                cmd.Parameters.AddWithValue("@adresse", utilisateur.adresse);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        /// <summary>
        /// modification d'un user
        /// </summary>
        /// <param name="utilisateur"></param>

        public void Update_utilisateur(Utilisateur utilisateur)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Upadate_utilisateur", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", utilisateur.id);
                cmd.Parameters.AddWithValue("@typeutilisateurid", utilisateur.typeutilisateur_id);
                cmd.Parameters.AddWithValue("@noms", utilisateur.noms);
                cmd.Parameters.AddWithValue("@nom_utilisateur", utilisateur.Nom_utilisateur);
                cmd.Parameters.AddWithValue("@motedepasse", utilisateur.motdepasse);
                cmd.Parameters.AddWithValue("@numerotel", utilisateur.contact);
                cmd.Parameters.AddWithValue("@mail", utilisateur.adressemail);
                cmd.Parameters.AddWithValue("@adresse", utilisateur.adresse);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        /// <summary>
        /// effacer un user
        /// </summary>
        /// <param name="Id"></param>

        public void Delete_utilisateur(int? Id)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Delete_utilisateur", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@utilisateurid", Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Utilisateur GetUserById(int? Id)
        {
            var utilisateur = new Utilisateur();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Select_utilisateurbyid", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@utilisateurid", Id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    utilisateur.id = Convert.ToInt32(dr["u.id"].ToString());
                    utilisateur.typeuser = dr["t.Nomtype"].ToString();
                    utilisateur.noms = dr["u.Noms"].ToString();
                    utilisateur.Nom_utilisateur = dr["u.Nom_utilisateur"].ToString();
                    utilisateur.contact = dr["u.Numero_tel"].ToString();
                    utilisateur.adressemail = dr["u.Adresse_mail"].ToString();
                    utilisateur.adresse = dr["u.Adresse"].ToString();

                }
                con.Close();
            }
            return utilisateur;
        }

    }
}
