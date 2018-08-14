using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientData
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNo { get; set; }
        public string Addresss { get; set; }
        public string EmailId { get; set; }
        public string Reason { get; set; }

        public Patient()
        {
            PatientId = -1;
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting Data from database
        public DataTable Select()
        {
            //Step1. Connect to a database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                // Step2. Writing a sql query
                string sql = "SELECT * FROM tbl_PatientDatabase";
                // Creating cmd from sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creating sql adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // Inserting record into database
        public bool Insert(Patient pat)
        {
            bool isSuccess = false;
            // Step1. Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // Create a sql query to insert data
                string sql = "INSERT INTO tbl_PatientDatabase (FirstName, MiddleName, LastName, Gender, DateOfBirth, PhoneNo, Addresss, EmailId, Reason) VALUES (@FirstName, @MiddleName, @LastName, @Gender, @DateOfBirth, @PhoneNo, @Addresss, @EmailId, @Reason)";
                
                // Creating cmd from sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
               
                // Create Parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", pat.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", pat.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", pat.LastName);
                cmd.Parameters.AddWithValue("@Gender", pat.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", pat.DateOfBirth.ToShortDateString());
                cmd.Parameters.AddWithValue("@PhoneNo", pat.PhoneNo);
                cmd.Parameters.AddWithValue("@Addresss", pat.Addresss);
                cmd.Parameters.AddWithValue("@EmailId", pat.EmailId);
                cmd.Parameters.AddWithValue("@Reason", pat.Reason);

                // Opening the connection
                conn.Open();
                int rows = rows = cmd.ExecuteNonQuery();
             
                // If the query runs successfully then the value of rows will be greater than zero else its value will be zero
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            
            catch (Exception e)
            {
                MessageBox.Show("exception");
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        // Updating the database from the application
        public bool Update(Patient pat)
        {
            // Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_PatientDatabase SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, Gender=@Gender, DateOfBirth=@DateOfBirth, PhoneNo=@PhoneNo, Addresss=@Addresss, EmailId=@EmailId, Reason=@Reason WHERE PatientId=@PatientId";
                
                // Creating cmd from sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                // Create Parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", pat.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", pat.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", pat.LastName);
                cmd.Parameters.AddWithValue("@Gender", pat.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", pat.DateOfBirth.ToShortDateString());
                cmd.Parameters.AddWithValue("@PhoneNo", pat.PhoneNo);
                cmd.Parameters.AddWithValue("@Addresss", pat.Addresss);
                cmd.Parameters.AddWithValue("@EmailId", pat.EmailId);
                cmd.Parameters.AddWithValue("@Reason", pat.Reason);
                cmd.Parameters.AddWithValue("@PatientId", pat.PatientId);

                // Opening the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                // If the query runs successfully then the value of rows will be greater than zero else its value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {

            }
            finally
            {

            }

            return isSuccess;
        }
         
        // Deleting the record from database
        public bool Delete(Patient pat)
        {
            // Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_PatientDatabase WHERE PatientId=@PatientId";
                // Creating cmd from sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PatientId", pat.PatientId);

                // Opening the connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                // If the query runs successfully then the value of rows will be greater than zero else its value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception e)
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
