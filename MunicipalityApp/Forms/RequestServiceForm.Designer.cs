namespace MunicipalityApp.Forms
{
    partial class RequestServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestServiceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.requestSubmit_btn = new System.Windows.Forms.Button();
            this.requestName_txtbox = new System.Windows.Forms.TextBox();
            this.requestEmail_txtbox = new System.Windows.Forms.TextBox();
            this.requestNumber_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.requestStype_dropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(99, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(99, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(95, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number:";
            // 
            // requestSubmit_btn
            // 
            this.requestSubmit_btn.Location = new System.Drawing.Point(86, 568);
            this.requestSubmit_btn.Name = "requestSubmit_btn";
            this.requestSubmit_btn.Size = new System.Drawing.Size(110, 44);
            this.requestSubmit_btn.TabIndex = 7;
            this.requestSubmit_btn.Text = "Submit!";
            this.requestSubmit_btn.UseVisualStyleBackColor = true;
            this.requestSubmit_btn.Click += new System.EventHandler(this.requestSubmit_btn_Click);
            // 
            // requestName_txtbox
            // 
            this.requestName_txtbox.Location = new System.Drawing.Point(230, 205);
            this.requestName_txtbox.Name = "requestName_txtbox";
            this.requestName_txtbox.Size = new System.Drawing.Size(121, 20);
            this.requestName_txtbox.TabIndex = 9;
            this.requestName_txtbox.TextChanged += new System.EventHandler(this.requestName_txtbox_TextChanged);
            // 
            // requestEmail_txtbox
            // 
            this.requestEmail_txtbox.Location = new System.Drawing.Point(230, 265);
            this.requestEmail_txtbox.Name = "requestEmail_txtbox";
            this.requestEmail_txtbox.Size = new System.Drawing.Size(121, 20);
            this.requestEmail_txtbox.TabIndex = 10;
            this.requestEmail_txtbox.TextChanged += new System.EventHandler(this.requestEmail_txtbox_TextChanged);
            // 
            // requestNumber_txtbox
            // 
            this.requestNumber_txtbox.Location = new System.Drawing.Point(230, 337);
            this.requestNumber_txtbox.Name = "requestNumber_txtbox";
            this.requestNumber_txtbox.Size = new System.Drawing.Size(121, 20);
            this.requestNumber_txtbox.TabIndex = 11;
            this.requestNumber_txtbox.TextChanged += new System.EventHandler(this.requestNumber_txtbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(95, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Type of Service:";
            // 
            // requestStype_dropdown
            // 
            this.requestStype_dropdown.FormattingEnabled = true;
            this.requestStype_dropdown.Location = new System.Drawing.Point(230, 423);
            this.requestStype_dropdown.Name = "requestStype_dropdown";
            this.requestStype_dropdown.Size = new System.Drawing.Size(121, 21);
            this.requestStype_dropdown.TabIndex = 13;
            this.requestStype_dropdown.Text = "Service";
            this.requestStype_dropdown.SelectedIndexChanged += new System.EventHandler(this.requestStype_dropdown_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(46, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "To request a Service, please fill in the following:";
            // 
            // RequestServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(562, 755);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.requestStype_dropdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.requestNumber_txtbox);
            this.Controls.Add(this.requestEmail_txtbox);
            this.Controls.Add(this.requestName_txtbox);
            this.Controls.Add(this.requestSubmit_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestServiceForm";
            this.Text = "RequestServiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button requestSubmit_btn;
        private System.Windows.Forms.TextBox requestName_txtbox;
        private System.Windows.Forms.TextBox requestEmail_txtbox;
        private System.Windows.Forms.TextBox requestNumber_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox requestStype_dropdown;
        private System.Windows.Forms.Label label5;
    }
}