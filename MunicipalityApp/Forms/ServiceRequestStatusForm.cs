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
using MunicipalityApp.Forms;


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

            // Adds menu strip from base form
            BaseForm menuStripControl = new BaseForm();
            //menuStripControl.Dock = DockStyle.None;
            this.Controls.Add(menuStripControl);
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
                    "Pothole Repair", "Traffic Sign Issues", "Power Outage", "Streetlight Repair", "Bulk Waste Collection", "Hazardous Waste Disposal",
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

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Loads service requests of the selected type into the list box.
        /// </summary>
        private void LoadServiceRequestsByType(string serviceType)
        {
            serviceRequests_Results.Items.Clear();
            displayedServiceRequests.Clear();
            var serviceRequests = serviceRequestManager.GetAllServiceRequests();
            foreach (var request in serviceRequests)
            {
                if (request.ServiceType == serviceType)
                {
                    serviceRequests_Results.Items.Add(request.ServiceType); // Display only the service type
                    displayedServiceRequests[request.ServiceType] = request;
                }
            }

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Button to view all service requests
        /// </summary>
        private void viewAll_btn_Click(object sender, EventArgs e)
        {
            LoadAllServiceRequests();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        
        /// <summary>
        /// Loads all service requests into the list box.
        /// </summary>
        private void LoadAllServiceRequests()
        {
            serviceRequests_Results.Items.Clear();
            displayedServiceRequests.Clear(); // Clear previous entries

            var serviceRequests = serviceRequestManager.GetAllServiceRequests();
            foreach (var request in serviceRequests)
            {
                serviceRequests_Results.Items.Add(request.ServiceType);
                displayedServiceRequests[request.ServiceType] = request;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Redirecting to the form to create a new Service Request
        /// </summary>
        private void request_btn_Click(object sender, EventArgs e)
        {
            formController.ShowRequestForm();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//


        private void serviceRequests_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle logic when a service request is selected from the list
           var selectedServiceType = serviceRequests_Results.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedServiceType) && displayedServiceRequests.ContainsKey(selectedServiceType))
            {
                var selectedRequest = displayedServiceRequests[selectedServiceType];
                if (selectedRequest != null)
                {
                    DisplayServiceRequestDetails(selectedRequest);
                }
            }
        }

        private void requestReview_btn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (requestReview_btn.Checked)
            {
                var selectedServiceType = serviceRequests_Results.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedServiceType) && displayedServiceRequests.ContainsKey(selectedServiceType))
                {
                    var selectedRequest = displayedServiceRequests[selectedServiceType];
                    if (selectedRequest != null)
                    {
                        DisplayServiceRequestDetails(selectedRequest);
                    }
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Displays the details of a selected service request in a new form.
        /// </summary>
        private void DisplayServiceRequestDetails(ServiceRequest request)
        {
            // Display the details in a MessageBox
            MessageBox.Show(
                $"ID: {request.Id}\n" +
                $"Status: {request.Status}\n" +
                $"Service Type: {request.ServiceType}\n" +
                $"User: {request.UserName}\n" +
                $"Email: {request.UserEmail}\n" +
                $"Phone: {request.PhoneNumber}",
                "Service Request Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void deleteRequest_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteRequest_btn.Checked)
            {
                var selectedServiceType = serviceRequests_Results.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedServiceType) && displayedServiceRequests.ContainsKey(selectedServiceType))
                {
                    var selectedRequest = displayedServiceRequests[selectedServiceType];
                    if (selectedRequest != null)
                    {
                        serviceRequestManager.RemoveServiceRequest(selectedRequest);
                        displayedServiceRequests.Remove(selectedServiceType); // Also remove from displayed requests
                        LoadAllServiceRequests(); // Refresh the list box to show the changes
                        MessageBox.Show("Service request removed successfully!");

                        // Debug message to check if deletion is called
                        Console.WriteLine($"Deleted request: {selectedRequest.ServiceType}");
                    }
                }
            }

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

       

    }
}
//------------------------------------------------------------------------------------------------------[END]----------------------------------------------------------------------------------------------------------//


