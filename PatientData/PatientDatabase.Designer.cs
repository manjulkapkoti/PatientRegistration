namespace PatientData
{
    partial class PatientDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDatabase));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPatDatabase = new System.Windows.Forms.Label();
            this.buttReg = new System.Windows.Forms.Button();
            this.buttPatRec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1337, 745);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPatDatabase
            // 
            this.lblPatDatabase.AutoSize = true;
            this.lblPatDatabase.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPatDatabase.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatDatabase.ForeColor = System.Drawing.Color.Black;
            this.lblPatDatabase.Location = new System.Drawing.Point(326, 173);
            this.lblPatDatabase.Name = "lblPatDatabase";
            this.lblPatDatabase.Size = new System.Drawing.Size(618, 90);
            this.lblPatDatabase.TabIndex = 2;
            this.lblPatDatabase.Text = "Patient Database";
            this.lblPatDatabase.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttReg
            // 
            this.buttReg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttReg.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttReg.Location = new System.Drawing.Point(524, 358);
            this.buttReg.Name = "buttReg";
            this.buttReg.Size = new System.Drawing.Size(235, 96);
            this.buttReg.TabIndex = 3;
            this.buttReg.Text = "Registration";
            this.buttReg.UseVisualStyleBackColor = false;
            this.buttReg.Click += new System.EventHandler(this.buttReg_Click);
            // 
            // buttPatRec
            // 
            this.buttPatRec.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttPatRec.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttPatRec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttPatRec.Location = new System.Drawing.Point(524, 498);
            this.buttPatRec.Name = "buttPatRec";
            this.buttPatRec.Size = new System.Drawing.Size(235, 87);
            this.buttPatRec.TabIndex = 4;
            this.buttPatRec.Text = "View Patient Record";
            this.buttPatRec.UseVisualStyleBackColor = false;
            this.buttPatRec.Click += new System.EventHandler(this.buttPatRec_Click);
            // 
            // PatientDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 751);
            this.Controls.Add(this.buttPatRec);
            this.Controls.Add(this.buttReg);
            this.Controls.Add(this.lblPatDatabase);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PatientDatabase";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPatDatabase;
        private System.Windows.Forms.Button buttReg;
        private System.Windows.Forms.Button buttPatRec;
    }
}

