using Dapper;
using GiftAPI.lib.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GiftAPI.lib.Repo
{
    public class Courserepo
    {
        public readonly string connectionString;



        public Courserepo()
        {
            connectionString = @"Data source=DESKTOP-UCPA9BN;Initial catalog=StudentInformation;User Id=sa;Password=Anaiyaan@123";
        }

        public void Insertcoursename(Course Std)
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
        public Course Getcoursename(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                var connection = new SqlConnection(connectionString);
                con.Open();
                var student = connection.QueryFirst<Course>($" exec GETcoursenameByid {id} ");
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

        public List<Course> Getcoursename()
        {
            try
            {
                List<Course> constrain = new List<Course>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<Course>($"  exec GETcoursename ").ToList();
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

        public void Updatecoursename(Course Std)
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
