using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{
    public class IssueClass
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachedFile { get; set; }
        public bool RequestService { get; set; }
        public string ServiceType { get; set; }

        public IssueClass(string location, string category, string description, string attachedFile, bool requestService = false, string serviceType = "")
        {
            Location = location;
            Category = category;
            Description = description;
            AttachedFile = attachedFile;
            RequestService = requestService;
            ServiceType = serviceType;

        }
    }
}
//----------------------------------------------------------END------------------------------------------------------------------//