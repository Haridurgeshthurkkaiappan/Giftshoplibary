using Giftshoplibary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using  System.Data.SqlClient;



namespace Giftshoplibary.Business
{
    public class StudentInformationBusiness
    {
        public readonly string connectionString;



        public StudentInformationBusiness()
        {
            connectionString = @"Data source=DESKTOP-UCPA9BN;Initial catalog=StudentInformation;User Id=sa;Password=Anaiyaan@123";
        }

        public void InsertStudentInformation(StudentInfoModel Std)
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
        public StudentInfoModel GetStudentInformation(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                var connection = new SqlConnection(connectionString);
                con.Open();
                var student = connection.QueryFirst<StudentInfoModel>($" exec GetStudentInformationById {id} ");
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

        public List<StudentInfoModel> GetStudentInformations()
        {
            try
            {
                List<StudentInfoModel> constrain = new List<StudentInfoModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<StudentInfoModel>($" exec GetStudentInformation ").ToList();
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

        public void UpdateStudentInformation(StudentInfoModel Std)
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

    }
}
