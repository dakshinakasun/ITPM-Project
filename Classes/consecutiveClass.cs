using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTagProject.Classes
{
    class consecutiveClass
    {
        public int SessionID { get; set; }

        public string Subject { get; set; }

        public string Tag { get; set; }

        public string StudentGroup { get; set; }

        public string GroupID { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //selecting Data from databse
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try 
            {
                string sql = "SELECT * FROM tbl_consective";
                SqlCommand cmd = new SqlCommand(sql, conn);
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
        public DataTable Select1()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt1 = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_parallel";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt1);


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt1;
        }
        public DataTable Select2()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt1 = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_nonoverlapping";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt1);


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt1;
        }
        //inserting
        public bool Insert (consecutiveClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try 
            {
                string sql = "INSERT INTO tbl_consective (SessionID,Subject,Tag,GroupID) VALUES (@SessionID,@Subject,@Tag,@GroupID)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@SessionID", c.SessionID);
                cmd.Parameters.AddWithValue("@Subject", c.Subject);
                cmd.Parameters.AddWithValue("@Tag", c.Tag);
                cmd.Parameters.AddWithValue("@GroupID", c.GroupID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

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

    }
}
