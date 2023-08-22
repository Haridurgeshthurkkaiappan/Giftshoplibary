using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Giftshoplibary.Model;


namespace Giftshoplibary.Business
{
    class CourseBusiness
    {
        public readonly string connectionString;



        public CourseBusiness()
        {
            connectionString = @"Data source=DESKTOP-UCPA9BN;Initial catalog=StudentInformation;User Id=sa;Password=Anaiyaan@123";
        }

        public void Insertcoursename(CourseModel Std)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" exec insertcoursename '{Std.course}'");

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
        public CourseModel Getcoursename(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                var connection = new SqlConnection(connectionString);
                con.Open();
                var student = connection.QueryFirst<CourseModel>($" exec GETcoursenameByid {id} ");
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

        public List<CourseModel> Getcoursename()
        {
            try
            {
                List<CourseModel> constrain = new List<CourseModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<CourseModel>($"  exec GETcoursename ").ToList();
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

        public void Updatecoursename(CourseModel Std)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" 	exec updatecoursename  '{Std.course}',{Std.courseid}");
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

        public void Deletecoursename(int id)
        {
            try
            {


                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" exec Deletecoursename { id}");

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
