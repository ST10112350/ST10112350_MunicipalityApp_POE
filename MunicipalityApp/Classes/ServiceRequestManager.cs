using MunicipalityApp.Classes;
using MunicipalityApp.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MunicipalityApp.Trees;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MunicipalityApp.Classes
{

    public class ServiceRequestManager
    { // Manages the collection of service requests using a BST

        private BinarySearchTree<ServiceRequest> serviceRequests;

        public ServiceRequestManager()
        {
            serviceRequests = new BinarySearchTree<ServiceRequest>();
            LoadRequests();
        }

        /// <summary>
        /// Adds a new service request to the collection
        /// </summary>
        /// <param name="request"></param>
        public void AddServiceRequest(ServiceRequest request)
        {
            request.Id = GenerateRequestId();
            serviceRequests.Insert(request);
            SaveRequests();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Retrieves a service request by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ServiceRequest GetServiceRequest(int id)
        {
            return serviceRequests.Find(id);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Retrieves all service requests
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ServiceRequest> GetAllServiceRequests()
        {
            return serviceRequests.InOrderTraversal();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Saves the service requests to a file
        /// </summary>
        private void SaveRequests()
        {
            var requests = new List<ServiceRequest>(serviceRequests.InOrderTraversal());
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(requests, options);
            File.WriteAllText("serviceRequests.json", json);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Loads the service requests from a file
        /// </summary>
        private void LoadRequests()
        {
            if (File.Exists("serviceRequests.json"))
            {
                var json = File.ReadAllText("serviceRequests.json");
                var requests = JsonSerializer.Deserialize<ServiceRequest[]>(json);
                foreach (var request in requests)
                {
                    serviceRequests.Insert(request);
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Removes a service request by ID
        /// </summary>
      public void RemoveServiceRequest(ServiceRequest requestToRemove)
      {
            if (requestToRemove != null)
            {
                serviceRequests.Delete(requestToRemove);
                SaveRequests(); // Update the saved file after deletion

                // Debug message to confirm removal
                Console.WriteLine($"Removed request: {requestToRemove.ServiceType}");
            }
       }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Generates a new request ID
        /// </summary>
        /// <returns></returns>
        private int GenerateRequestId()
        {
            // Implement logic to generate a new request ID
            var allRequests = GetAllServiceRequests();
            int maxId = 0;
            foreach (var request in allRequests)
            {
                if (request.Id > maxId)
                {
                    maxId = request.Id;
                }
            }
            return maxId + 1;
        }
    }

    }
//------------------------------------------------------------------------------------------------------[END]----------------------------------------------------------------------------------------------------------//

