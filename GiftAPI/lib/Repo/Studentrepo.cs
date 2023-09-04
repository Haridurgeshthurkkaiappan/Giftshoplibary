using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using GiftAPI.lib.Model;
using Dapper;

namespace GiftAPI.lib.Repo
{
    public class Studentrepo
    {
        public readonly string connectionString;



        public Studentrepo()
        {
            connectionString = @"Data source=DESKTOP-UCPA9BN;Initial catalog=StudentInformation;User Id=sa;Password=Anaiyaan@123";
        }

        public void InsertStudentInformation(Student Std)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" exec insertStudentInformation'{Std.Name}', '{Std.DOB.ToString("MM-dd-yyyy")}','{Std.Course}','{Std.Email}','{Std.Mobilenumber}'");

                con.Close();

            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public Student GetStudentInformation(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                var connection = new SqlConnection(connectionString);
                con.Open();
                var student = connection.QueryFirst<Student>($" exec GetStudentInformationById {id} ");
                con.Close();



                return student;


            }

            catch (SqlException er)
            {
                throw;
            }
            catch (Exception r)
            {
                throw r;
            }
        }

        public List<Student> GetStudentInformations()
        {
            try
            {
                List<Student> constrain = new List<Student>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<Student>($" exec GetStudentInformation ").ToList();
                connection.Close();

                return constrain;


            }

            catch (SqlException er)
            {
                throw;
            }
            catch (Exception r)
            {
                throw r;
            }
        }

        public void UpdateStudentInformation(Student Std)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" 	exec UpdateStudentInformation '{Std.Name}','{Std.DOB.ToString("MM-dd-yyyy")}','{Std.Course}','{Std.Email}',{Std.Mobilenumber},{Std.studentid}");
                con.Close();
            }
            catch (SqlException eu)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DeleteStudentInformation(int id)
        {
            try
            {


                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" exec DeleteStudentInformation { id}");

                con.Close();

            }
            catch (SqlException ed)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Boolean Itexists(string Name)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                var connection = new SqlConnection(connectionString);
                con.Open();
                var result = connection.QueryFirst<Boolean>($"  exec Itexists '{Name}' ");
                con.Close();



                return result;


            }

            catch (SqlException er)
            {
                throw;
            }
            catch (Exception r)
            {
                throw r;
            }
        }

        public Boolean Itexistsyid(string Name, int studentId)
        {
            try
            {



                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                var res = connection.QueryFirst<Boolean>($"exec Itexistsbyid '{Name}',{studentId}");
                connection.Close();

                return res;
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}

