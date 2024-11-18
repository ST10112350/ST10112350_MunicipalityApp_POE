using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{
    public class IssueClass
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DateTime { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachedFile { get; set; }

        public IssueClass(string name, string email, string phone, string dateTime, string location, string category, string description, string attachedFile)
        {
            Name = name;
            Email = email;
            Phone = phone;
            DateTime = dateTime;
            Location = location;
            Category = category;
            Description = description;
            AttachedFile = attachedFile;

        }
    }
}
//------------------------------------------------------------------------------------------------------[END]----------------------------------------------------------------------------------------------------------//