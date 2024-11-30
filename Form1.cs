using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Server=localhost;Database=JobApplicationTrackerDB;Integrated Security=True;";

        
        //private DateTimePicker dtpApplicationDeadline;

        private object timerReminder;


        public Form1()
        {
            InitializeComponent();

            // Dynamically initialize the DateTimePicker if it's not done in the designer
            dtpApplicationDeadline = new DateTimePicker();
            dtpApplicationDeadline.Location = new Point(50, 50);  // Set location as needed
            dtpApplicationDeadline.Format = DateTimePickerFormat.Short;
            this.Controls.Add(dtpApplicationDeadline); // Add to the form's controls

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbStatus.Items.Add("Applied");
            cmbStatus.Items.Add("Interview Scheduled");
            cmbStatus.Items.Add("Offer Received");
            cmbStatus.Items.Add("Rejected");



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;
            string jobTitle = txtJobTitle.Text;
            string jobDescription = txtJobDescription.Text;
            string contactName = txtContactName.Text;
            string contactEmail = txtContactEmail.Text;
            string contactPhone = txtContactPhone.Text;
            string notes = txtNotes.Text;
            DateTime applicationDate = dtpApplicationDate.Value; // Get selected date
            string status = cmbStatus.SelectedItem.ToString();

        }


        private void AddJobEntry()
        {
            try
            {
                // Get values from the form controls
                string companyName = txtCompanyName.Text;
                string jobTitle = txtJobTitle.Text;
                string jobDescription = txtJobDescription.Text;
                string contactName = txtContactName.Text;
                string contactEmail = txtContactEmail.Text;
                string contactPhone = txtContactPhone.Text;
                string notes = txtNotes.Text;
                DateTime applicationDate = dtpApplicationDate.Value; // Get selected application date
                DateTime applicationDeadline = dtpApplicationDeadline.Value; // Get selected deadline date
                string status = cmbStatus.SelectedItem.ToString();

                // Your logic to save data into the database goes here

                // Example: Insert into database using SqlCommand (adjust query accordingly)
                string query = @"INSERT INTO JobApplications 
                         (CompanyName, JobTitle, JobDescription, ContactName, ContactEmail, ContactPhone, Notes, ApplicationDate, ApplicationDeadline, Status) 
                         VALUES 
                         (@CompanyName, @JobTitle, @JobDescription, @ContactName, @ContactEmail, @ContactPhone, @Notes, @ApplicationDate, @ApplicationDeadline, @Status)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CompanyName", companyName);
                        cmd.Parameters.AddWithValue("@JobTitle", jobTitle);
                        cmd.Parameters.AddWithValue("@JobDescription", jobDescription);
                        cmd.Parameters.AddWithValue("@ContactName", contactName);
                        cmd.Parameters.AddWithValue("@ContactEmail", contactEmail);
                        cmd.Parameters.AddWithValue("@ContactPhone", contactPhone);
                        cmd.Parameters.AddWithValue("@Notes", notes);
                        cmd.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                        cmd.Parameters.AddWithValue("@ApplicationDeadline", applicationDeadline);
                        cmd.Parameters.AddWithValue("@Status", status);

                        cmd.ExecuteNonQuery(); // Execute the insert query
                    }
                }
                MessageBox.Show("Job application entry added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            // Call the AddJobEntry method when the user clicks the "Add Job" button
            AddJobEntry();
        }

        private void UpdateJobStatus(int jobId, string newStatus)
        {
            string query = "UPDATE JobApplications SET Status = @Status WHERE Id = @JobId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@JobId", jobId);

                conn.Open();
                cmd.ExecuteNonQuery(); // Executes the update command
            }

            MessageBox.Show("Status updated successfully!");
        }

        private void CheckReminders()
        {
            // Get the application deadline date from the DateTimePicker control
            DateTime applicationDeadline = dtpApplicationDeadline.Value;

            // Check if the application deadline is today
            if (applicationDeadline.Date == DateTime.Today)
            {
                MessageBox.Show("Reminder: Job application deadline is today!");
            }
        }


        // Set up a timer to check reminders at regular intervals
        private void timerReminder_Tick(object sender, EventArgs e)
        {
            // 6. Call CheckReminders every time the timer ticks
            CheckReminders();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string companyName = txtCompanyName.Text;
            string jobTitle = txtJobTitle.Text;
            string jobDescription = txtJobDescription.Text;
            string contactName = txtContactName.Text;
            string contactEmail = txtContactEmail.Text;
            string contactPhone = txtContactPhone.Text;
            string notes = txtNotes.Text;
            DateTime applicationDate = dtpApplicationDate.Value; 
            DateTime applicationDeadline = dtpApplicationDeadline.Value; 
            string status = cmbStatus.SelectedItem.ToString(); 

           
            if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(jobTitle) || string.IsNullOrEmpty(contactName) || string.IsNullOrEmpty(contactEmail))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // SQL query to insert job application details into the database
            string query = @"INSERT INTO JobApplications (CompanyName, JobTitle, JobDescription, ContactName, ContactEmail, ContactPhone, Notes, ApplicationDate, ApplicationDeadline, Status) 
                     VALUES (@CompanyName, @JobTitle, @JobDescription, @ContactName, @ContactEmail, @ContactPhone, @Notes, @ApplicationDate, @ApplicationDeadline, @Status)";

            try
            {
                // Database connection and insertion logic
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@CompanyName", companyName);
                        cmd.Parameters.AddWithValue("@JobTitle", jobTitle);
                        cmd.Parameters.AddWithValue("@JobDescription", jobDescription);
                        cmd.Parameters.AddWithValue("@ContactName", contactName);
                        cmd.Parameters.AddWithValue("@ContactEmail", contactEmail);
                        cmd.Parameters.AddWithValue("@ContactPhone", contactPhone);
                        cmd.Parameters.AddWithValue("@Notes", notes);
                        cmd.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                        cmd.Parameters.AddWithValue("@ApplicationDeadline", applicationDeadline);
                        cmd.Parameters.AddWithValue("@Status", status);

                        cmd.ExecuteNonQuery(); // Execute the query to insert data
                    }
                }

                // Show success message
                MessageBox.Show("Job application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle error
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadJobData(int jobId)
        {
            string query = "SELECT * FROM JobApplications WHERE Id = @JobId"; // Query to select job by Id

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@JobId", jobId); // Pass jobId parameter for filtering

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Read the data if available
                            {
                                // Populate controls with the retrieved data
                                txtCompanyName.Text = reader["CompanyName"].ToString();
                                txtJobTitle.Text = reader["JobTitle"].ToString();
                                txtJobDescription.Text = reader["JobDescription"].ToString();
                                txtContactName.Text = reader["ContactPersonName"].ToString();
                                txtContactEmail.Text = reader["ContactPersonEmail"].ToString();
                                txtContactPhone.Text = reader["ContactPersonPhone"].ToString();
                                txtNotes.Text = reader["Notes"].ToString();
                                dtpApplicationDate.Value = Convert.ToDateTime(reader["ApplicationDate"]);
                                dtpApplicationDeadline.Value = Convert.ToDateTime(reader["ApplicationDeadline"]);
                                cmbStatus.SelectedItem = reader["Status"].ToString(); // Ensure status matches a combo box option
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }
    }
