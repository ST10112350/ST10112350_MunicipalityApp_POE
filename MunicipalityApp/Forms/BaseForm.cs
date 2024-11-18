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

namespace MunicipalityApp.Forms
{
    public partial class BaseForm : UserControl
    {
        protected FormController formController;
        public BaseForm()
        {
            InitializeComponent();
            formController = new FormController();
            InitializeMenuStrip();
        }
        private void InitializeMenuStrip()
        {
            // Create and configure menu items
            ToolStripMenuItem menuHome = new ToolStripMenuItem("Home");
            menuHome.Click += menu_home_Click; // Attach the event handler

            ToolStripMenuItem menuMenuForm = new ToolStripMenuItem("Menu");
            menuMenuForm.Click += menu_menuForm_Click; // Attach the event handler

            ToolStripMenuItem menuNews = new ToolStripMenuItem("News");
            menuNews.Click += menu_news_Click; // Attach the event handler

            ToolStripMenuItem menuContact = new ToolStripMenuItem("Contact");
            menuContact.Click += menu_contact_Click; // Attach the event handler

            ToolStripMenuItem menuAbout = new ToolStripMenuItem("About");
            menuAbout.Click += menu_about_Click; // Attach the event handler

          
        }


        private void menu_home_Click(object sender, EventArgs e)
        {
            formController.ShowHomeForm();
        }

        private void menu_menuForm_Click(object sender, EventArgs e)
        {
            formController.ShowMenuForm();
        }

        private void menu_news_Click(object sender, EventArgs e)
        {
            formController.ShowNewsForm();
        }

        private void menu_contact_Click(object sender, EventArgs e)
        {
            formController.ShowContactAboutForm();
        }

        private void menu_about_Click(object sender, EventArgs e)
        {
            formController.ShowContactAboutForm();
        }
    }
}
