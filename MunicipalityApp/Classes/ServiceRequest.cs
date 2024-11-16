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
        public string UserName { get; set; }
        public string UserContact { get; set; }
        public string PhoneNumber { get; set; }
        public string ServiceType { get; set; }

        public ServiceRequest(int id, string status, string userName, string userContact, string phoneNumber, string serviceType)
        {
            Id = id;
            Status = status;
            UserName = userName;
            UserContact = userContact;
            PhoneNumber = phoneNumber;
            ServiceType = serviceType;
        }

        public int CompareTo(ServiceRequest other)
        { 
            // Compare by ID
            if (other == null) return 1;
            return this.Id.CompareTo(other.Id); 
        }
        }
}
