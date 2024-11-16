using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{
    // Manages the collection of service requests using a BST
    public class ServiceRequestManager
    {
    private BinarySearchTree<ServiceRequest> serviceRequests;

        public ServiceRequestManager()
        {
            serviceRequests = new BinarySearchTree<ServiceRequest>();
        }

        // Add a new service request
        public void AddServiceRequest(ServiceRequest request)
        {
            serviceRequests.Insert(request);
        }

        // Get a service request by ID
        public ServiceRequest GetServiceRequest(int id)
        {
            return serviceRequests.Find(id);
        }

        // Get all service requests (in-order traversal)
        public IEnumerable<ServiceRequest> GetAllServiceRequests()
        {
            return serviceRequests.InOrderTraversal();
        }
    }
}
