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
            this.attach_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.report_menuStrip = new System.Windows.Forms.MenuStrip();
            this.home_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contact_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.attachedFiles_listBox = new System.Windows.Forms.ListBox();
            this.category_comboBox = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.date_lbl = new System.Windows.Forms.Label();
            this.issue_date = new System.Windows.Forms.DateTimePicker();
            this.reportNumber_txtbx = new System.Windows.Forms.TextBox();
            this.reportEmail_txtbx = new System.Windows.Forms.TextBox();
            this.reportName_txtbx = new System.Windows.Forms.TextBox();
            this.reportNumber_lbl = new System.Windows.Forms.Label();
            this.reportEmail_lbl = new System.Windows.Forms.Label();
            this.reportName_lbl = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.issueDelete_button = new System.Windows.Forms.RadioButton();
            this.issues_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.report_menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.location_txtbx.Location = new System.Drawing.Point(221, 219);
            this.location_txtbx.Name = "location_txtbx";
            this.location_txtbx.Size = new System.Drawing.Size(200, 20);
            this.location_txtbx.TabIndex = 1;
            this.location_txtbx.TextChanged += new System.EventHandler(this.location_txtbx_TextChanged);
            // 
            // discription_txtbx
            // 
            this.discription_txtbx.Location = new System.Drawing.Point(221, 245);
            this.discription_txtbx.Name = "discription_txtbx";
            this.discription_txtbx.Size = new System.Drawing.Size(200, 20);
            this.discription_txtbx.TabIndex = 2;
            this.discription_txtbx.TextChanged += new System.EventHandler(this.discription_txtbx_TextChanged);
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.submit_btn.Location = new System.Drawing.Point(305, 643);
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
            // 
            // attach_lbl
            // 
            this.attach_lbl.AutoSize = true;
            this.attach_lbl.BackColor = System.Drawing.Color.Transparent;
            this.attach_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.attach_lbl.Location = new System.Drawing.Point(52, 374);
            this.attach_lbl.Name = "attach_lbl";
            this.attach_lbl.Size = new System.Drawing.Size(184, 17);
            this.attach_lbl.TabIndex = 5;
            this.attach_lbl.Text = "Would you like Attach File? :";
            // 
            // location_lbl
            // 
            this.location_lbl.AutoSize = true;
            this.location_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.location_lbl.Location = new System.Drawing.Point(37, 222);
            this.location_lbl.Name = "location_lbl";
            this.location_lbl.Size = new System.Drawing.Size(66, 17);
            this.location_lbl.TabIndex = 6;
            this.location_lbl.Text = "Location:";
            // 
            // description_lbl
            // 
            this.description_lbl.AutoSize = true;
            this.description_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.description_lbl.Location = new System.Drawing.Point(37, 248);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(109, 17);
            this.description_lbl.TabIndex = 7;
            this.description_lbl.Text = "Issue Description:";
            // 
            // category_lbl
            // 
            this.category_lbl.AutoSize = true;
            this.category_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.category_lbl.Location = new System.Drawing.Point(37, 303);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(117, 17);
            this.category_lbl.TabIndex = 8;
            this.category_lbl.Text = "Select a category:";
            // 
            // attach_btn
            // 
            this.attach_btn.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.attach_btn.Location = new System.Drawing.Point(52, 397);
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
            this.no_btn.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.no_btn.Location = new System.Drawing.Point(207, 403);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(45, 21);
            this.no_btn.TabIndex = 11;
            this.no_btn.TabStop = true;
            this.no_btn.Text = "No";
            this.no_btn.UseVisualStyleBackColor = true;
            // 
            // report_menuStrip
            // 
            this.report_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home_news_menu,
            this.menu_news_menu,
            this.toolStripMenuItem3,
            this.contact_news_menu});
            this.report_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.report_menuStrip.Name = "report_menuStrip";
            this.report_menuStrip.Size = new System.Drawing.Size(1464, 28);
            this.report_menuStrip.TabIndex = 13;
            this.report_menuStrip.Text = "menuStrip1";
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
            this.menu_news_menu.Click += new System.EventHandler(this.menu_news_menu_Click);
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
            this.panel2.Controls.Add(this.attachedFiles_listBox);
            this.panel2.Controls.Add(this.category_comboBox);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.date_lbl);
            this.panel2.Controls.Add(this.issue_date);
            this.panel2.Controls.Add(this.reportNumber_txtbx);
            this.panel2.Controls.Add(this.reportEmail_txtbx);
            this.panel2.Controls.Add(this.reportName_txtbx);
            this.panel2.Controls.Add(this.reportNumber_lbl);
            this.panel2.Controls.Add(this.reportEmail_lbl);
            this.panel2.Controls.Add(this.reportName_lbl);
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
            this.panel2.Location = new System.Drawing.Point(347, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 701);
            this.panel2.TabIndex = 16;
            // 
            // attachedFiles_listBox
            // 
            this.attachedFiles_listBox.FormattingEnabled = true;
            this.attachedFiles_listBox.Location = new System.Drawing.Point(52, 504);
            this.attachedFiles_listBox.Name = "attachedFiles_listBox";
            this.attachedFiles_listBox.Size = new System.Drawing.Size(290, 95);
            this.attachedFiles_listBox.TabIndex = 25;
            // 
            // category_comboBox
            // 
            this.category_comboBox.FormattingEnabled = true;
            this.category_comboBox.Location = new System.Drawing.Point(221, 303);
            this.category_comboBox.Name = "category_comboBox";
            this.category_comboBox.Size = new System.Drawing.Size(200, 21);
            this.category_comboBox.TabIndex = 24;
            this.category_comboBox.Text = "Category";
            this.category_comboBox.SelectedIndexChanged += new System.EventHandler(this.category_comboBox_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(504, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.date_lbl.Location = new System.Drawing.Point(37, 179);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(42, 17);
            this.date_lbl.TabIndex = 22;
            this.date_lbl.Text = "Date:";
            // 
            // issue_date
            // 
            this.issue_date.Location = new System.Drawing.Point(221, 176);
            this.issue_date.Name = "issue_date";
            this.issue_date.Size = new System.Drawing.Size(200, 20);
            this.issue_date.TabIndex = 21;
            this.issue_date.ValueChanged += new System.EventHandler(this.issue_date_ValueChanged_1);
            // 
            // reportNumber_txtbx
            // 
            this.reportNumber_txtbx.Location = new System.Drawing.Point(221, 137);
            this.reportNumber_txtbx.Name = "reportNumber_txtbx";
            this.reportNumber_txtbx.Size = new System.Drawing.Size(200, 20);
            this.reportNumber_txtbx.TabIndex = 20;
            this.reportNumber_txtbx.TextChanged += new System.EventHandler(this.reportNumber_txtbx_TextChanged);
            // 
            // reportEmail_txtbx
            // 
            this.reportEmail_txtbx.Location = new System.Drawing.Point(221, 109);
            this.reportEmail_txtbx.Name = "reportEmail_txtbx";
            this.reportEmail_txtbx.Size = new System.Drawing.Size(200, 20);
            this.reportEmail_txtbx.TabIndex = 19;
            this.reportEmail_txtbx.TextChanged += new System.EventHandler(this.reportEmail_txtbx_TextChanged);
            // 
            // reportName_txtbx
            // 
            this.reportName_txtbx.Location = new System.Drawing.Point(221, 82);
            this.reportName_txtbx.Name = "reportName_txtbx";
            this.reportName_txtbx.Size = new System.Drawing.Size(200, 20);
            this.reportName_txtbx.TabIndex = 18;
            this.reportName_txtbx.TextChanged += new System.EventHandler(this.reportName_txtbx_TextChanged);
            // 
            // reportNumber_lbl
            // 
            this.reportNumber_lbl.AutoSize = true;
            this.reportNumber_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.reportNumber_lbl.Location = new System.Drawing.Point(37, 137);
            this.reportNumber_lbl.Name = "reportNumber_lbl";
            this.reportNumber_lbl.Size = new System.Drawing.Size(108, 17);
            this.reportNumber_lbl.TabIndex = 17;
            this.reportNumber_lbl.Text = "Phone Number:";
            // 
            // reportEmail_lbl
            // 
            this.reportEmail_lbl.AutoSize = true;
            this.reportEmail_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F);
            this.reportEmail_lbl.Location = new System.Drawing.Point(37, 108);
            this.reportEmail_lbl.Name = "reportEmail_lbl";
            this.reportEmail_lbl.Size = new System.Drawing.Size(47, 17);
            this.reportEmail_lbl.TabIndex = 16;
            this.reportEmail_lbl.Text = "Email:";
            // 
            // reportName_lbl
            // 
            this.reportName_lbl.AutoSize = true;
            this.reportName_lbl.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportName_lbl.Location = new System.Drawing.Point(37, 82);
            this.reportName_lbl.Name = "reportName_lbl";
            this.reportName_lbl.Size = new System.Drawing.Size(51, 17);
            this.reportName_lbl.TabIndex = 15;
            this.reportName_lbl.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.issueDelete_button);
            this.panel1.Controls.Add(this.issues_listbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 591);
            this.panel1.TabIndex = 17;
            // 
            // issueDelete_button
            // 
            this.issueDelete_button.AutoSize = true;
            this.issueDelete_button.Location = new System.Drawing.Point(69, 328);
            this.issueDelete_button.Name = "issueDelete_button";
            this.issueDelete_button.Size = new System.Drawing.Size(59, 17);
            this.issueDelete_button.TabIndex = 2;
            this.issueDelete_button.TabStop = true;
            this.issueDelete_button.Text = "Delete ";
            this.issueDelete_button.UseVisualStyleBackColor = true;
            this.issueDelete_button.CheckedChanged += new System.EventHandler(this.issueDelete_button_CheckedChanged);
            // 
            // issues_listbox
            // 
            this.issues_listbox.FormattingEnabled = true;
            this.issues_listbox.Location = new System.Drawing.Point(38, 109);
            this.issues_listbox.Name = "issues_listbox";
            this.issues_listbox.Size = new System.Drawing.Size(153, 212);
            this.issues_listbox.TabIndex = 1;
            this.issues_listbox.SelectedIndexChanged += new System.EventHandler(this.issues_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1464, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.report_menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.report_menuStrip.ResumeLayout(false);
            this.report_menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button attach_btn;
        private System.Windows.Forms.RadioButton no_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip report_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem home_news_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_news_menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem contact_news_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox reportNumber_txtbx;
        private System.Windows.Forms.TextBox reportEmail_txtbx;
        private System.Windows.Forms.TextBox reportName_txtbx;
        private System.Windows.Forms.Label reportNumber_lbl;
        private System.Windows.Forms.Label reportEmail_lbl;
        private System.Windows.Forms.Label reportName_lbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.DateTimePicker issue_date;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox category_comboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox issues_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox attachedFiles_listBox;
        private System.Windows.Forms.RadioButton issueDelete_button;
    }
}