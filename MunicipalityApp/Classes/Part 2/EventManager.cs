using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{
    public class EventManager
    {
        public Dictionary<string, EventClass> Events { get; private set; }

        public EventManager()
        {
            Events = new Dictionary<string, EventClass>();
            LoadData();
        }

        private void LoadData()
        {
            // Load events data
            Events = new Dictionary<string, EventClass>
        {
            {
                "Cape Town International Jazz Festival",
                new EventClass("Cape Town International Jazz Festival",
                               new DateTime(2024, 5, 3),
                               "Cape Town International Convention Centre",
                               "Music",
                               "jazzfest_poster.jpg",
                               "http://tickets.com/jazzfest")
            },
            {
                "Cape Town Carnival",
                new EventClass("Cape Town Carnival",
                               new DateTime(2025, 3, 15),
                               "The Fanwalk Greenpoint",
                               "Festival",
                               "BackgroundImages/carnival_poster.jpg",
                               "http://tickets.com/carnival")
            },
            {
                "Cape Town Cycle Tour",
                new EventClass("Cape Town Cycle Tour",
                               new DateTime(2025, 3, 9),
                               "Various Locations",
                               "Sports",
                               "BackgroundImages/cycle_poster.jpg",
                               "http://tickets.com/cycletour")
            },
            {
                "Mining Indaba",
                new EventClass("Mining Indaba",
                               new DateTime(2025, 2, 3),
                               "Cape Town International Convention Centre",
                               "Conference",
                               "BackgroundImages/mi_poster.jpg",
                               "http://tickets.com/miningindaba")
            },
            {
                "DSTV Mitchell's Plain Festival",
                new EventClass("DSTV Mitchell's Plain Festival",
                               new DateTime(2024, 12, 29),
                               "Various Locations",
                               "Festival",
                               "BackgroundImages/dstv_poster.jpg",
                               "http://tickets.com/mitchellsplain")
            }
        };
        }
    }

}
