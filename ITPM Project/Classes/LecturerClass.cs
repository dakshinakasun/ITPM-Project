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
    class LecturerClass
    {
        //..............Getters and setters properties....................
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rank { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LectureID { get; set; }
        public string Center { get; set; }
        public string Faculty { get; set; }
        public string Building { get; set; }
        public string Department { get; set; }
        public string LecLevel { get; set; }
        public string ActiveDays { get; set; }
        public string ActiveHours { get; set; }

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
                string sql = "SELECT * FROM Lecturer";
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
        public bool Insert(LecturerClass l)
        {
            //creating default return type and setting its values to false
            bool isSuccess = false;
            //step 1: connect Database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: create a sql query to insert data
                string sql = "INSERT INTO Lecturer (Title, Rank, FirstName, LastName, LectureID, Center, Faculty, Building, Department, LecLevel, ActiveDays, ActiveHours) VALUES (@Title, @Rank, @FirstName, @LastName, @LectureID, @Center, @Faculty, @Building, @Department, @LecLevel, @ActiveDays, @ActiveHours)";
                //creating sql commend using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creat parameter to add data
                cmd.Parameters.AddWithValue("@Title", l.Title);
                cmd.Parameters.AddWithValue("@Rank", l.Rank);
                cmd.Parameters.AddWithValue("@FirstName", l.FirstName);
                cmd.Parameters.AddWithValue("@LastName", l.LastName);
                cmd.Parameters.AddWithValue("@LectureID", l.LectureID);
                cmd.Parameters.AddWithValue("@Center", l.Center);
                cmd.Parameters.AddWithValue("@Faculty", l.Faculty);
                cmd.Parameters.AddWithValue("@Building", l.Building);
                cmd.Parameters.AddWithValue("@Department", l.Department);
                cmd.Parameters.AddWithValue("@LecLevel", l.LecLevel);
                cmd.Parameters.AddWithValue("@ActiveDays", l.ActiveDays);
                cmd.Parameters.AddWithValue("@ActiveHours", l.ActiveHours);

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
        public bool Update(LecturerClass l)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in our database
                string sql = "UPDATE Lecturer SET Title=@Title, Rank=@Rank, FirstName=@FirstName, LastName=@LastName, LectureID=@LectureID, Center=@Center, Faculty=@Faculty, Building=@Building, Department=@Department, LecLevel=@LecLevel WHERE Id=@Id";
                //create sql commend
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add values
                cmd.Parameters.AddWithValue("@id", l.Id);
                cmd.Parameters.AddWithValue("@Title", l.Title);
                cmd.Parameters.AddWithValue("@Rank", l.Rank);
                cmd.Parameters.AddWithValue("@FirstName", l.FirstName);
                cmd.Parameters.AddWithValue("@LastName", l.LastName);
                cmd.Parameters.AddWithValue("@LectureID", l.LectureID);
                cmd.Parameters.AddWithValue("@Center", l.Center);
                cmd.Parameters.AddWithValue("@Faculty", l.Faculty);
                cmd.Parameters.AddWithValue("@Building", l.Building);
                cmd.Parameters.AddWithValue("@Department", l.Department);
                cmd.Parameters.AddWithValue("@LecLevel", l.LecLevel);

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
        public bool Delete(LecturerClass l)
        {
            //create a default values and set its values to false
            bool isSuccess = false;
            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM Lecturer WHERE Id=@Id";

                //create sql commend
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", l.Id);

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
