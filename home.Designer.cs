namespace MedicalSoftware
{
    partial class home
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnSchedule = new FontAwesome.Sharp.IconButton();
            this.btnPatient = new FontAwesome.Sharp.IconButton();
            this.btnChart = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelSideMenu.Controls.Add(this.btnSchedule);
            this.panelSideMenu.Controls.Add(this.btnPatient);
            this.panelSideMenu.Controls.Add(this.btnChart);
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnDashboard);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(100, 1021);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSchedule.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnSchedule.IconColor = System.Drawing.Color.Black;
            this.btnSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSchedule.IconSize = 30;
            this.btnSchedule.Location = new System.Drawing.Point(0, 184);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(100, 44);
            this.btnSchedule.TabIndex = 8;
            this.btnSchedule.Text = "Calender";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnPatient.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.btnPatient.IconColor = System.Drawing.Color.Black;
            this.btnPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPatient.IconSize = 30;
            this.btnPatient.Location = new System.Drawing.Point(0, 140);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(100, 44);
            this.btnPatient.TabIndex = 7;
            this.btnPatient.Text = "Patient";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnChart
            // 
            this.btnChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnChart.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnChart.IconColor = System.Drawing.Color.Black;
            this.btnChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChart.IconSize = 30;
            this.btnChart.Location = new System.Drawing.Point(0, 96);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(100, 44);
            this.btnChart.TabIndex = 6;
            this.btnChart.Text = "Charts";
            this.btnChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.Location = new System.Drawing.Point(0, 977);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 44);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnDashboard.IconColor = System.Drawing.Color.Black;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 30;
            this.btnDashboard.Location = new System.Drawing.Point(0, 52);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(100, 44);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(100, 52);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelTopMenu.Controls.Add(this.label1);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(100, 0);
            this.panelTopMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1784, 52);
            this.panelTopMenu.TabIndex = 1;
            this.panelTopMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTopMenu_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1292, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURRENT LOGGED IN STAFF MEMBER";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDesktop.Controls.Add(this.panelChildForm);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(100, 52);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1784, 969);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelChildForm.Size = new System.Drawing.Size(1784, 969);
            this.panelChildForm.TabIndex = 0;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 1021);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnChart;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnPatient;
        private FontAwesome.Sharp.IconButton btnSchedule;
    }
}