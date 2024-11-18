using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{
    internal class AnnouncementManager
    {
        public Dictionary<string, AnnouncementClass> Announcements { get; private set; }

        public AnnouncementManager()
        {
            Announcements = new Dictionary<string, AnnouncementClass>();
            LoadData();
        }

        private void LoadData()
        {
            // Load announcements data
            Announcements = new Dictionary<string, AnnouncementClass>
            {
                { "Loadshedding has been postponed", new AnnouncementClass("Loadshedding has been postponed", DateTime.Now) },
                { "Potholes in Dunbar Road to be fixed November 5th 2024", new AnnouncementClass("Potholes in Dunbar Road to be fixed November 5th 2024", new DateTime(2024, 11, 5)) },
                { "New mall opening 2025", new AnnouncementClass("New mall opening 2025", new DateTime(2025, 1, 1)) }
            };
        }
    }
}