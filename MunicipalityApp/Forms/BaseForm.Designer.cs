namespace MunicipalityApp.Forms
{
    partial class BaseForm
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
            this.menuStripAll = new System.Windows.Forms.MenuStrip();
            this.menu_home = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_menuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_news = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_contact = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAll
            // 
            this.menuStripAll.BackColor = System.Drawing.Color.Transparent;
            this.menuStripAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStripAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_home,
            this.menu_menuForm,
            this.menu_news,
            this.menu_contact,
            this.menu_about});
            this.menuStripAll.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStripAll.Location = new System.Drawing.Point(0, 0);
            this.menuStripAll.Name = "menuStripAll";
            this.menuStripAll.Size = new System.Drawing.Size(800, 28);
            this.menuStripAll.TabIndex = 14;
            this.menuStripAll.Text = "menuStrip1";
            // 
            // menu_home
            // 
            this.menu_home.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_home.Name = "menu_home";
            this.menu_home.Size = new System.Drawing.Size(57, 24);
            this.menu_home.Text = "Home";
            this.menu_home.Click += new System.EventHandler(this.menu_home_Click);
            // 
            // menu_menuForm
            // 
            this.menu_menuForm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_menuForm.Name = "menu_menuForm";
            this.menu_menuForm.Size = new System.Drawing.Size(54, 24);
            this.menu_menuForm.Text = "Menu";
            this.menu_menuForm.Click += new System.EventHandler(this.menu_menuForm_Click);
            // 
            // menu_news
            // 
            this.menu_news.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_news.Name = "menu_news";
            this.menu_news.Size = new System.Drawing.Size(54, 24);
            this.menu_news.Text = "News";
            this.menu_news.Click += new System.EventHandler(this.menu_news_Click);
            // 
            // menu_contact
            // 
            this.menu_contact.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_contact.Name = "menu_contact";
            this.menu_contact.Size = new System.Drawing.Size(85, 24);
            this.menu_contact.Text = "Contact Us";
            this.menu_contact.Click += new System.EventHandler(this.menu_contact_Click);
            // 
            // menu_about
            // 
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(68, 24);
            this.menu_about.Text = "About Us";
            this.menu_about.Click += new System.EventHandler(this.menu_about_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStripAll);
            this.Name = "BaseForm";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.menuStripAll.ResumeLayout(false);
            this.menuStripAll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAll;
        private System.Windows.Forms.ToolStripMenuItem menu_home;
        private System.Windows.Forms.ToolStripMenuItem menu_menuForm;
        private System.Windows.Forms.ToolStripMenuItem menu_news;
        private System.Windows.Forms.ToolStripMenuItem menu_contact;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
    }
}