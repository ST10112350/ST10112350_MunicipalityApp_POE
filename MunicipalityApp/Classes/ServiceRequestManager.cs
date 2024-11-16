using MunicipalityApp.Classes;
using MunicipalityApp.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MunicipalityApp.Trees;

namespace MunicipalityApp.Classes
{

    public class ServiceRequestManager
    { // Manages the collection of service requests using a BST

        private BinarySearchTree<ServiceRequest> serviceRequests;

        public ServiceRequestManager()
        {
            serviceRequests = new BinarySearchTree<ServiceRequest>();
        }

        public void AddServiceRequest(ServiceRequest request)
        {
            serviceRequests.Insert(request);
        }

        public ServiceRequest GetServiceRequest(int id)
        {
            return serviceRequests.Find(id);
        }

        public IEnumerable<ServiceRequest> GetAllServiceRequests()
        {
            return serviceRequests.InOrderTraversal();
        }
    }
}
   
