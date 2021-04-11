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
    class SubjectClass
    {
        //..............Getters and setters properties....................
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public string OfferedYear { get; set; }
        public string OfferedSem { get; set; }
        public int LecHours { get; set; }
        public int LabHours { get; set; }
        public int TuteHours { get; set; }
        public int EvaluHours { get; set; }

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
                string sql = "SELECT * FROM Subjects";
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
        public bool Insert(SubjectClass s)
        {
            //creating default return type and setting its values to false
            bool isSuccess = false;
            //step 1: connect Database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: create a sql query to insert data
                string sql = "INSERT INTO Subjects (SubjectName, SubjectCode, OfferedYear, OfferedSem, LecHours, LabHours, TuteHours, EvaluHours) VALUES (@SubjectName, @SubjectCode, @OfferedYear, @OfferedSem, @LecHours, @LabHours, @TuteHours, @EvaluHours)";
                //creating sql commend using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creat parameter to add data
                cmd.Parameters.AddWithValue("@SubjectName", s.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@OfferedYear", s.OfferedYear);
                cmd.Parameters.AddWithValue("@OfferedSem", s.OfferedSem);
                cmd.Parameters.AddWithValue("@LecHours", s.LecHours);
                cmd.Parameters.AddWithValue("@LabHours", s.LabHours);
                cmd.Parameters.AddWithValue("@TuteHours", s.TuteHours);
                cmd.Parameters.AddWithValue("@EvaluHours", s.EvaluHours);

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
        public bool Update(SubjectClass s)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in our database
                string sql = "UPDATE Subjects SET SubjectName=@SubjectName, SubjectCode=@SubjectCode, OfferedYear=@OfferedYear, OfferedSem=@OfferedSem, LecHours=@LecHours, LabHours=@LabHours, TuteHours=@TuteHours, EvaluHours=@EvaluHours WHERE SubjectID=@SubjectID";
                //create sql commend
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add values
                cmd.Parameters.AddWithValue("@SubjectID", s.SubjectID);
                cmd.Parameters.AddWithValue("@SubjectName", s.SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@OfferedYear", s.OfferedYear);
                cmd.Parameters.AddWithValue("@OfferedSem", s.OfferedSem);
                cmd.Parameters.AddWithValue("@LecHours", s.LecHours);
                cmd.Parameters.AddWithValue("@LabHours", s.LabHours);
                cmd.Parameters.AddWithValue("@TuteHours", s.TuteHours);
                cmd.Parameters.AddWithValue("@EvaluHours", s.EvaluHours);

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
        public bool Delete(SubjectClass s)
        {
            //create a default values and set its values to false
            bool isSuccess = false;
            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM Subjects WHERE SubjectID=@SubjectID";

                //create sql commend
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SubjectID", s.SubjectID);

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
