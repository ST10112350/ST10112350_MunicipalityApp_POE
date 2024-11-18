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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MunicipalityApp.Forms;

namespace MunicipalityApp.Forms
{
    public partial class RequestServiceForm : Form
    {
        private ServiceRequestManager serviceRequestManager;
        private string serviceType = string.Empty;
        private string userName = string.Empty;
        private string userEmail = string.Empty;
        private string phoneNumber = string.Empty;
        

        public RequestServiceForm(ServiceRequestManager manager)
        {
            InitializeComponent();
            serviceRequestManager = manager;
            PopulateServiceTypeDropdown();

            // Adds menu strip from base form
            BaseForm menuStripControl = new BaseForm();
            //menuStripControl.Dock = DockStyle.Top;
            this.Controls.Add(menuStripControl);
        }

        /// <summary>
        /// user input to request service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void requestName_txtbox_TextChanged(object sender, EventArgs e)
        {
            userName = requestName_txtbox.Text;
        }

        private void requestEmail_txtbox_TextChanged(object sender, EventArgs e)
        {
            userEmail = requestEmail_txtbox.Text;
        }

        private void requestNumber_txtbox_TextChanged(object sender, EventArgs e)
        {
            phoneNumber = requestNumber_txtbox.Text;
        }

        private void requestStype_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceType = requestStype_dropdown.SelectedItem?.ToString();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// Populate the service type dropdown with the available service types
        /// </summary>
        private void PopulateServiceTypeDropdown() 
        { 
            requestStype_dropdown.Items.AddRange(new string[] 
            { 
                "Pothole Repair", "Traffic Sign Issues", "Power Outage","Streetlight Repair", "Bulk Waste Collection", "Hazardous Waste Disposal", 
                "Water Leak Reporting", "Sewage Issues", "Public Health Inspections", "Animal Control", "Park Maintenance", 
                "Facility Booking", "Playground Repairs", "Community Safety", "Littering Reporting", "Tree Maintenance" 
            });
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Validation for textboxes and dropdown
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
                {
                    string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                    bool isValid = true;
                    string errorMessage = "";

                    if (string.IsNullOrWhiteSpace(requestName_txtbox.Text))
                    {
                        errorMessage += "Name is required.\n";
                        isValid = false;
                    }

                    if (string.IsNullOrWhiteSpace(requestEmail_txtbox.Text) || !Regex.IsMatch(requestEmail_txtbox.Text, emailPattern))
                    {
                        errorMessage += "A valid email is required.\n";
                        isValid = false;
                    }

                    if (string.IsNullOrWhiteSpace(requestNumber_txtbox.Text) || requestNumber_txtbox.Text.Length != 10)
                    {
                        errorMessage += "Phone number must be 10 digits.\n";
                        isValid = false;
                    }

                    if (requestStype_dropdown.SelectedIndex == -1)
                    {
                        errorMessage += "Please select a type of service.\n";
                        isValid = false;
                    }

                    if (!isValid)
                    {
                        MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return isValid;
                }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// Submit the service request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void requestSubmit_btn_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                // Define the priority for the service request
                int priority = CalculatePriority();
                // Create and add the service request
                serviceRequestManager.AddServiceRequest(new ServiceRequest(
                    -1, // Placeholder for ID, it will be set in ServiceRequestManager
                    "Pending",
                    serviceType,
                    userName,
                    userEmail,
                    phoneNumber,
                    priority
                ));

                // Success message
                MessageBox.Show("Service request submitted successfully!");

                // Reset form fields
                requestName_txtbox.Clear();
                requestEmail_txtbox.Clear();
                requestNumber_txtbox.Clear();
                requestStype_dropdown.SelectedIndex = -1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int CalculatePriority()
        { 
            return 1;  
        }
        }
}
////////////////////////////////////////////////////////////////[END]///////////////////////////////////////////////////////////////////////