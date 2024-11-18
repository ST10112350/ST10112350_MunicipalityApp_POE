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
    { // Manages the collection of service requests using a BST and MaxHeap

        private BinarySearchTree<ServiceRequest> serviceRequests;
        private MaxHeap priorityQueue;

        public ServiceRequestManager()
        {
            serviceRequests = new BinarySearchTree<ServiceRequest>();
            priorityQueue = new MaxHeap();
            LoadRequests();
        }

        /// <summary>
        /// Adds a new service request to the collection
        /// </summary>
        /// <param name="request"></param>
        public void AddServiceRequest(ServiceRequest request)
        {
            // Add to priority queue if it's a priority service request
            if (request.Priority > 0) 
            { 
                priorityQueue.Insert(request); 
            }
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
        /// Retrieves the next highest priority service request
        /// </summary>
        /// <returns></returns>
        public ServiceRequest GetNextPriorityRequest()
        {
            return priorityQueue.ExtractMax();
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

                    // Add to priority queue if it's a priority service request
                    if (request.Priority > 0)
                    {
                        priorityQueue.Insert(request);
                    }
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

