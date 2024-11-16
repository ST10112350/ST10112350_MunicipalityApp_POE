using MunicipalityApp.Classes;
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
using MunicipalityApp.Trees;

namespace MunicipalityApp.Forms
{
    public partial class ServiceRequestStatusForm : Form
    {
        private FormController formController; // initalize form controller

        private ServiceRequestManager serviceRequestManager;
        public ServiceRequestStatusForm(ServiceRequestManager manager)
        {
            InitializeComponent();
            serviceRequestManager = manager; // Initialize IssueManager
            LoadServiceRequests();
            formController = new FormController();
        }
        private void LoadServiceRequests()
        {
            var serviceRequests = serviceRequestManager.GetAllServiceRequests();
            serviceRequests_Results.Items.Clear();
            foreach (var request in serviceRequests)
            {
                serviceRequests_Results.Items.Add(request.ServiceType);         //Display service types in list
            }

        }
        private void serviceRequests_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedServiceType = serviceRequests_Results.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedServiceType))
            {
                var serviceRequests = serviceRequestManager.GetAllServiceRequests();
                foreach (var request in serviceRequests)
                {
                    if (request.ServiceType == selectedServiceType)
                    {
                        DisplayServiceRequestDetails(request);
                        break;
                    }
                }
            }
        }

        private void DisplayServiceRequestDetails(ServiceRequest request)
        {

            // Create a new form to display service request details
            Form detailsForm = new Form
            {
                Size = new Size(400, 300),
                Text = "Service Request Details"
            };

            // Create labels for service request details
            Label idLabel = new Label { Text = $"ID: {request.Id}", Location = new Point(10, 10), AutoSize = true };
            Label statusLabel = new Label { Text = $"Status: {request.Status}", Location = new Point(10, 40), AutoSize = true };
            Label userLabel = new Label { Text = $"User: {request.UserName}", Location = new Point(10, 70), AutoSize = true };
            Label contactLabel = new Label { Text = $"Contact: {request.UserContact}", Location = new Point(10, 100), AutoSize = true };
            Label phoneLabel = new Label { Text = $"Phone Number: {request.PhoneNumber}", Location = new Point(10, 130), AutoSize = true };
            Label serviceTypeLabel = new Label { Text = $"Service Type: {request.ServiceType}", Location = new Point(10, 160), AutoSize = true };

            // Add controls to the form
            detailsForm.Controls.Add(idLabel);
            detailsForm.Controls.Add(statusLabel);
            detailsForm.Controls.Add(userLabel);
            detailsForm.Controls.Add(contactLabel);
            detailsForm.Controls.Add(phoneLabel);
            detailsForm.Controls.Add(serviceTypeLabel);

            // Show the custom details form as a modal dialog
            detailsForm.ShowDialog();
        }

        private void request_btn_Click(object sender, EventArgs e)
        {
            formController.showRequestForm();


        }
    }
}
