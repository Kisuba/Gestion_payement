using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vrai_crud.Models;
using System.Data.SqlClient;
using System.Data;
namespace Vrai_crud.Context
{
    public class Crud_Dal
    {
        readonly string connetionString = "Data Source = DESKTOP-5A1D6KD; Initial Catalog = Payement_des_etudiants; Integrated Security = SSPI; User ID = sa; Password = aurelkisuba@123;";
                                            
        /// <summary>
        /// utiliser poour afficher tout les etudiants 
        /// </summary>
        /// <returns></returns>
        public int LoginCheck(Utilisateur ad)
        {
                SqlConnection con = new SqlConnection(connetionString);
            
                SqlCommand cmd = new SqlCommand("login_user", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomuser", ad.Nom_utilisateur);
                cmd.Parameters.AddWithValue("@mtdpasse", ad.motdepasse);
                SqlParameter oblogin = new SqlParameter();
                oblogin.ParameterName = "@valid";
                oblogin.SqlDbType = SqlDbType.Bit;
                oblogin.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(oblogin);
               
                con.Open();
                cmd.ExecuteNonQuery();
                int res = Convert.ToInt32(oblogin.Value);
                con.Close();

                return res;
         
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var studentList = new List<Student>();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Select_typeutilisateur", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var student = new Student();
                    student.Id = Convert.ToInt32(dr["Typeutilisateurid"].ToString());
                    student.Fonction = dr["Nomtype"].ToString();
                    student.Description = dr["Description"].ToString();
                    

                    studentList.Add(student);

                }
                con.Close();
            }
            return studentList;
        }
        /// <summary>
        /// create new student
        /// </summary>
        /// <param name="student"></param>
        public void Create_student(Student student)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Create_typeutilisateur", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nomtype", student.Fonction);
                cmd.Parameters.AddWithValue("@description", student.Description);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        /// <summary>
        /// create new student
        /// </summary>
        /// <param name="student"></param>
        public void Update_student(Student student)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Upadate_typeutilisateur", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@typeutilisateurid", student.Id);
                cmd.Parameters.AddWithValue("@nomtype", student.Fonction);
                cmd.Parameters.AddWithValue("@description", student.Description);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        /// <summary>
        /// delete student
        /// </summary>
        /// <param name="student"></param>
        public void Delete_student(int? Id)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Delete_typeutilisateur", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@typeutilisateurid", Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        /// <summary>
        /// GetStudentBuId 
        /// </summary>
        /// <param name="student"></param>
        public Student GetStudentById(int? Id)
        {
            var student = new Student();
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("Select_typeutilisateurbyid", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@typeutilisateurid", Id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    student.Id = Convert.ToInt32(dr["Typeutilisateurid"].ToString());
                    student.Fonction = dr["Nomtype"].ToString();
                    student.Description = dr["Description"].ToString();

                }
                con.Close();
            }
            return student;
        }
    }
}
