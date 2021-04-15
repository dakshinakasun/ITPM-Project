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
    class StudentClass
    {
        //..............Getters and setters properties....................
        public int ID { get; set; }
        public string AcademicYearAndSemester { get; set; }
        public string Programme { get; set; }
        public int GroupNo { get; set; }
        public int SubGroupNo { get; set; }
        public string GroupID { get; set; }
        public string SubGroupID { get; set; }

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
                string sql = "SELECT * FROM tbl_studentg";
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
        public bool Insert(StudentClass s)
        {
            //creating default return type and setting its values to false
            bool isSuccess = false;
            //step 1: connect Database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: create a sql query to insert data
                string sql = "INSERT INTO tbl_studentg (AcademicYearAndSemester, Programme, GroupNo, SubGroupNo, GroupID, SubGroupID) VALUES (@AcademicYearAndSemester, @Programme, @GroupNo, @SubGroupNo, @GroupID, @SubGroupID)";
                //creating sql commend using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creat parameter to add data
                cmd.Parameters.AddWithValue("@AcademicYearAndSemester", s.AcademicYearAndSemester);
                cmd.Parameters.AddWithValue("@Programme", s.Programme);
                cmd.Parameters.AddWithValue("@GroupNo", s.GroupNo);
                cmd.Parameters.AddWithValue("@SubGroupNo", s.SubGroupNo);
                cmd.Parameters.AddWithValue("@GroupID", s.GroupID);
                cmd.Parameters.AddWithValue("@SubGroupID", s.SubGroupID);

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
        public bool Update(StudentClass s)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in our database
                string sql = "UPDATE tbl_studentg SET AcademicYearAndSemester=@AcademicYearAndSemester, Programme=@Programme, GroupNo=@GroupNo, SubGroupNo=@SubGroupNo, GroupID=@GroupID, SubGroupID=@SubGroupID WHERE ID=@ID";
                //create sql commend
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add values
                cmd.Parameters.AddWithValue("@AcademicYearAndSemester", s.AcademicYearAndSemester);
                cmd.Parameters.AddWithValue("@Programme", s.Programme);
                cmd.Parameters.AddWithValue("@GroupNo", s.GroupNo);
                cmd.Parameters.AddWithValue("@SubGroupNo", s.SubGroupNo);
                cmd.Parameters.AddWithValue("@GroupID", s.GroupID);
                cmd.Parameters.AddWithValue("@SubGroupID", s.SubGroupID);
                cmd.Parameters.AddWithValue("@ID", s.ID);


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
        public bool Delete(StudentClass s)
        {
            //create a default values and set its values to false
            bool isSuccess = false;
            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM tbl_studentg WHERE ID=@ID";

                //create sql commend
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", s.ID);

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
