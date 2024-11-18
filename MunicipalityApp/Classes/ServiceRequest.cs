using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{
    public class ServiceRequest : IComparable<ServiceRequest>
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string ServiceType { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string PhoneNumber { get; set; }

        public int Priority { get; set; }

        public ServiceRequest(int id, string status, string serviceType, string userName, string userEmail, string phoneNumber, int priority)
        {
            Id = id;
            Status = status;
            ServiceType = serviceType;
            UserName = userName;
            UserEmail = userEmail;
            PhoneNumber = phoneNumber;
            Priority = priority;
        }

        public int CompareTo(ServiceRequest other)
        {
            if (other == null) return 1;
            return this.Priority.CompareTo(other.Priority); // Compare by priority
        }

        /// <summary>
        /// Override the ToString method to display more than 1 service request details
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ID: {Id}, ServiceType: {ServiceType}, Status: {Status}, User: {UserName}, Email: {UserEmail}, Phone: {PhoneNumber}, Priority: {Priority}";
        }
    }
}
//------------------------------------------------------------------------------------------------------[END]----------------------------------------------------------------------------------------------------------//