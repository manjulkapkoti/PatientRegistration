using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientData
{
    public partial class PatientRecord : Form
    {
        Patient pat = new Patient();
        int SelectedId;
        public PatientRecord()
        {
            InitializeComponent();
            SelectedId = -1;
        }

        private void dgv_searchresult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PatientRecord_Load(object sender, EventArgs e)
        {
            SelectedId = -1;
            DataTable dt = pat.Select();
            dgv_searchresult.DataSource = dt;

            dgv_searchresult.BorderStyle = BorderStyle.None;
            dgv_searchresult.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_searchresult.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_searchresult.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv_searchresult.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_searchresult.BackgroundColor = Color.White;

            dgv_searchresult.EnableHeadersVisualStyles = false;
            dgv_searchresult.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_searchresult.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_searchresult.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dgv_searchresult_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the data from data grid view and load it to the textboxes respectively
            // identitfy the row on which mouse is clicked

            int rowIndex = e.RowIndex;
            pat.FirstName = dgv_searchresult.Rows[rowIndex].Cells[0].Value.ToString();
            pat.MiddleName = dgv_searchresult.Rows[rowIndex].Cells[1].Value.ToString();
            pat.LastName = dgv_searchresult.Rows[rowIndex].Cells[2].Value.ToString();
            pat.Gender = dgv_searchresult.Rows[rowIndex].Cells[3].Value.ToString();
            string dateofbirth = dgv_searchresult.Rows[rowIndex].Cells[4].Value.ToString();
            
            DateTime parsedDate;
           
            string pattern = "yyyy-MM-dd HH:mm:ss tt";
            DateTime.TryParseExact(dateofbirth, pattern, null, DateTimeStyles.None, out parsedDate);
            
            pat.DateOfBirth = parsedDate;

            pat.PhoneNo = dgv_searchresult.Rows[rowIndex].Cells[5].Value.ToString();
            pat.Addresss = dgv_searchresult.Rows[rowIndex].Cells[6].Value.ToString();
            pat.EmailId = dgv_searchresult.Rows[rowIndex].Cells[7].Value.ToString();
            pat.Reason = dgv_searchresult.Rows[rowIndex].Cells[8].Value.ToString();

            int.TryParse(dgv_searchresult.Rows[rowIndex].Cells[9].Value.ToString(), out SelectedId);
            pat.PatientId = SelectedId;
        }

        private void buttEdit_Click(object sender, EventArgs e)
        {
            if(SelectedId != -1)
            {
                this.Hide();
                EditPatientDetails editdetails = new EditPatientDetails(pat);
                editdetails.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Select the Patient Id.");
            }
            
        }

        private void buttclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void butCloseApp_Click(object sender, EventArgs e)
        {
            
        }*/

        private void buttHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttClear_Click(object sender, EventArgs e)
        {

        }

        private void buttDelRec_Click(object sender, EventArgs e)
        {
            if(SelectedId != -1)
            {
                bool isSuccess = pat.Delete(pat);
                if (isSuccess == true)
                {
                    MessageBox.Show("Patient Record is deleted successfully.");
                    DataTable dt = pat.Select();
                    dgv_searchresult.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Patient Record could not be deleted.");
                }
            }
            else
            {
                MessageBox.Show("Select the Patien Id to delete the record.");
            }
            
        }

        private void buttexit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void textboxSearch_TextChanged(object sender, EventArgs e)
        {
            // get the value from the text box
            string keyword = textboxSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);

            string sql = "SELECT * FROM tbl_PatientDatabase WHERE FirstName LIKE '%" + keyword + "%' OR MiddleName LIKE '%" + keyword + "%' OR Lastname LIKE '%" + keyword + "%'";
            // Creating cmd from sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            // Creating sql adapter using cmd
            SqlDataAdapter sqladapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqladapter.Fill(dt);
            
            dgv_searchresult.DataSource = dt;
        }
    }
}
