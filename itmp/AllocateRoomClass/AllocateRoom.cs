using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itmp.AllocateRoom
{
    class AllocateRoom
    {
        //Getter and setter
        //Acts as Data Carrier in our Application
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Group { get; set; }
        public string Lecture { get; set; }
        public string Session { get; set; }
        public string Sessions { get; set; }
        public string Tag { get; set; }
        public string Room { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting Data from Database 
        public DataTable Select()
        {
            //Step 1: database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {

                //Step 2: Wirting SQL Query
                string sql = "SELECT * FROM tbl_AllocateRoom";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data into database
        public bool Insert(AllocateRoom c)
        {
            //Creating a default return type and setting to value to false 
            bool isSuccess = false;

            // Step 1 : Connect Databse
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step 2:Create a SQL Query to insert Data
                string sql = "INSERT INTO tbl_AllocateRoom (Subject,Group,Lecture,Session,Sessions,Tag,Rooms ) VALUES(@Subject, @Group, @Lecture, @Session, @Sessions, @Tag, @Rooms)";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data 
                cmd.Parameters.AddWithValue("@Subject", c.Subject);
                cmd.Parameters.AddWithValue("@Group", c.Group);
                cmd.Parameters.AddWithValue("@Lecture", c.Lecture);
                cmd.Parameters.AddWithValue("@Session", c.Session);
                cmd.Parameters.AddWithValue("@Sessions", c.Sessions);
                cmd.Parameters.AddWithValue("@Tag", c.Tag);
                cmd.Parameters.AddWithValue("@Rooms", c.Room);

                //Open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of will be greater than zero else its value will be 0 
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

        //Method to update date in database from our application 
        public bool Update(AllocateRoom c)
        {
            //create a Default return type and set its default value to false 
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                //SQL to update data in our Database 
                string sql = "UPDATE tbl_AllocateRoom SET Subject=@Subject, Group=@Group, Lecture=@Lecture, Session=@Session, Sessions=@Sessions, Tag=@Tag, Rooms=@Rooms WHERE ID=@ID";

                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Paramters to add value 
                cmd.Parameters.AddWithValue("@Subject", c.Subject);
                cmd.Parameters.AddWithValue("@Group", c.Group);
                cmd.Parameters.AddWithValue("@Lecture", c.Lecture);
                cmd.Parameters.AddWithValue("@Session", c.Session);
                cmd.Parameters.AddWithValue("@Sessions", c.Sessions);
                cmd.Parameters.AddWithValue("@Tag", c.Tag);
                cmd.Parameters.AddWithValue("@Room", c.Room);
                cmd.Parameters.AddWithValue("@ID", c.ID);

                //Open Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be zero 
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to Database Data from Database 
        public bool Delete(AllocateRoom c)
        {
            //Create a default return value and set its value to false 
            bool isSuccess = false;
            // create SQL Connection 
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL to delete Data 
                string sql = "DELETE FROM tbl_AllocateRoom WHERE ID=@ID";

                //creating SQL Commond 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", c.ID);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query run successfully then the value of rows is greater than zero else its value is 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
            
        }



    }
}
