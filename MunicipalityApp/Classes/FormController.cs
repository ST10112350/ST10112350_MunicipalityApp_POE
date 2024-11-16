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

        // Show the Report Issues Form
        public void ShowReportIssuesForm()
        {

            ReportIssuesForm reportForm = new ReportIssuesForm(issueManager, serviceRequestManager);
            reportForm.Show();
            //currentForm.hide();
        }

        // Show the Events and Announcements Form
        public void ShowEventsForm()
        {
            EventsAnnouncementsForm eventsForm = new EventsAnnouncementsForm();
            eventsForm.Show();
        }
        // Show the Menu Form menu strip 
        public void ShowMenuForm()
        {
            MenuForm1 menuForm = new MenuForm1();
            menuForm.Show();
        }

        public void showStatusForm()
        {
            ServiceRequestStatusForm statusForm = new ServiceRequestStatusForm(serviceRequestManager);
            statusForm.Show();
        }
        
        public void showRequestForm()
        {
            RequestServiceForm requestForm = new RequestServiceForm(serviceRequestManager);
            requestForm.Show();
        }

    }
}

//-------------------------------------------------------END----------------------------------------------------------------------------//
