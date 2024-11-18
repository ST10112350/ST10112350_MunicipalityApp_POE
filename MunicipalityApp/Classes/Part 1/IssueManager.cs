using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{
    public class IssueManager
    {
        private List<IssueClass> issues = new List<IssueClass>();

        public void AddIssue(IssueClass issue)
        {
            issues.Add(issue);
            // Adds issue to the list
        }

        public List<IssueClass> GetIssues()
        {
            return issues;
        }
    }
}
//----------------------------------------------------------END------------------------------------------------------------------------------------------//