using MunicipalityApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalityApp.Classes
{
    public class FormController
    {
        private Form currentForm;

        private IssueManager issueManager = new IssueManager();
        private ServiceRequestManager serviceRequestManager = new ServiceRequestManager();
        private SortedDictionary<DateTime, List<AnnouncementClass>> announcements = new SortedDictionary<DateTime, List<AnnouncementClass>>();

        /// <summary>
        /// Show the Report Issues Form
        /// </summary>
        public void ShowReportIssuesForm()
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            ReportIssuesForm reportForm = new ReportIssuesForm(issueManager);
            currentForm = reportForm;
            currentForm.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Show the Events and Announcements Form
        /// </summary>
        public void ShowEventsForm()
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            EventsAnnouncementsForm eventsForm = new EventsAnnouncementsForm();
            currentForm = eventsForm;
            currentForm.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Show the Menu Form menu strip 
        /// </summary>
        public void ShowMenuForm()
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            MenuForm1 menuForm = new MenuForm1();
            currentForm = menuForm;
            currentForm.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Show the Service Request Status Form
        /// </summary>
        public void ShowStatusForm()
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            ServiceRequestStatusForm statusForm = new ServiceRequestStatusForm(serviceRequestManager); 
            currentForm = statusForm; 
            currentForm.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Show the Request Service Form
        /// </summary>
        public void ShowRequestForm()
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            RequestServiceForm requestForm = new RequestServiceForm(serviceRequestManager);
            currentForm = requestForm;
            currentForm.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Menu strip naviation
        /// </summary>
        public void ShowHomeForm()
        {
            Home homeForm = new Home();
            homeForm.Show();
        }

        public void ShowNewsForm()
        {
            NewsForm newsForm = new NewsForm();
            newsForm.Show();
        }

        public void ShowContactAboutForm()
        {
            ContactAboutForm contactForm = new ContactAboutForm();
            contactForm.Show();
        }
    }
}
//------------------------------------------------------------------------------------------------------[END]----------------------------------------------------------------------------------------------------------//
