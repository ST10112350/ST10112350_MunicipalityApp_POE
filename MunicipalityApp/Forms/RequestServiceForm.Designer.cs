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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.home_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contact_news_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.requestSubmit_btn = new System.Windows.Forms.Button();
            this.requestName_txtbox = new System.Windows.Forms.TextBox();
            this.requestEmail_txtbox = new System.Windows.Forms.TextBox();
            this.requestNumber_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.requestStype_dropdown = new System.Windows.Forms.ComboBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number:";
            // 
            // requestSubmit_btn
            // 
            this.requestSubmit_btn.Location = new System.Drawing.Point(270, 388);
            this.requestSubmit_btn.Name = "requestSubmit_btn";
            this.requestSubmit_btn.Size = new System.Drawing.Size(75, 23);
            this.requestSubmit_btn.TabIndex = 7;
            this.requestSubmit_btn.Text = "Submit!";
            this.requestSubmit_btn.UseVisualStyleBackColor = true;
            this.requestSubmit_btn.Click += new System.EventHandler(this.requestSubmit_btn_Click);
            // 
            // requestName_txtbox
            // 
            this.requestName_txtbox.Location = new System.Drawing.Point(78, 52);
            this.requestName_txtbox.Name = "requestName_txtbox";
            this.requestName_txtbox.Size = new System.Drawing.Size(100, 20);
            this.requestName_txtbox.TabIndex = 9;
            this.requestName_txtbox.Text = "Full Name";
            this.requestName_txtbox.TextChanged += new System.EventHandler(this.requestName_txtbox_TextChanged);
            // 
            // requestEmail_txtbox
            // 
            this.requestEmail_txtbox.Location = new System.Drawing.Point(78, 116);
            this.requestEmail_txtbox.Name = "requestEmail_txtbox";
            this.requestEmail_txtbox.Size = new System.Drawing.Size(100, 20);
            this.requestEmail_txtbox.TabIndex = 10;
            this.requestEmail_txtbox.TextChanged += new System.EventHandler(this.requestEmail_txtbox_TextChanged);
            // 
            // requestNumber_txtbox
            // 
            this.requestNumber_txtbox.Location = new System.Drawing.Point(115, 197);
            this.requestNumber_txtbox.Name = "requestNumber_txtbox";
            this.requestNumber_txtbox.Size = new System.Drawing.Size(100, 20);
            this.requestNumber_txtbox.TabIndex = 11;
            this.requestNumber_txtbox.TextChanged += new System.EventHandler(this.requestNumber_txtbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Type of Service:";
            // 
            // requestStype_dropdown
            // 
            this.requestStype_dropdown.FormattingEnabled = true;
            this.requestStype_dropdown.Location = new System.Drawing.Point(138, 274);
            this.requestStype_dropdown.Name = "requestStype_dropdown";
            this.requestStype_dropdown.Size = new System.Drawing.Size(121, 21);
            this.requestStype_dropdown.TabIndex = 13;
            this.requestStype_dropdown.SelectedIndexChanged += new System.EventHandler(this.requestStype_dropdown_SelectedIndexChanged);
            // 
            // RequestServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.requestStype_dropdown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.requestNumber_txtbox);
            this.Controls.Add(this.requestEmail_txtbox);
            this.Controls.Add(this.requestName_txtbox);
            this.Controls.Add(this.requestSubmit_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RequestServiceForm";
            this.Text = "RequestServiceForm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button requestSubmit_btn;
        private System.Windows.Forms.TextBox requestName_txtbox;
        private System.Windows.Forms.TextBox requestEmail_txtbox;
        private System.Windows.Forms.TextBox requestNumber_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox requestStype_dropdown;
    }
}