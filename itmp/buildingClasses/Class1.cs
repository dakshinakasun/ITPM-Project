using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itmp.buildingClasses
{
    class Class1
    {
        //Getter Setter Proprerties
        //Acts as Data Carrier in our application
        public int BID { get; set; }
        public String BuildingName { get; set; }
        public int NumberOfRooms { get; set; }

        static String myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        //Selecting Data from Database 
        public DataTable Select()
        { 
        
            ///Step 1: Database  Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Wirting SQL Query
                String sql = "SELECT * FROM tbl_building";
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


            //Inserting Data Database 
            public bool Insert (Class1 c)
        {
            //creating a default return type and setting its value to false 
            bool isSuccess = false;

            // Step 1 : Connect Databse 
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step:2 Create a SQL Query to insert Data 
                string sql = "INSERT INTO tbl_building (BuildingName, NumberOfRooms) VALUES(@BuildingName, @NumberOfRooms)";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data 
                cmd.Parameters.AddWithValue("@BuildingName", c.BuildingName);
                cmd.Parameters.AddWithValue("@NumberOfRooms", c.NumberOfRooms);

                //Connection Open Here 
                conn.Open();
                int rows=cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of will be greater than zero else its value will be 0 
                if(rows>0)
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

            //Method to update date in database from our application 
            public bool Update(Class1 c)
            {

            //create a Default return type and set its default value to false 
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to update data in our Database 
                string sql = "UPDATE tbl_building SET BuildingName=@BuildingName, NumberOfRooms=@NumberOfRooms WHERE BID=@BID";


                //Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Paramters to add value 
                cmd.Parameters.AddWithValue("@BuildingName", c.BuildingName);
                cmd.Parameters.AddWithValue("@NumberOfRooms", c.NumberOfRooms);
                cmd.Parameters.AddWithValue("@BID", c.BID);
                //Open Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be zero 
                if(rows>0)
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
            public bool Delete(Class1 c)
            {
            //Create a default return value and set its value to false 
            bool isSuccess = false;
            // create SQL Connection 
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to delete Data 
                string sql = "DELETE FROM tbl_building WHERE BID=@BID";

                //creating SQL Commond 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@BID", c.BID);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query run successfully then the value of rows is greater than zero else its value is 0
                if(rows>0)
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
