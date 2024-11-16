namespace MunicipalityApp.Forms
{
    partial class ServiceRequestStatusForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.home_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contact_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceRequests_Results = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
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
            // serviceRequests_Results
            // 
            this.serviceRequests_Results.FormattingEnabled = true;
            this.serviceRequests_Results.Location = new System.Drawing.Point(103, 165);
            this.serviceRequests_Results.Name = "serviceRequests_Results";
            this.serviceRequests_Results.Size = new System.Drawing.Size(198, 173);
            this.serviceRequests_Results.TabIndex = 2;
            this.serviceRequests_Results.SelectedIndexChanged += new System.EventHandler(this.serviceRequests_Results_SelectedIndexChanged);
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serviceRequests_Results);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ServiceRequestStatusForm";
            this.Text = "ServiceRequestStatusForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem home_news_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_news_menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem contact_news_menu;
        private System.Windows.Forms.ListBox serviceRequests_Results;
    }
}