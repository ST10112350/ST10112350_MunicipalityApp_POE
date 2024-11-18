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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestStatusForm));
            this.serviceRequests_Results = new System.Windows.Forms.ListBox();
            this.request_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewRequests_dropdown = new System.Windows.Forms.ComboBox();
            this.deleteRequest_btn = new System.Windows.Forms.RadioButton();
            this.viewAll_btn = new System.Windows.Forms.Button();
            this.requestReview_btn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
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
            this.request_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_btn.Location = new System.Drawing.Point(77, 542);
            this.request_btn.Name = "request_btn";
            this.request_btn.Size = new System.Drawing.Size(208, 50);
            this.request_btn.TabIndex = 3;
            this.request_btn.Text = "Request a Service";
            this.request_btn.UseVisualStyleBackColor = true;
            this.request_btn.Click += new System.EventHandler(this.request_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Service Requests by Service Type";
            // 
            // viewRequests_dropdown
            // 
            this.viewRequests_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRequests_dropdown.FormattingEnabled = true;
            this.viewRequests_dropdown.Location = new System.Drawing.Point(77, 129);
            this.viewRequests_dropdown.Name = "viewRequests_dropdown";
            this.viewRequests_dropdown.Size = new System.Drawing.Size(158, 28);
            this.viewRequests_dropdown.TabIndex = 5;
            this.viewRequests_dropdown.Text = "Service Type";
            this.viewRequests_dropdown.SelectedIndexChanged += new System.EventHandler(this.viewRequests_dropdown_SelectedIndexChanged);
            // 
            // deleteRequest_btn
            // 
            this.deleteRequest_btn.AutoSize = true;
            this.deleteRequest_btn.BackColor = System.Drawing.Color.Transparent;
            this.deleteRequest_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRequest_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteRequest_btn.Location = new System.Drawing.Point(266, 449);
            this.deleteRequest_btn.Name = "deleteRequest_btn";
            this.deleteRequest_btn.Size = new System.Drawing.Size(71, 20);
            this.deleteRequest_btn.TabIndex = 7;
            this.deleteRequest_btn.TabStop = true;
            this.deleteRequest_btn.Text = "Delete";
            this.deleteRequest_btn.UseVisualStyleBackColor = false;
            this.deleteRequest_btn.CheckedChanged += new System.EventHandler(this.deleteRequest_btn_CheckedChanged);
            // 
            // viewAll_btn
            // 
            this.viewAll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAll_btn.Location = new System.Drawing.Point(266, 127);
            this.viewAll_btn.Name = "viewAll_btn";
            this.viewAll_btn.Size = new System.Drawing.Size(118, 30);
            this.viewAll_btn.TabIndex = 9;
            this.viewAll_btn.Text = "View All";
            this.viewAll_btn.UseVisualStyleBackColor = true;
            this.viewAll_btn.Click += new System.EventHandler(this.viewAll_btn_Click);
            // 
            // requestReview_btn
            // 
            this.requestReview_btn.AutoSize = true;
            this.requestReview_btn.BackColor = System.Drawing.Color.Transparent;
            this.requestReview_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestReview_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.requestReview_btn.Location = new System.Drawing.Point(123, 448);
            this.requestReview_btn.Name = "requestReview_btn";
            this.requestReview_btn.Size = new System.Drawing.Size(80, 22);
            this.requestReview_btn.TabIndex = 10;
            this.requestReview_btn.TabStop = true;
            this.requestReview_btn.Text = "Review";
            this.requestReview_btn.UseVisualStyleBackColor = false;
            this.requestReview_btn.CheckedChanged += new System.EventHandler(this.requestReview_btn_CheckedChanged_1);
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 645);
            this.Controls.Add(this.requestReview_btn);
            this.Controls.Add(this.viewAll_btn);
            this.Controls.Add(this.deleteRequest_btn);
            this.Controls.Add(this.viewRequests_dropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.request_btn);
            this.Controls.Add(this.serviceRequests_Results);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceRequestStatusForm";
            this.Text = "ServiceRequestStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox serviceRequests_Results;
        private System.Windows.Forms.Button request_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox viewRequests_dropdown;
        private System.Windows.Forms.RadioButton deleteRequest_btn;
        private System.Windows.Forms.Button viewAll_btn;
        private System.Windows.Forms.RadioButton requestReview_btn;
    }
}