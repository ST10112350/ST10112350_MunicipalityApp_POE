namespace MunicipalityApp.Forms
{
    partial class EventsAnnouncementsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsAnnouncementsForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.event_box = new System.Windows.Forms.ListBox();
            this.heading = new System.Windows.Forms.Label();
            this.eventsHeading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.announcementsListBox = new System.Windows.Forms.ListBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.search_lb = new System.Windows.Forms.Label();
            this.search_txtbx = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem1.Text = "Back to Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // event_box
            // 
            this.event_box.FormattingEnabled = true;
            this.event_box.Location = new System.Drawing.Point(21, 118);
            this.event_box.Name = "event_box";
            this.event_box.Size = new System.Drawing.Size(192, 134);
            this.event_box.TabIndex = 1;
            this.event_box.SelectedIndexChanged += new System.EventHandler(this.event_box_SelectedIndexChanged);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(69, 38);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(303, 25);
            this.heading.TabIndex = 2;
            this.heading.Text = "Local Events and Announcements";
            // 
            // eventsHeading
            // 
            this.eventsHeading.AutoSize = true;
            this.eventsHeading.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsHeading.Location = new System.Drawing.Point(46, 92);
            this.eventsHeading.Name = "eventsHeading";
            this.eventsHeading.Size = new System.Drawing.Size(62, 23);
            this.eventsHeading.TabIndex = 3;
            this.eventsHeading.Text = "Events";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Announcements";
            // 
            // announcementsListBox
            // 
            this.announcementsListBox.FormattingEnabled = true;
            this.announcementsListBox.Location = new System.Drawing.Point(568, 328);
            this.announcementsListBox.Name = "announcementsListBox";
            this.announcementsListBox.Size = new System.Drawing.Size(220, 95);
            this.announcementsListBox.TabIndex = 5;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(229, 128);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 6;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(356, 129);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 7;
            // 
            // search_lb
            // 
            this.search_lb.AutoSize = true;
            this.search_lb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lb.Location = new System.Drawing.Point(300, 95);
            this.search_lb.Name = "search_lb";
            this.search_lb.Size = new System.Drawing.Size(246, 20);
            this.search_lb.TabIndex = 8;
            this.search_lb.Text = "Search for event by Category and Date";
            // 
            // search_txtbx
            // 
            this.search_txtbx.Location = new System.Drawing.Point(318, 179);
            this.search_txtbx.Name = "search_txtbx";
            this.search_txtbx.Size = new System.Drawing.Size(114, 20);
            this.search_txtbx.TabIndex = 9;
            this.search_txtbx.TextChanged += new System.EventHandler(this.search_txtbx_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(339, 229);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "Search!";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // EventsAnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_txtbx);
            this.Controls.Add(this.search_lb);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.announcementsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventsHeading);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.event_box);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EventsAnnouncementsForm";
            this.Text = "EventsAnnouncementsForm";
            this.Load += new System.EventHandler(this.EventsAnnouncementsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox event_box;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label eventsHeading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox announcementsListBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label search_lb;
        private System.Windows.Forms.TextBox search_txtbx;
        private System.Windows.Forms.Button search_btn;
    }
}