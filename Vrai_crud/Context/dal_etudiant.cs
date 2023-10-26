using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QRCoder;
using Vrai_crud.Models;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Vrai_crud.Context
{
    public class dal_etudiant
    {
        readonly string connetionString = "Data Source = DESKTOP-5A1D6KD; Initial Catalog = Payement_des_etudiants; Integrated Security = SSPI; User ID = sa; Password = aurelkisuba@123;";
        public List<Faclute> GetFac()
        {
            List<Faclute> userList = new List<Faclute>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("select_fac", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            userList.Add(new Faclute
                            {
                                id = Convert.ToInt32(dr["Id"].ToString()),
                                nom_faculte = dr["Nom_facultes"].ToString(),
                                //sigle = dr["Sigle"].ToString(),
                            });

                        }
                    }
                    con.Close();
                }

            }
            return userList;
        }
        public List<Promotion> Promotion()
        {
            List<Promotion> userList = new List<Promotion>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("select_prom", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            userList.Add(new Promotion
                            {
                                id = Convert.ToInt32(dr["Id"].ToString()),
                                promotion = dr["Nom_promotion"].ToString(),
                                //sigle = dr["Sigle"].ToString(),
                            });

                        }
                    }
                    con.Close();
                }

            }
            return userList;
        }
        public IEnumerable<etudiant> List_etudiants()
        {
            var studentList = new List<etudiant>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("select_etudiant", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var student = new etudiant();
                   student.id= Convert.ToInt32(dr["id"].ToString());
                    student.idfaculte = dr["Nom_facultes"].ToString();
                    student.idpromotion = dr["Nom_promotion"].ToString();
                    student.noms =dr["Noms"].ToString();
                    student.prenom = dr["Prenom"].ToString();
                    student.nomrespo = dr["Nomsresponsable"].ToString();
                    student.contactresp = dr["Contactrsp"].ToString();
                    student.sexe = dr["Sexe"].ToString();
                    student. contact = dr["Contact"].ToString();
                    student.photo = dr["Photo"].ToString();
                    student.adressemail = dr["Adressemail"].ToString();
                    student.datenaiss = dr["Datenaissance"].ToString();
                    student.adresse = dr["Adresse"].ToString();
                    student.matricule = dr["matricule"].ToString();
                    studentList.Add(student);

                }
                con.Close();
            }
            return studentList;
        }
        public void Create_etudiant(etudiant student, etudiant image)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("insert_etudiant", con);
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@idnomfac", student.idfaculte);
                cmd.Parameters.AddWithValue("@idprom", student.idpromotion);
                cmd.Parameters.AddWithValue("@nom", student.noms);
                cmd.Parameters.AddWithValue("@prenom", student.prenom);
                cmd.Parameters.AddWithValue("@nomresp", student.nomrespo);
                cmd.Parameters.AddWithValue("@contactresp", student.contactresp);
                cmd.Parameters.AddWithValue("@datenaiss", student.datenaiss);
                cmd.Parameters.AddWithValue("@sexe", student.sexe);
                cmd.Parameters.AddWithValue("@contact", student.contact);
                cmd.Parameters.AddWithValue("@photo", image.photo);
                cmd.Parameters.AddWithValue("@mail", student.adressemail);
                cmd.Parameters.AddWithValue("@adresse", student.adresse);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public etudiant GetEtudiantById(int? Id)
        {
            var student = new etudiant();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Select_etudiant_by_id", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", Id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    student.id= Convert.ToInt32(dr["id"].ToString());
                    student.idfaculte = dr["Nom_facultes"].ToString();
                    student.idpromotion = dr["Nom_promotion"].ToString();
                    student.noms =dr["Noms"].ToString();
                    student.prenom = dr["Prenom"].ToString();
                    student.nomrespo = dr["Nomsresponsable"].ToString();
                    student.contactresp = dr["Contactrsp"].ToString();
                    student.sexe = dr["Sexe"].ToString();
                    student. contact = dr["Contact"].ToString();
                    student.photo = dr["Photo"].ToString();
                    student.adressemail = dr["Adressemail"].ToString();
                    student.adresse = dr["Adresse"].ToString();
                    student.matricule = dr["matricule"].ToString();
                    student.datenaiss = dr["Datenaissance"].ToString();

                   


                }
                con.Close();
            }
            return student;
        }

        public void Paiement_student(etudiant etudiant)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("valide_payement", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", etudiant.id);
                cmd.Parameters.AddWithValue("@montant", etudiant.montant);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
