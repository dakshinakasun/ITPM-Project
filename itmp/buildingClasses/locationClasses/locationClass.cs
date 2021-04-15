using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itmp.buildingClasses.locationClasses
{
    class locationClass
    {
        //Getter Setter Properties
        //Acts as Data Carrier in Our Application
        public int LocationID { get; set; }
        public string BuildingName { get; set; }
        public string Room { get; set; }
        public string RoomType { get; set; }
        public int Capacity { get; set; }

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
                string sql = "SELECT * FROM tbl_location";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
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

        //Inserting Data to Database 
        public bool Insert(locationClass n)
        {
            //Creating a default return type and setting to value to false 
            bool isSuccess = false;

            // Step 1 : Connect Databse
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step 2:Create a SQL Query to insert Data
                string sql = "INSERT INTO tbl_location (BuildingName,Room,RoomType,Capacity ) VALUES(@BuildingName, @Room, @RoomType, @Capacity)";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data 
                cmd.Parameters.AddWithValue("@BuildingName", n.BuildingName);
                cmd.Parameters.AddWithValue("@Room", n.Room);
                cmd.Parameters.AddWithValue("@RoomType", n.RoomType);
                cmd.Parameters.AddWithValue("@Capacity", n.Capacity);

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
        public bool Update(locationClass n)
        {
            //create a Default return type and set its default value to false 
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to update data in our Database 
                string sql = "UPDATE tbl_location SET BuildingName=@BuildingName, Room=@Room, RoomType=@RoomType, Capacity=@Capacity WHERE LocationID=@LocationID";

                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Paramters to add value 
                cmd.Parameters.AddWithValue("@BuildingName", n.BuildingName);
                cmd.Parameters.AddWithValue("@Room", n.Room);
                cmd.Parameters.AddWithValue("@RoomType", n.RoomType);
                cmd.Parameters.AddWithValue("@Capacity", n.Capacity);
                cmd.Parameters.AddWithValue("@LocationID", n.LocationID);

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
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;


        }

        //Method to Database Data from Database 
        public bool Delete(locationClass n)
        {
            //Create a default return value and set its value to false 
            bool isSuccess = false;
            // create SQL Connection 
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL to delete Data 
                string sql = "DELETE FROM tbl_location WHERE LocationID=@LocationID";

                //creating SQL Commond 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@LocationID", n.LocationID);

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
                //Close Connection
                conn.Close();
            }
            return isSuccess;

        }
    }
}
