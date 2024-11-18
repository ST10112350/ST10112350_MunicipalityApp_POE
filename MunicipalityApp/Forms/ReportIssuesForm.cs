using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MunicipalityApp.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MunicipalityApp
{
    public partial class ReportIssuesForm : Form
    {
        private string Name = string.Empty;
        private string Email = string.Empty;
        private string Phone = string.Empty;
        private string dateTime = DateTime.Now.ToString();
        private string attachedFilePath = string.Empty;
        private string location = string.Empty;
        private string category = string.Empty;
        private string description = string.Empty;
        private IssueManager issueManager;
        private FormController formController;

        private List<IssueClass> issueList = new List<IssueClass>();
        public ReportIssuesForm(IssueManager manager)
        {
            InitializeComponent();
            issueManager = manager; // Initialize IssueManager
            PopulateCategoryComboBox();
            progressBar1.Maximum = 100;
            LoadAllIssues(); // Load issues when form loads
            formController = new FormController();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            // Initialize progress bar and other form settings
            UpdateProgressBar();
        }
        /// <summary>
        /// Update the progress bar based on the user input
        /// </summary>

        private void UpdateProgressBar()
        {
            int progress = 0;
            if (!string.IsNullOrWhiteSpace(Name)) progress += 12;
            if (!string.IsNullOrWhiteSpace(Email)) progress += 12;
            if (!string.IsNullOrWhiteSpace(Phone)) progress += 12;
            if (!string.IsNullOrEmpty(dateTime)) progress += 12;
            if (!string.IsNullOrWhiteSpace(location)) progress += 12;
            if (!string.IsNullOrWhiteSpace(category)) progress += 15;
            if (!string.IsNullOrWhiteSpace(description)) progress += 15;
            if (!string.IsNullOrEmpty(attachedFilePath)) progress += 10;
            

            progressBar1.Value = progress;
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// User input for the report
        /// </summary>

        private void reportName_txtbx_TextChanged(object sender, EventArgs e)
        {
            Name = reportName_txtbx.Text;
            UpdateProgressBar();
        }

        private void reportEmail_txtbx_TextChanged(object sender, EventArgs e)
        {
            Email = reportEmail_txtbx.Text;
            UpdateProgressBar();
        }

        private void reportNumber_txtbx_TextChanged(object sender, EventArgs e)
        {
            Phone = reportNumber_txtbx.Text;
            UpdateProgressBar();
        }
        private void issue_date_ValueChanged_1(object sender, EventArgs e)
        {
            dateTime = issue_date.Value.ToString();
            UpdateProgressBar();
        }

        private void location_txtbx_TextChanged(object sender, EventArgs e)
        {
            location = location_txtbx.Text;
            UpdateProgressBar();
        }
        /// <summary>
        /// Populate the category dropdown
        /// </summary>
        private void PopulateCategoryComboBox()
        {
            category_comboBox.Items.AddRange(new string[]
            {
                "Sanitation ", " Roads ", "Utilities "
            });
        }

        private void category_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = category_comboBox.SelectedItem?.ToString();
        }

        private void discription_txtbx_TextChanged(object sender, EventArgs e)
        {
            description = discription_txtbx.Text;
            UpdateProgressBar();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//  

        /// <summary>
        /// attaching a file 
        /// </summary>
        private void attach_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the dialog properties
                openFileDialog.InitialDirectory = @"C:\"; // Set the initial directory
                openFileDialog.Filter = "All Files (*.*)|*.*"; // Allow all file types
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true; // Restores the last selected directory


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    attachedFilePath = openFileDialog.FileName;
                    UpdateFilePreview();
                }
            }
        }

        private void UpdateFilePreview()
        {
            attachedFiles_listBox.Items.Clear();
            attachedFiles_listBox.Items.Add(attachedFilePath);
            UpdateProgressBar();
        }



        public string GetAttachedFilePath()
        {
            return attachedFilePath;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Submit the issue
        /// </summary>

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                // Create a new IssueClass instance with collected data
                IssueClass newIssue = new IssueClass(Name, Email, Phone, dateTime, location, category, description, GetAttachedFilePath());

                // Add the issue
                issueManager.AddIssue(newIssue);

                // Success message and reset the form
                MessageBox.Show("Issue reported successfully!");

                // Reset the form fields
                ResetForm();
                UpdateProgressBar();
                LoadAllIssues(); // Reload issues to include the newly added one }
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Validation for textboxes and dropdown
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool isValid = true;
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(Name))
            {
                errorMessage += "Name is required.\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Email) || !System.Text.RegularExpressions.Regex.IsMatch(Email, emailPattern))
            {
                errorMessage += "A valid email is required.\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Phone) || Phone.Length != 10)
            {
                errorMessage += "Phone number must be 10 digits.\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void LoadAllIssues()
        {
            issueList = issueManager.GetIssues(); // Get all issues from IssueManager
            issues_listbox.Items.Clear();

            foreach (var issue in issueList)
            {
                issues_listbox.Items.Add(issue.Location); // Display location in the list box
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Display the issue details when selected
        /// </summary>

        private void issues_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLocation = issues_listbox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedLocation))
            {
                var selectedIssue = issueList.Find(issue => issue.Location == selectedLocation);
                if (selectedIssue != null)
                {
                    DisplayIssueDetails(selectedIssue);
                }
            }
        }
        /// <summary>
        /// Display the issue details
        /// </summary>
        /// <param name="issue"></param>
        private void DisplayIssueDetails(IssueClass issue)
        {
            // Display the details in a MessageBox
            MessageBox.Show(
                $"Name: {issue.Name}\n" +
                $"Email: {issue.Email}\n" +
                $"Phone: {issue.Phone}\n" +
                $"DateTime: {issue.DateTime}\n" +
                $"Location: {issue.Location}\n" +
                $"Category: {issue.Category}\n" +
                $"Description: {issue.Description}\n" +
                $"Attached File: {issue.AttachedFile}",
                "Issue Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void ResetForm()
        {
            reportName_txtbx.Text = "";
            reportEmail_txtbx.Text = "";
            reportNumber_txtbx.Text = "";
            location_txtbx.Text = "";
            discription_txtbx.Text = "";
            attachedFiles_listBox.Items.Clear();
            issue_date.Value = DateTime.Now;
            category_comboBox.SelectedIndex = -1;
            attachedFilePath = "";
            UpdateProgressBar();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Delete the selected issue
        /// </summary>
        private void issueDelete_button_CheckedChanged(object sender, EventArgs e)
        {
            if (issueDelete_button.Checked)
            {
                var selectedLocation = issues_listbox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedLocation))
                {
                    var selectedIssue = issueList.Find(issue => issue.Location == selectedLocation);
                    if (selectedIssue != null)
                    {
                        issueManager.GetIssues().Remove(selectedIssue); // Remove issue from IssueManager
                        LoadAllIssues(); // Reload issues to reflect the deletion
                        MessageBox.Show("Issue deleted successfully!");

                        // Debug message to confirm deletion
                        Console.WriteLine($"Deleted issue: {selectedIssue.Location}");
                    }
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Menu strip options
        /// </summary>
        private void menu_news_menu_Click(object sender, EventArgs e)
        {
            FormController.showMenuForm();
        }
    }
}

//--------------------------------------------------------------------------------------------------------[END]------------------------------------------------------------------------------------------------------------//