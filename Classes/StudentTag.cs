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
    class StudentTag
    {
        
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public int SubjectCode { get; set; }
        public string RelatedTag { get; set; }
        

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        
        public DataTable Select()
        {
            //step 1: database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //step 2: writting sql query
                string sql = "SELECT * FROM tbl_tag";
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
        public bool Insert(StudentTag c)
        {
            //creating default return type and setting its values to false
            bool isSuccess = false;
            //step 1: connect Database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: create a sql query to insert data
                string sql = "INSERT INTO tbl_tag (SubjectName, SubjectCode, RelatedTag) VALUES (@SubjectName, @SubjectCode, @RelatedTag)";
                //creating sql commend using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creat parameter to add data
                cmd.Parameters.AddWithValue("@SubjectName", c.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", c.SubjectCode);
                cmd.Parameters.AddWithValue("@RelatedTag", c.RelatedTag);
               

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

        
        public bool Update(StudentTag c)
        {
            
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                
                string sql = "UPDATE tbl_tag SET SubjectName=@SubjectName, SubjectCode=@SubjectCode, RelatedTag=@RelatedTag WHERE ID=@ID";
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@SubjectName", c.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", c.SubjectCode);
                cmd.Parameters.AddWithValue("@RelatedTag", c.RelatedTag);
                cmd.Parameters.AddWithValue("@ID", c.ID);


                
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                
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

        
        public bool Delete(StudentTag c)
        {
            //create a default values and set its values to false
            bool isSuccess = false;
            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM tbl_tag WHERE ID=@ID";

                //create sql commend
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", c.ID);

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
