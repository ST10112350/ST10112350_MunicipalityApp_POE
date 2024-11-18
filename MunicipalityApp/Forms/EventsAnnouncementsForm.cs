using MunicipalityApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MunicipalityApp.Classes;
using System.IO;


namespace MunicipalityApp.Forms
{
    public partial class EventsAnnouncementsForm : Form
    {
        private Dictionary<string, EventClass> events;
        private Dictionary<string, AnnouncementClass> announcements;
        private SortedDictionary<DateTime, List<EventClass>> sortedEvents;
        private FormController formController;

        public EventsAnnouncementsForm()
        {
            InitializeComponent();
            LoadData();
            PopulateEventComboBox();
            LoadCategories();
            formController = new FormController();
            LoadAnnouncements(); // Load announcements on form initialization
        }

        /// <summary>
        /// Load events and announcements data
        /// </summary>
        private void LoadData()
        {
            // Load events data
            events = new Dictionary<string, EventClass>
            {
                {
                    "Cape Town International Jazz Festival",
                    new EventClass("Cape Town International Jazz Festival",
                                   new DateTime(2024, 5, 3),
                                   "Cape Town International Convention Centre",
                                   "Music",
                                   "BackgroundImages/jazzfest_poster.jpg",
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

           
            /// Load announcements data
            announcements = new Dictionary<string, AnnouncementClass>
            {
                { "Loadshedding has been postponed", new AnnouncementClass("Loadshedding has been postponed", DateTime.Now) },
                { "Potholes in Dunbar Road to be fixed November 5th 2024", new AnnouncementClass("Potholes in Dunbar Road to be fixed November 5th 2024", new DateTime(2024, 11, 5)) },
                { "New mall opening 2025", new AnnouncementClass("New mall opening 2025", new DateTime(2025, 1, 1)) }
            };

            // Organize events in a sorted dictionary by date
            sortedEvents = new SortedDictionary<DateTime, List<EventClass>>();
            foreach (var eventEntry in events.Values)
            {
                if (!sortedEvents.ContainsKey(eventEntry.Date))
                {
                    sortedEvents[eventEntry.Date] = new List<EventClass>();
                }
                sortedEvents[eventEntry.Date].Add(eventEntry);
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Populate the event_box with event titles
        /// </summary>
        private void PopulateEventComboBox()
        {
            event_box.Items.Clear();
            foreach (var eventEntry in events.Keys)
            {
                event_box.Items.Add(eventEntry);
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Event handler for the event_box SelectedIndexChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void event_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (event_box.SelectedItem != null)
            {
                string selectedTitle = event_box.SelectedItem.ToString();
                if (events.TryGetValue(selectedTitle, out EventClass selectedEvent))
                {
                    // Create a new panel to display event details
                    Form detailsForm = new Form
                    {
                        Size = new Size(400, 400),
                        Text = "Event Details"
                    };

                    // Create labels for event details
                    Label titleLabel = new Label { Text = $"Title: {selectedEvent.Title}", Location = new Point(10, 10), AutoSize = true };
                    Label dateLabel = new Label { Text = $"Date: {selectedEvent.Date.ToShortDateString()}", Location = new Point(10, 40), AutoSize = true };
                    Label venueLabel = new Label { Text = $"Venue: {selectedEvent.Venue}", Location = new Point(10, 70), AutoSize = true };
                    Label categoryLabel = new Label { Text = $"Category: {selectedEvent.Category}", Location = new Point(10, 100), AutoSize = true };
                    Label ticketLinkLabel = new Label { Text = $"Tickets: {selectedEvent.TicketLink}", Location = new Point(10, 130), AutoSize = true };

                    // Load the event image
                    PictureBox eventPictureBox = new PictureBox
                    {
                        ImageLocation = selectedEvent.ImagePath, // Ensure you are using the correct path
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(10, 160),
                        Size = new Size(360, 200)
                    };

                    // Add controls to the panel
                    detailsForm.Controls.Add(titleLabel);
                    detailsForm.Controls.Add(dateLabel);
                    detailsForm.Controls.Add(venueLabel);
                    detailsForm.Controls.Add(categoryLabel);
                    detailsForm.Controls.Add(ticketLinkLabel);
                    detailsForm.Controls.Add(eventPictureBox);

                    // Show the custom details form
                    detailsForm.ShowDialog(); // Show it as a modal dialog
                }
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Event handler for the datePicker ValueChanged event
        /// </summary>
        private void SearchEvents()
        {
            string categoryFilter = categoryComboBox.SelectedItem?.ToString();
            DateTime? dateFilter = datePicker.Value.Date;

            var filteredEvents = events.Values.Where(e =>
                (string.IsNullOrEmpty(categoryFilter) || e.Category == categoryFilter) &&
                (!dateFilter.HasValue || e.Date.Date == dateFilter.Value)).ToList();

            // Update the event_box with filtered events
            event_box.Items.Clear();
            foreach (var ev in filteredEvents)
            {
                event_box.Items.Add(ev.Title);
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Load categories into the categoryComboBox
        /// </summary>
        private void LoadCategories()
        {
            var categories = events.Values.Select(e => e.Category).Distinct().ToList(); // Get distinct categories
            categoryComboBox.DataSource = categories; // Bind to ComboBox
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Load announcements into the announcementsListBox
        /// </summary>
        private void LoadAnnouncements()
        {
            // Clear existing items before loading
            announcementsListBox.Items.Clear();

            // Load announcements into announcementsListBox
            foreach (var announcement in announcements.Values)
            {
                announcementsListBox.Items.Add(announcement.Message);
            }
        }

        private void announcementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (announcementsListBox.SelectedItem != null)
            {
                string selectedAnnouncement = announcementsListBox.SelectedItem.ToString();
                if (announcements.TryGetValue(selectedAnnouncement, out AnnouncementClass selectedAnnounce))
                {
                    // Display announcement details
                    string message = $"Announcement: {selectedAnnounce.Message}\nDate: {selectedAnnounce.Date.ToShortDateString()}";
                    MessageBox.Show(message, "Announcement Details");
                }
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formController.ShowEventsForm();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Event handler for the search_txtbx TextChanged event
        /// </summary>

        private void search_txtbx_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_txtbx.Text.ToLower();
            var filteredEvents = events.Values
                .Where(ev => ev.Title.ToLower().Contains(searchTerm) ||
                             ev.Category.ToLower().Contains(searchTerm))
                .ToList();

            // Update the event_box to display filtered results
            event_box.Items.Clear();
            foreach (var evt in filteredEvents)
            {
                event_box.Items.Add(evt.Title);
            }
        }

        // Button click event to initiate search
        private void search_btn_Click(object sender, EventArgs e)
        {
            SearchEvents(); // Call the SearchEvents method to filter based on selected criteria
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void EventsAnnouncementsForm_Load(object sender, EventArgs e)
        {

        }

    }
}
//----------------------------------------------------------------------------------------------[END]-------------------------------------------------------------------------------------------------------------------------------//
