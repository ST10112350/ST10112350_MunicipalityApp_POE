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
using MunicipalityApp.Forms;


namespace MunicipalityApp.Forms
{
    public partial class EventsAnnouncementsForm : Form
    {
        private EventManager eventManager;
        private AnnouncementManager announcementManager;
        private FormController formController;

        public EventsAnnouncementsForm()
        {
            InitializeComponent();
            eventManager = new EventManager();
            announcementManager = new AnnouncementManager();
            PopulateEventComboBox();
            LoadCategories();
            formController = new FormController();
            LoadAnnouncements(); // Load announcements on form initialization
           // Adds menu strip from base form
            BaseForm menuStripControl = new BaseForm();
            menuStripControl.Dock = DockStyle.Top;
            //this.Controls.Add(menuStripControl);
            this.DoubleBuffered = true;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Populate the event_box with event titles
        /// </summary>
        private void PopulateEventComboBox()
        {
            event_box.Items.Clear();
            foreach (var eventEntry in eventManager.Events.Keys)
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
                if (eventManager.Events.TryGetValue(selectedTitle, out EventClass selectedEvent))
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

            var filteredEvents = eventManager.Events.Values.Where(e =>
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
            var categories = eventManager.Events.Values.Select(e => e.Category).Distinct().ToList(); // Get distinct categories
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
            foreach (var announcement in announcementManager.Announcements.Values)
            {
                announcementsListBox.Items.Add(announcement.Message);
            }
        }

        private void announcementsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (announcementsListBox.SelectedItem != null)
            {
                string selectedAnnouncement = announcementsListBox.SelectedItem.ToString();
                if (announcementManager.Announcements.TryGetValue(selectedAnnouncement, out AnnouncementClass selectedAnnounce))
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
            var filteredEvents = eventManager.Events.Values
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
