namespace PatientData
{
    partial class PatientRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRecord));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.dgv_searchresult = new System.Windows.Forms.DataGridView();
            this.buttEdit = new System.Windows.Forms.Button();
            this.buttHome = new System.Windows.Forms.Button();
            this.buttDelRec = new System.Windows.Forms.Button();
            this.buttexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchresult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1336, 747);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(947, 112);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(166, 32);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Find Patient";
            // 
            // textboxSearch
            // 
            this.textboxSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textboxSearch.Location = new System.Drawing.Point(205, 110);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(725, 34);
            this.textboxSearch.TabIndex = 3;
            this.textboxSearch.Text = "Search by name";
            this.textboxSearch.TextChanged += new System.EventHandler(this.textboxSearch_TextChanged);
            // 
            // dgv_searchresult
            // 
            this.dgv_searchresult.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_searchresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_searchresult.Location = new System.Drawing.Point(205, 158);
            this.dgv_searchresult.Name = "dgv_searchresult";
            this.dgv_searchresult.RowTemplate.Height = 24;
            this.dgv_searchresult.Size = new System.Drawing.Size(917, 409);
            this.dgv_searchresult.TabIndex = 4;
            this.dgv_searchresult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_searchresult_CellContentClick);
            this.dgv_searchresult.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_searchresult_RowHeaderMouseClick);
            // 
            // buttEdit
            // 
            this.buttEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttEdit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttEdit.Location = new System.Drawing.Point(367, 599);
            this.buttEdit.Name = "buttEdit";
            this.buttEdit.Size = new System.Drawing.Size(114, 72);
            this.buttEdit.TabIndex = 6;
            this.buttEdit.Text = "Edit Record";
            this.buttEdit.UseVisualStyleBackColor = false;
            this.buttEdit.Click += new System.EventHandler(this.buttEdit_Click);
            // 
            // buttHome
            // 
            this.buttHome.BackColor = System.Drawing.Color.Coral;
            this.buttHome.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttHome.Location = new System.Drawing.Point(686, 599);
            this.buttHome.Name = "buttHome";
            this.buttHome.Size = new System.Drawing.Size(114, 72);
            this.buttHome.TabIndex = 9;
            this.buttHome.Text = "Home";
            this.buttHome.UseVisualStyleBackColor = false;
            this.buttHome.Click += new System.EventHandler(this.buttHome_Click);
            // 
            // buttDelRec
            // 
            this.buttDelRec.BackColor = System.Drawing.Color.SteelBlue;
            this.buttDelRec.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttDelRec.Location = new System.Drawing.Point(524, 599);
            this.buttDelRec.Name = "buttDelRec";
            this.buttDelRec.Size = new System.Drawing.Size(114, 72);
            this.buttDelRec.TabIndex = 10;
            this.buttDelRec.Text = "Delete Record";
            this.buttDelRec.UseVisualStyleBackColor = false;
            this.buttDelRec.Click += new System.EventHandler(this.buttDelRec_Click);
            // 
            // buttexit
            // 
            this.buttexit.BackColor = System.Drawing.Color.Coral;
            this.buttexit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttexit.Location = new System.Drawing.Point(845, 599);
            this.buttexit.Name = "buttexit";
            this.buttexit.Size = new System.Drawing.Size(114, 72);
            this.buttexit.TabIndex = 11;
            this.buttexit.Text = "Exit";
            this.buttexit.UseVisualStyleBackColor = false;
            this.buttexit.Click += new System.EventHandler(this.buttexit_Click);
            // 
            // PatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 744);
            this.Controls.Add(this.buttexit);
            this.Controls.Add(this.buttDelRec);
            this.Controls.Add(this.buttHome);
            this.Controls.Add(this.buttEdit);
            this.Controls.Add(this.dgv_searchresult);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PatientRecord";
            this.Text = "PatientRecord";
            this.Load += new System.EventHandler(this.PatientRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.DataGridView dgv_searchresult;
        private System.Windows.Forms.Button buttEdit;
        private System.Windows.Forms.Button buttHome;
        private System.Windows.Forms.Button buttDelRec;
        private System.Windows.Forms.Button buttexit;
    }
}