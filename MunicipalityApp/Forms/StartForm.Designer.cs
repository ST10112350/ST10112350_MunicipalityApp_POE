namespace MunicipalityApp
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.starts_menu = new System.Windows.Forms.MenuStrip();
            this.home_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.report_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.events_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.service_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.starts_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // starts_menu
            // 
            this.starts_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home_menu,
            this.report_menu,
            this.events_menu,
            this.service_menu});
            this.starts_menu.Location = new System.Drawing.Point(0, 0);
            this.starts_menu.Name = "starts_menu";
            this.starts_menu.Size = new System.Drawing.Size(800, 24);
            this.starts_menu.TabIndex = 0;
            this.starts_menu.Text = "Menu";
            this.starts_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.starts_menu_ItemClicked);
            // 
            // home_menu
            // 
            this.home_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2});
            this.home_menu.Name = "home_menu";
            this.home_menu.Size = new System.Drawing.Size(52, 20);
            this.home_menu.Text = "Home";
            this.home_menu.Click += new System.EventHandler(this.home_menu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(57, 6);
            // 
            // report_menu
            // 
            this.report_menu.Name = "report_menu";
            this.report_menu.Size = new System.Drawing.Size(83, 20);
            this.report_menu.Text = "Report Issue";
            this.report_menu.Click += new System.EventHandler(this.report_menu_Click);
            // 
            // events_menu
            // 
            this.events_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.events_menu.Name = "events_menu";
            this.events_menu.Size = new System.Drawing.Size(198, 20);
            this.events_menu.Text = "Local Events and Announcements";
            this.events_menu.Click += new System.EventHandler(this.events_menu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(740, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 54);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // service_menu
            // 
            this.service_menu.Name = "service_menu";
            this.service_menu.Size = new System.Drawing.Size(136, 20);
            this.service_menu.Text = "Request Service Status";
            this.service_menu.Click += new System.EventHandler(this.service_menu_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.starts_menu);
            this.MainMenuStrip = this.starts_menu;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.starts_menu.ResumeLayout(false);
            this.starts_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip starts_menu;
        private System.Windows.Forms.ToolStripMenuItem home_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem report_menu;
        private System.Windows.Forms.ToolStripMenuItem events_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem service_menu;
    }
}