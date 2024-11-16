namespace MunicipalityApp
{
    partial class ReportIssuesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssuesForm));
            this.issues_lbl = new System.Windows.Forms.Label();
            this.location_txtbx = new System.Windows.Forms.TextBox();
            this.discription_txtbx = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.attach_lbl = new System.Windows.Forms.Label();
            this.location_lbl = new System.Windows.Forms.Label();
            this.description_lbl = new System.Windows.Forms.Label();
            this.category_lbl = new System.Windows.Forms.Label();
            this.category_listBox = new System.Windows.Forms.ListBox();
            this.attach_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.requestService_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.home_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contact_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serviceType_dropdown = new System.Windows.Forms.ComboBox();
            this.reportServiceType_lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // issues_lbl
            // 
            this.issues_lbl.AutoSize = true;
            this.issues_lbl.BackColor = System.Drawing.Color.Transparent;
            this.issues_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issues_lbl.ForeColor = System.Drawing.Color.Black;
            this.issues_lbl.Location = new System.Drawing.Point(32, 31);
            this.issues_lbl.Name = "issues_lbl";
            this.issues_lbl.Size = new System.Drawing.Size(344, 25);
            this.issues_lbl.TabIndex = 0;
            this.issues_lbl.Text = "Please fill in the following information:";
            // 
            // location_txtbx
            // 
            this.location_txtbx.Location = new System.Drawing.Point(210, 84);
            this.location_txtbx.Name = "location_txtbx";
            this.location_txtbx.Size = new System.Drawing.Size(100, 20);
            this.location_txtbx.TabIndex = 1;
            this.location_txtbx.TextChanged += new System.EventHandler(this.location_txtbx_TextChanged);
            // 
            // discription_txtbx
            // 
            this.discription_txtbx.Location = new System.Drawing.Point(210, 110);
            this.discription_txtbx.Name = "discription_txtbx";
            this.discription_txtbx.Size = new System.Drawing.Size(153, 20);
            this.discription_txtbx.TabIndex = 2;
            this.discription_txtbx.TextChanged += new System.EventHandler(this.discription_txtbx_TextChanged);
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(359, 536);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(116, 41);
            this.submit_btn.TabIndex = 3;
            this.submit_btn.Text = "Submit!";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // attach_lbl
            // 
            this.attach_lbl.AutoSize = true;
            this.attach_lbl.BackColor = System.Drawing.Color.Transparent;
            this.attach_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_lbl.Location = new System.Drawing.Point(41, 330);
            this.attach_lbl.Name = "attach_lbl";
            this.attach_lbl.Size = new System.Drawing.Size(203, 20);
            this.attach_lbl.TabIndex = 5;
            this.attach_lbl.Text = "Would you like Attach File? :";
            // 
            // location_lbl
            // 
            this.location_lbl.AutoSize = true;
            this.location_lbl.BackColor = System.Drawing.Color.Gray;
            this.location_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_lbl.Location = new System.Drawing.Point(42, 87);
            this.location_lbl.Name = "location_lbl";
            this.location_lbl.Size = new System.Drawing.Size(71, 20);
            this.location_lbl.TabIndex = 6;
            this.location_lbl.Text = "Location:";
            // 
            // description_lbl
            // 
            this.description_lbl.AutoSize = true;
            this.description_lbl.BackColor = System.Drawing.Color.Gray;
            this.description_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lbl.Location = new System.Drawing.Point(41, 110);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(128, 20);
            this.description_lbl.TabIndex = 7;
            this.description_lbl.Text = "Issue Description:";
            // 
            // category_lbl
            // 
            this.category_lbl.AutoSize = true;
            this.category_lbl.BackColor = System.Drawing.Color.Gray;
            this.category_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_lbl.Location = new System.Drawing.Point(41, 173);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(130, 20);
            this.category_lbl.TabIndex = 8;
            this.category_lbl.Text = "Select a category:";
            // 
            // category_listBox
            // 
            this.category_listBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.category_listBox.AllowDrop = true;
            this.category_listBox.BackColor = System.Drawing.Color.MintCream;
            this.category_listBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_listBox.FormattingEnabled = true;
            this.category_listBox.ItemHeight = 20;
            this.category_listBox.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.category_listBox.Location = new System.Drawing.Point(210, 173);
            this.category_listBox.Name = "category_listBox";
            this.category_listBox.ScrollAlwaysVisible = true;
            this.category_listBox.Size = new System.Drawing.Size(120, 84);
            this.category_listBox.TabIndex = 9;
            this.category_listBox.SelectedIndexChanged += new System.EventHandler(this.category_listBox_SelectedIndexChanged);
            // 
            // attach_btn
            // 
            this.attach_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_btn.Location = new System.Drawing.Point(41, 353);
            this.attach_btn.Name = "attach_btn";
            this.attach_btn.Size = new System.Drawing.Size(111, 36);
            this.attach_btn.TabIndex = 10;
            this.attach_btn.Text = "Attach File";
            this.attach_btn.UseVisualStyleBackColor = true;
            this.attach_btn.Click += new System.EventHandler(this.attach_btn_Click);
            // 
            // no_btn
            // 
            this.no_btn.AutoSize = true;
            this.no_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_btn.Location = new System.Drawing.Point(196, 359);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(48, 24);
            this.no_btn.TabIndex = 11;
            this.no_btn.TabStop = true;
            this.no_btn.Text = "No";
            this.no_btn.UseVisualStyleBackColor = true;
            // 
            // requestService_btn
            // 
            this.requestService_btn.Location = new System.Drawing.Point(613, 47);
            this.requestService_btn.Name = "requestService_btn";
            this.requestService_btn.Size = new System.Drawing.Size(232, 35);
            this.requestService_btn.TabIndex = 12;
            this.requestService_btn.Text = "Would you like to request a Service?";
            this.requestService_btn.UseVisualStyleBackColor = true;
            this.requestService_btn.Click += new System.EventHandler(this.requestService_btn_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home_news_menu,
            this.menu_news_menu,
            this.toolStripMenuItem3,
            this.contact_news_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // home_news_menu
            // 
            this.home_news_menu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_news_menu.Name = "home_news_menu";
            this.home_news_menu.Size = new System.Drawing.Size(57, 24);
            this.home_news_menu.Text = "Home";
            // 
            // menu_news_menu
            // 
            this.menu_news_menu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_news_menu.Name = "menu_news_menu";
            this.menu_news_menu.Size = new System.Drawing.Size(54, 24);
            this.menu_news_menu.Text = "Menu";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(56, 24);
            this.toolStripMenuItem3.Text = "About";
            // 
            // contact_news_menu
            // 
            this.contact_news_menu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_news_menu.Name = "contact_news_menu";
            this.contact_news_menu.Size = new System.Drawing.Size(85, 24);
            this.contact_news_menu.Text = "Contact Us";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.reportServiceType_lbl);
            this.panel2.Controls.Add(this.serviceType_dropdown);
            this.panel2.Controls.Add(this.requestService_btn);
            this.panel2.Controls.Add(this.issues_lbl);
            this.panel2.Controls.Add(this.location_txtbx);
            this.panel2.Controls.Add(this.no_btn);
            this.panel2.Controls.Add(this.discription_txtbx);
            this.panel2.Controls.Add(this.attach_btn);
            this.panel2.Controls.Add(this.location_lbl);
            this.panel2.Controls.Add(this.attach_lbl);
            this.panel2.Controls.Add(this.description_lbl);
            this.panel2.Controls.Add(this.submit_btn);
            this.panel2.Controls.Add(this.category_lbl);
            this.panel2.Controls.Add(this.category_listBox);
            this.panel2.Location = new System.Drawing.Point(54, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 591);
            this.panel2.TabIndex = 16;
            // 
            // serviceType_dropdown
            // 
            this.serviceType_dropdown.FormattingEnabled = true;
            this.serviceType_dropdown.Location = new System.Drawing.Point(637, 159);
            this.serviceType_dropdown.Name = "serviceType_dropdown";
            this.serviceType_dropdown.Size = new System.Drawing.Size(208, 21);
            this.serviceType_dropdown.TabIndex = 13;
            this.serviceType_dropdown.SelectedIndexChanged += new System.EventHandler(this.serviceType_dropdown_SelectedIndexChanged_1);
            // 
            // reportServiceType_lbl
            // 
            this.reportServiceType_lbl.AutoSize = true;
            this.reportServiceType_lbl.Location = new System.Drawing.Point(613, 123);
            this.reportServiceType_lbl.Name = "reportServiceType_lbl";
            this.reportServiceType_lbl.Size = new System.Drawing.Size(73, 13);
            this.reportServiceType_lbl.TabIndex = 14;
            this.reportServiceType_lbl.Text = "Service Type:";
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label issues_lbl;
        private System.Windows.Forms.TextBox location_txtbx;
        private System.Windows.Forms.TextBox discription_txtbx;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label attach_lbl;
        private System.Windows.Forms.Label location_lbl;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.ListBox category_listBox;
        private System.Windows.Forms.Button attach_btn;
        private System.Windows.Forms.RadioButton no_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button requestService_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem home_news_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_news_menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem contact_news_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox serviceType_dropdown;
        private System.Windows.Forms.Label reportServiceType_lbl;
    }
}