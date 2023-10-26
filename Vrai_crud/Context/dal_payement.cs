using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Vrai_crud.Models;
namespace Vrai_crud.Context
{
   
    public class dal_payement
    {
        readonly string connetionString = "Data Source = DESKTOP-5A1D6KD; Initial Catalog = Payement_des_etudiants; Integrated Security = SSPI; User ID = sa; Password = aurelkisuba@123;";

        public IEnumerable<Payement> List_payement()
        {
            var payementList = new List<Payement>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("liste_payement", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var payement = new Payement();
                    payement.id = Convert.ToInt32(dr["id"].ToString());
                    payement.matricule = dr["Id_Etudiant"].ToString();
                    payement.noms = dr["Noms"].ToString();
                    payement.montant = dr["Montant"].ToString();
                    payement.promotion = dr["Nom_promotion"].ToString();
                    payement.faculte = dr["Nom_facultes"].ToString();
                    payement.datepaye = dr["Date_paye"].ToString();
                   
                    payementList.Add(payement);

                }
                con.Close();
            }
            return payementList;
        }

        public Payement GetPayementByMatricule(int? Id)
        {
            var payement = new Payement();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("get_payement_by_matricule", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", Id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    payement.matricule = dr["Id_Etudiant"].ToString();
                    payement.noms = dr["Noms"].ToString();
                    payement.faculte = dr["Nom_facultes"].ToString();
                    payement.promotion = dr["Nom_promotion"].ToString();
                    payement.montant = dr["Montant"].ToString();
                    payement.reste = dr["Reste"].ToString();
                }
                con.Close();
            }
            return payement;
        }
        public IEnumerable<Payement> lite_payement_par_etudiant(string matricule)
        {
           
            var payementList = new List<Payement>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("liste_payement_par_etudiant", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@matricules", matricule);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var payement = new Payement();
                    payement.matricule = dr["Id_Etudiant"].ToString();
                    payement.noms = dr["Noms"].ToString();
                    payement.prenom = dr["Prenom"].ToString();
                    payement.faculte = dr["Nom_facultes"].ToString();
                    payement.promotion = dr["Nom_promotion"].ToString();
                    payement.montant = dr["Montant"].ToString();
                    payement.datepaye = dr["Date_paye"].ToString();
                    payement.total = dr["Montant"].ToString();
                    

                    payementList.Add(payement);
                }
                con.Close();
            }
            return payementList;
        }
        public Payement recu_payement(int? Id)
        {
            
            var payement = new Payement();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("recu_payement", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", Id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    payement.numrecu = dr["numrecu"].ToString();
                    payement.matricule = dr["Matricule"].ToString();
                    payement.noms = dr["Noms"].ToString();
                    payement.faculte = dr["Faculte"].ToString();
                    payement.promotion = dr["Promotion"].ToString();
                    payement.montant = dr["Montantpaye"].ToString();
                    payement.reste = dr["Reste"].ToString();
                    payement.datepaye = dr["Datedepaye"].ToString();
                    payement.photo = dr["Photo"].ToString();
                    payement.datetime = dr["Date_time"].ToString();
                }
                con.Close();
            }
            return payement;
        }
        //pour afficher le nom sur le paiement deja fait
        public List<Payement> Get_student_info(string matricule)
        {
            List<Payement> studentList = new List<Payement>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("nom_liste_payement", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@matricules", matricule);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            studentList.Add(new Payement
                            {
                              
                                matricule = dr["Id_Etudiant"].ToString(),
                                noms = dr["Noms"].ToString(),
                                faculte = dr["Nom_facultes"].ToString(),
                                promotion = dr["Nom_promotion"].ToString(),
                                total = dr["Somme"].ToString(),
                                photo = dr["Photo"].ToString(),

                        });

                        }
                    }
                    con.Close();
                }

            }
            return studentList;
        }
    }
}
