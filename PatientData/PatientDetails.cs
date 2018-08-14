using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientData
{
    public partial class PatientDetails : Form
    {
        public PatientDetails()
        {
            InitializeComponent();
        }

        Patient pat = new Patient();
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttReg_Click(object sender, EventArgs e)
        {
            pat.FirstName = textbox_firstname.Text;
            pat.MiddleName = textbox_middlename.Text;
            pat.LastName = textbox_lastname.Text;
            pat.Gender = combbox_gender.Text;

            string dateofbirth = dateTimePicker1.Value.ToShortDateString();       
            DateTime parsedDate;
            string pattern = "yyyy-MM-dd";
            DateTime.TryParseExact(dateofbirth, pattern, null, DateTimeStyles.None, out parsedDate);
            
            pat.DateOfBirth = parsedDate;
            pat.PhoneNo = textbox_phnno.Text;
            pat.Addresss = textbox_addr.Text;
            pat.EmailId = textbox_email.Text;
            pat.Reason = textbox_reason.Text;

            bool isSuccess = pat.Insert(pat);
            if(isSuccess == true)
            {
                MessageBox.Show("Registration is successful.");
                clear_fields();
            }
            else
            {
                MessageBox.Show("Registration is not successful. Try again.");
            }

        }

        /*private void butt_close_Click(object sender, EventArgs e)
        {
            
        }*/

        private void butt_goback_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        public void clear_fields()
        {

            textbox_firstname.Text = "";
            textbox_middlename.Text = "";
            textbox_lastname.Text = "";
            combbox_gender.Text = "";
            //dateTimePicker1.CustomFormat = " ";
            textbox_phnno.Text = "";
            textbox_addr.Text = "";
            textbox_email.Text = "";
            textbox_reason.Text = "";
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblReasonVisit_Click(object sender, EventArgs e)
        {

        }

        private void buttHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttexit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void textboxpatid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_lastname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
