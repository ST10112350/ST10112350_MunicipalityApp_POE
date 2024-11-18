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
            private FormController formController;
            private ServiceRequestManager serviceRequestManager;
            private Dictionary<string, ServiceRequest> displayedServiceRequests;

        public ServiceRequestStatusForm(ServiceRequestManager manager)
            {
                InitializeComponent();
                serviceRequestManager = manager;
                formController = new FormController();
                PopulateServiceTypeDropdown();
                displayedServiceRequests = new Dictionary<string, ServiceRequest>();
        }

            /// <summary>
            /// Event handler for when a service type is selected from the dropdown.
            /// </summary>
            private void viewRequests_dropdown_SelectedIndexChanged(object sender, EventArgs e)
            {
                LoadServiceRequestsByType(viewRequests_dropdown.SelectedItem.ToString());
            }

        /// <summary>
        /// Populates the dropdown with predefined service types and loads unique service types from existing requests.
        /// </summary>
        private void PopulateServiceTypeDropdown()
        {
            viewRequests_dropdown.Items.AddRange(new string[]
            {
                    "Pothole Repair", "Traffic Sign Issues", "Streetlight Repair", "Bulk Waste Collection", "Ste Disposal",
                    "Water Leak Reporting", "Sewage Issues", "Public Health Inspections", "Animal Control", "Park Maintenance",
                    "Facility Booking", "Playground Repairs", "Community Safety", "Littering Reporting", "Tree Maintenance"
            });

            var serviceRequests = serviceRequestManager.GetAllServiceRequests();
            foreach (var request in serviceRequests)
            {
                if (!viewRequests_dropdown.Items.Contains(request.ServiceType))
                {
                    viewRequests_dropdown.Items.Add(request.ServiceType);
                }

            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Loads service requests of the selected type into the list box.
        /// </summary>
        private void LoadServiceRequestsByType(string serviceType)
        {
            serviceRequests_Results.Items.Clear();
            var serviceRequests = serviceRequestManager.GetAllServiceRequests();
            foreach (var request in serviceRequests)
            {
                if (request.ServiceType == serviceType)
                {
                    serviceRequests_Results.Items.Add(request.ServiceType); // Display only the service type
                }
            }

        }

        /// <summary>
        /// Redirecting to the form to create a new Service Request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

            private void request_btn_Click(object sender, EventArgs e)
            {
                formController.showRequestForm();
            }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void serviceRequests_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle logic when a service request is selected from the list
            var selectedServiceType = serviceRequests_Results.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedServiceType) && displayedServiceRequests.ContainsKey(selectedServiceType))
            {
                var selectedRequest = displayedServiceRequests[selectedServiceType];
                DisplayServiceRequestDetails(selectedRequest); // Show details in a pop-up
            }
        }

        private void requestReview_btn_CheckedChanged(object sender, EventArgs e)
        { 
            // Ensure the view details action is selected.
            if (requestReview_btn.Checked)
            {
                deleteRequest_btn.Checked = false;
                var selectedServiceType = serviceRequests_Results.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedServiceType) && displayedServiceRequests.ContainsKey(selectedServiceType))
                {
                    var selectedRequest = displayedServiceRequests[selectedServiceType];
                    DisplayServiceRequestDetails(selectedRequest);
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Displays the details of a selected service request in a new form.
        /// </summary>
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
                Label serviceTypeLabel = new Label { Text = $"Service Type: {request.ServiceType}", Location = new Point(10, 70), AutoSize = true };
                Label userLabel = new Label { Text = $"User: {request.UserName}", Location = new Point(10, 100), AutoSize = true };
                Label emailLabel = new Label { Text = $"Email: {request.UserEmail}", Location = new Point(10, 130), AutoSize = true };
                Label phoneLabel = new Label { Text = $"Phone Number: {request.PhoneNumber}", Location = new Point(10, 160), AutoSize = true };

                // Add labels to the details form
                detailsForm.Controls.Add(idLabel);
                detailsForm.Controls.Add(statusLabel);
                detailsForm.Controls.Add(serviceTypeLabel);
                detailsForm.Controls.Add(userLabel);
                detailsForm.Controls.Add(emailLabel);
                detailsForm.Controls.Add(phoneLabel);

                // Show the details form as a modal dialog
                detailsForm.ShowDialog();
            }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void deleteRequest_btn_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure the delete action is selected.
            if (deleteRequest_btn.Checked)
            {
               requestReview_btn.Checked = false;
        var selectedServiceType = serviceRequests_Results.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedServiceType) && displayedServiceRequests.ContainsKey(selectedServiceType))
                {
                    var selectedRequest = displayedServiceRequests[selectedServiceType];
                    serviceRequestManager.RemoveServiceRequest(selectedRequest.Id); // Remove the selected request
                    LoadAllServiceRequests(); // Refresh the list box to show the changes
                    MessageBox.Show("Service request removed successfully!");
                }
            }
        
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Loads all service requests into the list box.
        /// </summary>
        private void LoadAllServiceRequests()
        {
            serviceRequests_Results.Items.Clear();
            var serviceRequests = serviceRequestManager.GetAllServiceRequests();
            foreach (var request in serviceRequests)
            {
                serviceRequests_Results.Items.Add(request.ServiceType); // Display only the service type
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Button to view all service requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewAll_btn_Click(object sender, EventArgs e)
        {
            LoadAllServiceRequests();
        }
    }
}
//////////////////////////////////////////////////////////////////////////////////////[END]/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


