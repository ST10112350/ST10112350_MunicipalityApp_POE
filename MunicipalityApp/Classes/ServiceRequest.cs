using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{
    public class ServiceRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public ServiceRequest(int id, string description, string status)
        {
            Id = id;
            Description = description;
            Status = status;

        }
    }
}
