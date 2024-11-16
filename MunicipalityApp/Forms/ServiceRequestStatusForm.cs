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

        private ServiceRequestManager serviceRequestManager;
        public ServiceRequestStatusForm(ServiceRequestManager manager)
        {
            InitializeComponent();
            serviceRequestManager = manager; // Initialize IssueManager
            LoadServiceRequests();
        }
        private void LoadServiceRequests()
        {
           var serviceRequests = serviceRequestManager.GetAllServiceRequests();
           serviceRequests_Results.Items.Clear();
           foreach (var request in serviceRequests)
            {
                serviceRequests_Results.Items.Add(request);
            }
         
        }
        private void serviceRequests_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRequest = serviceRequests_Results.SelectedItem as ServiceRequest;
            if (selectedRequest != null)
            {
                DisplayServiceRequestDetails(selectedRequest);
            }
        }

        private void DisplayServiceRequestDetails(ServiceRequest request)
        {
            // Display the details of the selected service request
            serviceRequests_Results.Text = $"ID: {request.Id}\n" +
                                      $"Status: {request.Status}\n" +
                                      $"User: {request.UserName}\n" +
                                      $"Contact: {request.UserContact}\n" +
                                      $"Phone Number: {request.PhoneNumber}";

        }
    }
}
