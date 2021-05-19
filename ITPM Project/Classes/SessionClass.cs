using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPM_Project.Classes
{
    class SessionClass
    {
        //..............Getters and setters properties....................
        public int SessionID { get; set; }
        public string FirstLectureName { get; set; }
        public string SecondLectureName { get; set; }
        public string Tag { get; set; }
        public string StudentGroup { get; set; }
        public string StudentSubGroup { get; set; }
        public string Subject { get; set; }
        public string Duration { get; set; }
        public int NoOfStudents { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //..............Select data from database....................
        public DataTable Select()
        {
            //step 1: database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //step 2: writting sql query
                string sql = "SELECT * FROM Session";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating sql dataadapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //....................Insert Data into database....................
        public bool Insert(SessionClass se)
        {
            //creating default return type and setting its values to false
            bool isSuccess = false;
            //step 1: connect Database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: create a sql query to insert data
                string sql = "INSERT INTO Session (FirstLectureName, SecondLectureName, Tag, StudentGroup, StudentSubGroup, Subject, Duration, NoOfStudents) VALUES (@FirstLectureName, @SecondLectureName, @Tag, @StudentGroup, @StudentSubGroup, @Subject, @Duration, @NoOfStudents)";
                //creating sql commend using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creat parameter to add data
                cmd.Parameters.AddWithValue("@FirstLectureName", se.FirstLectureName);
                cmd.Parameters.AddWithValue("@SecondLectureName", se.SecondLectureName);
                cmd.Parameters.AddWithValue("@Tag", se.Tag);
                cmd.Parameters.AddWithValue("@StudentGroup", se.StudentGroup);
                cmd.Parameters.AddWithValue("@StudentSubGroup", se.StudentSubGroup);
                cmd.Parameters.AddWithValue("@Subject", se.Subject);
                cmd.Parameters.AddWithValue("@Duration", se.Duration);
                cmd.Parameters.AddWithValue("@NoOfStudents", se.NoOfStudents);

                //open connection here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query successfully then value of rows will be generate than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //....................Method to update data in database from our app....................
        //Method to update data in database from our app
        public bool Update(SessionClass se)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in our database
                string sql = "UPDATE Session SET FirstLectureName=@FirstLectureName, SecondLectureName=@SecondLectureName, Tag=@Tag, StudentGroup=@StudentGroup, StudentSubGroup=@StudentSubGroup, Subject=@Subject, Duration=@Duration, NoOfStudents=@NoOfStudents WHERE SessionID=@SessionID";
                //create sql commend
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add values
                cmd.Parameters.AddWithValue("@SessionID", se.SessionID);
                cmd.Parameters.AddWithValue("@FirstLectureName", se.FirstLectureName);
                cmd.Parameters.AddWithValue("@SecondLectureName", se.SecondLectureName);
                cmd.Parameters.AddWithValue("@Tag", se.Tag);
                cmd.Parameters.AddWithValue("@StudentGroup", se.StudentGroup);
                cmd.Parameters.AddWithValue("@StudentSubGroup", se.StudentSubGroup);
                cmd.Parameters.AddWithValue("@Subject", se.Subject);
                cmd.Parameters.AddWithValue("@Duration", se.Duration);
                cmd.Parameters.AddWithValue("@NoOfStudents", se.NoOfStudents);

                //open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query rund successfylly then the value of rows will be grater than zero else values will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //....................method to delete data from database....................
        public bool Delete(SessionClass se)
        {
            //create a default values and set its values to false
            bool isSuccess = false;
            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM Session WHERE SessionID=@SessionID";

                //create sql commend
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SessionID", se.SessionID);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query rund successfylly then the value of rows will be grater than zero else values will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                //cloase connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
