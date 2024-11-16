namespace MunicipalityApp
{
    partial class MenuForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm1));
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.option1btn = new System.Windows.Forms.Button();
            this.option2btn = new System.Windows.Forms.Button();
            this.option3btn = new System.Windows.Forms.Button();
            this.instructions_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.welcomeLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.White;
            this.welcomeLbl.Location = new System.Drawing.Point(448, 39);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Padding = new System.Windows.Forms.Padding(5);
            this.welcomeLbl.Size = new System.Drawing.Size(373, 37);
            this.welcomeLbl.TabIndex = 1;
            this.welcomeLbl.Text = "Welcome to the Municipal Application! ";
            this.welcomeLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // option1btn
            // 
            this.option1btn.BackColor = System.Drawing.Color.IndianRed;
            this.option1btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1btn.ForeColor = System.Drawing.Color.White;
            this.option1btn.Location = new System.Drawing.Point(520, 162);
            this.option1btn.Name = "option1btn";
            this.option1btn.Size = new System.Drawing.Size(123, 57);
            this.option1btn.TabIndex = 2;
            this.option1btn.Text = "Report Issues";
            this.option1btn.UseVisualStyleBackColor = false;
            this.option1btn.Click += new System.EventHandler(this.option1btn_Click);
            // 
            // option2btn
            // 
            this.option2btn.BackColor = System.Drawing.Color.ForestGreen;
            this.option2btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2btn.ForeColor = System.Drawing.Color.White;
            this.option2btn.Location = new System.Drawing.Point(470, 263);
            this.option2btn.Name = "option2btn";
            this.option2btn.Size = new System.Drawing.Size(228, 68);
            this.option2btn.TabIndex = 3;
            this.option2btn.Text = "Local Events and Announcements";
            this.option2btn.UseVisualStyleBackColor = false;
            this.option2btn.Click += new System.EventHandler(this.option2btn_Click);
            // 
            // option3btn
            // 
            this.option3btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.option3btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3btn.ForeColor = System.Drawing.Color.White;
            this.option3btn.Location = new System.Drawing.Point(520, 384);
            this.option3btn.Name = "option3btn";
            this.option3btn.Size = new System.Drawing.Size(123, 71);
            this.option3btn.TabIndex = 4;
            this.option3btn.Text = "Service Request Status";
            this.option3btn.UseVisualStyleBackColor = false;
            this.option3btn.Click += new System.EventHandler(this.option3btn_Click);
            // 
            // instructions_lbl
            // 
            this.instructions_lbl.AutoSize = true;
            this.instructions_lbl.BackColor = System.Drawing.Color.Transparent;
            this.instructions_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions_lbl.ForeColor = System.Drawing.Color.White;
            this.instructions_lbl.Location = new System.Drawing.Point(466, 96);
            this.instructions_lbl.Name = "instructions_lbl";
            this.instructions_lbl.Size = new System.Drawing.Size(320, 21);
            this.instructions_lbl.TabIndex = 5;
            this.instructions_lbl.Text = "Please select one of the following options:";
            this.instructions_lbl.Click += new System.EventHandler(this.instructions_lbl_Click);
            // 
            // MenuForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 529);
            this.Controls.Add(this.instructions_lbl);
            this.Controls.Add(this.option3btn);
            this.Controls.Add(this.option2btn);
            this.Controls.Add(this.option1btn);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "MenuForm1";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MenuForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button option1btn;
        private System.Windows.Forms.Button option2btn;
        private System.Windows.Forms.Button option3btn;
        private System.Windows.Forms.Label instructions_lbl;
    }
}