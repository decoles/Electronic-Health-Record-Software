namespace MedicalSoftware
{
    partial class viewPatient
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pfpbox = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfpbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pfpbox);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1684, 70);
            this.panelTop.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(254, 30);
            this.label14.TabIndex = 34;
            this.label14.Text = "Patient Overview";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pfpbox
            // 
            this.pfpbox.BackColor = System.Drawing.Color.White;
            this.pfpbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pfpbox.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.pfpbox.IconColor = System.Drawing.SystemColors.ControlText;
            this.pfpbox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pfpbox.IconSize = 54;
            this.pfpbox.Location = new System.Drawing.Point(11, 3);
            this.pfpbox.Name = "pfpbox";
            this.pfpbox.Size = new System.Drawing.Size(81, 54);
            this.pfpbox.TabIndex = 0;
            this.pfpbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // viewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 961);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panelTop);
            this.Name = "viewPatient";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfpbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconPictureBox pfpbox;
        private System.Windows.Forms.Label label1;
    }
}