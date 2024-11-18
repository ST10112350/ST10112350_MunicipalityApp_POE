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
    public partial class NewsForm : Form
    {
        public NewsForm()
        {
            InitializeComponent();
            // Adds menu strip from base form
            BaseForm menuStripControl = new BaseForm();
            menuStripControl.Dock = DockStyle.Top;
            this.Controls.Add(menuStripControl);
        }

        private void NewsForm_Load(object sender, EventArgs e)
        {

        }

        private void category3_Click(object sender, EventArgs e)
        {

        }
    }
}
//------------------------------------------------------------------------[END]--------------------------------------------------------------------------------------------------------------------------------------//