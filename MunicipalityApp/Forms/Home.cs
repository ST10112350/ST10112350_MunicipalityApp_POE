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

namespace MunicipalityApp
{
    public partial class Home : Form
    {
        private FormController formController;
        public Home()
        {
            InitializeComponent();
        }



        private void starts_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void home_menu_Click(object sender, EventArgs e)
        {

        }

        private void report_menu_Click(object sender, EventArgs e)
        {
            formController.ShowReportIssuesForm(); // Method in FormController to show messages
        }

        private void service_menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not available");
            // option to be implemented at a later stage 
        }

        private void events_menu_Click(object sender, EventArgs e)
        {
            formController.ShowEventsForm();    // Method in FormController to show messages
        }
    }
}
