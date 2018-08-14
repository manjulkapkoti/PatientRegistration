using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientData
{
    public partial class PatientDatabase : Form
    {
        public PatientDatabase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttReg_Click(object sender, EventArgs e)
        {
            // Patient registration page
        
            PatientDetails patdetails = new PatientDetails();
            patdetails.ShowDialog();
        }

        private void buttPatRec_Click(object sender, EventArgs e)
        {
            // search area page

            PatientRecord patRec = new PatientRecord();
            patRec.ShowDialog();
        }
    }
}
