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
    class SessionRoomClass
    {
        //Getter Setter Properties
        //Acts as Data Carrier in Our Application
        public int ID { get; set; }
        public int  SessionID { get; set; }
        public string Select_Room { get; set; }
        public string Selected_Sessions { get; set; }

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
                string sql = "select s.*, se.Select_Room from Session s, tbl_SessionRoom se where s.SessionID = se.SessionID";
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


        //Inserting Data to Database 
        public bool Insert(SessionRoomClass n)
        {
            //Creating a default return type and setting to value to false 
            bool isSuccess = false;

            // Step 1 : Connect Databse
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step 2:Create a SQL Query to insert Data
                string sql = "INSERT INTO tbl_SessionRoom (SessionID,Select_Room,Selected_Sessions) VALUES(@SessionID, @Select_Room, @Selected_Sessions)";
                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data 
                cmd.Parameters.AddWithValue("@SessionID", n.SessionID);
                cmd.Parameters.AddWithValue("@Select_Room", n.Select_Room);
                cmd.Parameters.AddWithValue("@Selected_Sessions", n.Selected_Sessions);
                

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




    }
}
