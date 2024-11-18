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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // event_box
            // 
            this.event_box.FormattingEnabled = true;
            this.event_box.Location = new System.Drawing.Point(92, 173);
            this.event_box.Name = "event_box";
            this.event_box.Size = new System.Drawing.Size(192, 134);
            this.event_box.TabIndex = 1;
            this.event_box.SelectedIndexChanged += new System.EventHandler(this.event_box_SelectedIndexChanged);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(140, 93);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(303, 25);
            this.heading.TabIndex = 2;
            this.heading.Text = "Local Events and Announcements";
            // 
            // eventsHeading
            // 
            this.eventsHeading.AutoSize = true;
            this.eventsHeading.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsHeading.Location = new System.Drawing.Point(117, 147);
            this.eventsHeading.Name = "eventsHeading";
            this.eventsHeading.Size = new System.Drawing.Size(62, 23);
            this.eventsHeading.TabIndex = 3;
            this.eventsHeading.Text = "Events";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Announcements";
            // 
            // announcementsListBox
            // 
            this.announcementsListBox.FormattingEnabled = true;
            this.announcementsListBox.Location = new System.Drawing.Point(7, 56);
            this.announcementsListBox.Name = "announcementsListBox";
            this.announcementsListBox.Size = new System.Drawing.Size(220, 95);
            this.announcementsListBox.TabIndex = 5;
            this.announcementsListBox.SelectedIndexChanged += new System.EventHandler(this.announcementsListBox_SelectedIndexChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(300, 183);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 6;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(427, 184);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 7;
            // 
            // search_lb
            // 
            this.search_lb.AutoSize = true;
            this.search_lb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lb.Location = new System.Drawing.Point(371, 150);
            this.search_lb.Name = "search_lb";
            this.search_lb.Size = new System.Drawing.Size(246, 20);
            this.search_lb.TabIndex = 8;
            this.search_lb.Text = "Search for event by Category and Date";
            // 
            // search_txtbx
            // 
            this.search_txtbx.Location = new System.Drawing.Point(389, 234);
            this.search_txtbx.Name = "search_txtbx";
            this.search_txtbx.Size = new System.Drawing.Size(114, 20);
            this.search_txtbx.TabIndex = 9;
            this.search_txtbx.TextChanged += new System.EventHandler(this.search_txtbx_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(410, 284);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "Search!";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.announcementsListBox);
            this.panel1.Location = new System.Drawing.Point(857, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 230);
            this.panel1.TabIndex = 11;
            // 
            // EventsAnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1147, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_txtbx);
            this.Controls.Add(this.search_lb);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.eventsHeading);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.event_box);
            this.Name = "EventsAnnouncementsForm";
            this.Text = "EventsAnnouncementsForm";
            this.Load += new System.EventHandler(this.EventsAnnouncementsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel panel1;
    }
}