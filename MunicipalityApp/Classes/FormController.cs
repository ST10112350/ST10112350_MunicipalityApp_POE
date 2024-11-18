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
        private IssueManager issueManager = new IssueManager();
        private ServiceRequestManager serviceRequestManager = new ServiceRequestManager();
        private SortedDictionary<DateTime, List<AnnouncementClass>> announcements = new SortedDictionary<DateTime, List<AnnouncementClass>>();

        /// <summary>
        /// Show the Report Issues Form
        /// </summary>
        public void ShowReportIssuesForm()
        {

            ReportIssuesForm reportForm = new ReportIssuesForm(issueManager);
            reportForm.Show();
            //currentForm.hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Show the Events and Announcements Form
        /// </summary>
        public void ShowEventsForm()
        {
            EventsAnnouncementsForm eventsForm = new EventsAnnouncementsForm();
            eventsForm.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Show the Menu Form menu strip 
        /// </summary>
        public void ShowMenuForm()
        {
            MenuForm1 menuForm = new MenuForm1();
            menuForm.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Show the Service Request Status Form
        /// </summary>
        public void showStatusForm()
        {
            ServiceRequestStatusForm statusForm = new ServiceRequestStatusForm(serviceRequestManager);
            statusForm.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Show the Request Service Form
        /// </summary>
        public void showRequestForm()
        {
            RequestServiceForm requestForm = new RequestServiceForm(serviceRequestManager);
            requestForm.Show();
        }

    }
}

//------------------------------------------------------------------------------------------------------[END]----------------------------------------------------------------------------------------------------------//
