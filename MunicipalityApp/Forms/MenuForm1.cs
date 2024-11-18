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
using MunicipalityApp.Forms;


namespace MunicipalityApp
{
    public partial class MenuForm1 : Form
    {
        private FormController formController; // initalize form controller

        public MenuForm1()
        {
            InitializeComponent();
            formController = new FormController(); // Initialize  form controller
          
            // Adds menu strip from base form
            BaseForm menuStripControl = new BaseForm();
            //menuStripControl.Dock = DockStyle.Top;
            this.Controls.Add(menuStripControl);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Report issues button is handeled by the form controller
        /// </summary>
      
        private void option1btn_Click(object sender, EventArgs e)
        {
            formController.ShowReportIssuesForm(); // Method in FormController to show messages
            
        }

        private void option2btn_Click(object sender, EventArgs e)
        {
            formController.ShowEventsForm();   // Method in FormController to events and announcemts
            
        }

        private void option3btn_Click(object sender, EventArgs e)
        {
            formController.ShowStatusForm(); // Method in FormController to show service request status   

        }

        private void MenuForm1_Load(object sender, EventArgs e)
        {

        }

        private void instructions_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
//------------------------------------------------------END----------------------------------------------------------------//