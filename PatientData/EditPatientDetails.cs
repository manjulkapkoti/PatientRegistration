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
    public partial class EditPatientDetails : Form
    {
        Patient patDetail;
        public EditPatientDetails()
        {
            InitializeComponent();
        }

        public EditPatientDetails(Patient pat)
        {
            InitializeComponent();
            patDetail = pat;

            textbox_editfirstname.Text = patDetail.FirstName;
            textbox_editmiddlename.Text = patDetail.MiddleName;
            textbox_editlastname.Text = patDetail.LastName;
            combbox_editgender.Text = patDetail.Gender;
            //updateTimePicker.Value = patDetail.DateOfBirth;
            textbox_editphnno.Text = patDetail.PhoneNo;
            textbox_editaddr.Text = patDetail.Addresss;
            textbox_editemail.Text = patDetail.EmailId;
            textbox_editreason.Text = patDetail.Reason;
        }
        private void buttUpdate_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.PatientId = patDetail.PatientId;
            pat.FirstName = textbox_editfirstname.Text;
            pat.MiddleName = textbox_editmiddlename.Text;
            pat.LastName = textbox_editlastname.Text;
            pat.Gender = combbox_editgender.Text;

            string dateofbirth = updateTimePicker.Value.ToShortDateString();
            DateTime parsedDate;
            string pattern = "yyyy-MM-dd";
            DateTime.TryParseExact(dateofbirth, pattern, null, DateTimeStyles.None, out parsedDate);

            pat.DateOfBirth = parsedDate;
            pat.PhoneNo = textbox_editphnno.Text;
            pat.Addresss = textbox_editaddr.Text;
            pat.EmailId = textbox_editemail.Text;
            pat.Reason = textbox_editreason.Text;

            //update the details
            bool isSuccess = pat.Update(pat);

            if (isSuccess == true)
            {
                MessageBox.Show("Details are successfully updated");
                textbox_editfirstname.Clear();
                textbox_editmiddlename.Clear();
                textbox_editlastname.Clear();
                combbox_editgender.Text = "";
                //updateTimePicker.CustomFormat = " ";
                textbox_editphnno.Clear();
                textbox_editaddr.Clear();
                textbox_editemail.Clear();
                textbox_editreason.Clear();
            }
            else
            {
                MessageBox.Show("Updating failed");
            }
        }

        private void buttView_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientRecord patRec = new PatientRecord();
            patRec.ShowDialog();
            this.Close();
        }

        private void buttDel_Click(object sender, EventArgs e)
        {

        }

        private void buttCloseApp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //updateTimePicker.CustomFormat = "yyyy-MM-dd";
        }

        private void textbox_editreason_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
