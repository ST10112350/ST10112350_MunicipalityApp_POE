using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MunicipalityApp.Forms;

namespace MunicipalityApp.Forms
{
    public partial class ContactAboutForm : Form
    {
        public ContactAboutForm()
        {
            InitializeComponent();
            // Adds menu strip from base form
            BaseForm menuStripControl = new BaseForm();
            menuStripControl.Dock = DockStyle.Top;
           // this.Controls.Add(menuStripControl);
            this.DoubleBuffered = true;
        }

        private void ContactAboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
