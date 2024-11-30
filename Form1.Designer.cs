namespace JobApplication
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

      
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

        private void InitializeComponent()
        {
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtJobDescription = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpApplicationDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpApplicationDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(12, 12);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(200, 20);
            this.txtCompanyName.TabIndex = 0;
            this.txtCompanyName.Text = "Company Name";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(12, 38);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(200, 20);
            this.txtJobTitle.TabIndex = 1;
            this.txtJobTitle.Text = "Job Title";
            // 
            // txtJobDescription
            // 
            this.txtJobDescription.Location = new System.Drawing.Point(12, 68);
            this.txtJobDescription.Name = "txtJobDescription";
            this.txtJobDescription.Size = new System.Drawing.Size(200, 20);
            this.txtJobDescription.TabIndex = 2;
            this.txtJobDescription.Text = "Job Description";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(12, 96);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(200, 20);
            this.txtContactName.TabIndex = 3;
            this.txtContactName.Text = "Contact Person Name";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(12, 124);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(200, 20);
            this.txtContactEmail.TabIndex = 4;
            this.txtContactEmail.Text = "Contact Person Email";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(12, 152);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(200, 20);
            this.txtContactPhone.TabIndex = 5;
            this.txtContactPhone.Text = "Contact Person Phone";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 180);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(200, 20);
            this.txtNotes.TabIndex = 6;
            this.txtNotes.Text = "Notes";
            // 
            // dtpApplicationDate
            // 
            this.dtpApplicationDate.Location = new System.Drawing.Point(597, 9);
            this.dtpApplicationDate.Name = "dtpApplicationDate";
            this.dtpApplicationDate.Size = new System.Drawing.Size(200, 20);
            this.dtpApplicationDate.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Applied",
            "Interview Scheduled",
            "Offer Received",
            "Rejected"});
            this.cmbStatus.Location = new System.Drawing.Point(12, 206);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 8;
            this.cmbStatus.Text = "Status";
            // 
            // dtpApplicationDeadline
            // 
            this.dtpApplicationDeadline.Location = new System.Drawing.Point(12, 264);
            this.dtpApplicationDeadline.Name = "dtpApplicationDeadline";
            this.dtpApplicationDeadline.Size = new System.Drawing.Size(200, 20);
            this.dtpApplicationDeadline.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 369);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 30);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit Application";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpApplicationDate);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtContactPhone);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtJobDescription);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.txtCompanyName);
            this.Name = "Form1";
            this.Text = "Job Application Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Declare the controls
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtJobDescription;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dtpApplicationDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpApplicationDeadline;
        private System.Windows.Forms.Button btnSubmit; // Declare the submit button
    }
}
