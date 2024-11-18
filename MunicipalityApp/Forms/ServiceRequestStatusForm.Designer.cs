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
            this.request_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewRequests_dropdown = new System.Windows.Forms.ComboBox();
            this.requestReview_btn = new System.Windows.Forms.RadioButton();
            this.deleteRequest_btn = new System.Windows.Forms.RadioButton();
            this.viewAll_btn = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(880, 28);
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
            this.serviceRequests_Results.Location = new System.Drawing.Point(123, 251);
            this.serviceRequests_Results.Name = "serviceRequests_Results";
            this.serviceRequests_Results.Size = new System.Drawing.Size(198, 173);
            this.serviceRequests_Results.TabIndex = 2;
            this.serviceRequests_Results.SelectedIndexChanged += new System.EventHandler(this.serviceRequests_Results_SelectedIndexChanged);
            // 
            // request_btn
            // 
            this.request_btn.Location = new System.Drawing.Point(527, 443);
            this.request_btn.Name = "request_btn";
            this.request_btn.Size = new System.Drawing.Size(208, 23);
            this.request_btn.TabIndex = 3;
            this.request_btn.Text = "Request a Service";
            this.request_btn.UseVisualStyleBackColor = true;
            this.request_btn.Click += new System.EventHandler(this.request_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Service Requests by Service Type";
            // 
            // viewRequests_dropdown
            // 
            this.viewRequests_dropdown.FormattingEnabled = true;
            this.viewRequests_dropdown.Location = new System.Drawing.Point(75, 113);
            this.viewRequests_dropdown.Name = "viewRequests_dropdown";
            this.viewRequests_dropdown.Size = new System.Drawing.Size(121, 21);
            this.viewRequests_dropdown.TabIndex = 5;
            this.viewRequests_dropdown.Text = "Service Type";
            this.viewRequests_dropdown.SelectedIndexChanged += new System.EventHandler(this.viewRequests_dropdown_SelectedIndexChanged);
            // 
            // requestReview_btn
            // 
            this.requestReview_btn.AutoSize = true;
            this.requestReview_btn.Location = new System.Drawing.Point(123, 449);
            this.requestReview_btn.Name = "requestReview_btn";
            this.requestReview_btn.Size = new System.Drawing.Size(104, 17);
            this.requestReview_btn.TabIndex = 6;
            this.requestReview_btn.TabStop = true;
            this.requestReview_btn.Text = "Review Request";
            this.requestReview_btn.UseVisualStyleBackColor = true;
            this.requestReview_btn.CheckedChanged += new System.EventHandler(this.requestReview_btn_CheckedChanged);
            // 
            // deleteRequest_btn
            // 
            this.deleteRequest_btn.AutoSize = true;
            this.deleteRequest_btn.Location = new System.Drawing.Point(266, 449);
            this.deleteRequest_btn.Name = "deleteRequest_btn";
            this.deleteRequest_btn.Size = new System.Drawing.Size(56, 17);
            this.deleteRequest_btn.TabIndex = 7;
            this.deleteRequest_btn.TabStop = true;
            this.deleteRequest_btn.Text = "Delete";
            this.deleteRequest_btn.UseVisualStyleBackColor = true;
            this.deleteRequest_btn.CheckedChanged += new System.EventHandler(this.deleteRequest_btn_CheckedChanged);
            // 
            // viewAll_btn
            // 
            this.viewAll_btn.Location = new System.Drawing.Point(218, 111);
            this.viewAll_btn.Name = "viewAll_btn";
            this.viewAll_btn.Size = new System.Drawing.Size(75, 23);
            this.viewAll_btn.TabIndex = 9;
            this.viewAll_btn.Text = "View All";
            this.viewAll_btn.UseVisualStyleBackColor = true;
            this.viewAll_btn.Click += new System.EventHandler(this.viewAll_btn_Click);
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 645);
            this.Controls.Add(this.viewAll_btn);
            this.Controls.Add(this.deleteRequest_btn);
            this.Controls.Add(this.requestReview_btn);
            this.Controls.Add(this.viewRequests_dropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.request_btn);
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
        private System.Windows.Forms.Button request_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox viewRequests_dropdown;
        private System.Windows.Forms.RadioButton requestReview_btn;
        private System.Windows.Forms.RadioButton deleteRequest_btn;
        private System.Windows.Forms.Button viewAll_btn;
    }
}