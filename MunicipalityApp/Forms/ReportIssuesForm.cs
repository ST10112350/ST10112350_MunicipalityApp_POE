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

namespace MunicipalityApp
{
    public partial class ReportIssuesForm : Form
    {
        private string attachedFilePath = string.Empty; 
        private string location = string.Empty;
        private string category = string.Empty;
        private string description = string.Empty;
        //private bool requestService = false; 
        private string serviceType = string.Empty;
        private IssueManager issueManager;

        public ReportIssuesForm(IssueManager manager)
        {
            InitializeComponent();
            issueManager = manager; // Initialize IssueManager
            serviceType_dropdown.Visible = false; // Initially hide the dropdown
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void location_txtbx_TextChanged(object sender, EventArgs e)
        {
            location = location_txtbx.Text; 
        }

        private void category_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = category_listBox.SelectedItem?.ToString(); 
        }

        private void discription_txtbx_TextChanged(object sender, EventArgs e)
        {
            description = discription_txtbx.Text; 
        }
        private void requestService_btn_Click_1(object sender, EventArgs e)
        {
            serviceType_dropdown.Visible = true; // Show the dropdown when button is clicked
        }

        private void serviceType_dropdown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            serviceType = serviceType_dropdown.SelectedItem?.ToString();

            string serviceType = serviceType_dropdown.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(serviceType))
            {
                // Create and add the service request
                ServiceRequest newRequest = new ServiceRequest(-1, $"Request for {serviceType}", "Pending");
                issueManager.AddServiceRequest(newRequest);
            }
        }

  
        private void submit_btn_Click(object sender, EventArgs e)
        {
            // Create a new IssueClass instance with collected data
            IssueClass newIssue = new IssueClass(location, category, description, GetAttachedFilePath());

            // Add the issue 
            issueManager.AddIssue(newIssue);

            // success message and reset the form
            MessageBox.Show("Issue reported successfully!");

            // Optional: Reset the form fields
            ResetForm();
        }

        /// <summary>
        /// attaching a file 
        /// </summary>
        private void attach_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the dialog properties
                openFileDialog.InitialDirectory = @"C:\"; // Set the initial directory
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*"; // File filter
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true; // Restores the last selected directory

                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   
                    attachedFilePath = openFileDialog.FileName;
                   
                }
            }
        }

        public string GetAttachedFilePath()
        {
            return attachedFilePath;
        }

        private void ResetForm()
        {
            location_txtbx.Clear();
            category_listBox.ClearSelected();
            discription_txtbx.Clear();
            attachedFilePath = string.Empty;
            //lblSelectedFile.Text = string.Empty; // Assuming you have a label named lblSelectedFile
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Close the current form
            this.Close();

            // Create and show the Main Menu form
            MenuForm1 mainMenuForm = new MenuForm1();
            mainMenuForm.Show();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
//---------------------------------------------------------END-----------------------------------------------------------------//