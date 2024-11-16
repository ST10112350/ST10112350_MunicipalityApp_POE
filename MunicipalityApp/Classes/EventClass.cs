using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{
    public class EventClass
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string Category { get; set; }
        public string ImagePath { get; set; }
        public string TicketLink { get; set; }

        public EventClass(string title, DateTime date, string venue, string category, string imagePath, string ticketLink)
        {
            Title = title;
            Date = date;
            Venue = venue;
            Category = category;
            ImagePath = imagePath;
            TicketLink = ticketLink;
        }
    }

}
