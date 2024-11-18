using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{
    public class AnnouncementClass
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public AnnouncementClass(string message, DateTime date)
        {
            Message = message;
            Date = date;
        }
    }
}
//------------------------------------------------------------------------------------------------------[END]----------------------------------------------------------------------------------------------------------//