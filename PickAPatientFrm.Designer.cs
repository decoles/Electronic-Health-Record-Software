﻿namespace MedicalSoftware
{
    partial class PickAPatientFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridpatients = new System.Windows.Forms.DataGridView();
            this.label34 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpatients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.gridpatients);
            this.panel2.Controls.Add(this.txtPatientId);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 255);
            this.panel2.TabIndex = 56;
            // 
            // gridpatients
            // 
            this.gridpatients.AllowUserToAddRows = false;
            this.gridpatients.AllowUserToDeleteRows = false;
            this.gridpatients.AllowUserToResizeColumns = false;
            this.gridpatients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.gridpatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridpatients.BackgroundColor = System.Drawing.Color.White;
            this.gridpatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(63)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridpatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridpatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridpatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridpatients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridpatients.Location = new System.Drawing.Point(9, 71);
            this.gridpatients.MultiSelect = false;
            this.gridpatients.Name = "gridpatients";
            this.gridpatients.ReadOnly = true;
            this.gridpatients.RowHeadersVisible = false;
            this.gridpatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridpatients.ShowEditingIcon = false;
            this.gridpatients.Size = new System.Drawing.Size(454, 165);
            this.gridpatients.TabIndex = 55;
            this.gridpatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridpatients_CellContentClick);
            this.gridpatients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridpatients_CellContentDoubleClick);
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(5, 18);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 21);
            this.label34.TabIndex = 69;
            this.label34.Text = "Search :";
            // 
            // txtPatientId
            // 
            this.txtPatientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPatientId.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            this.txtPatientId.Location = new System.Drawing.Point(76, 16);
            this.txtPatientId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(276, 27);
            this.txtPatientId.TabIndex = 68;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(374, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 27);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "Search";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // PickAPatientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 279);
            this.Controls.Add(this.panel2);
            this.Name = "PickAPatientFrm";
            this.Text = "PickAPatientFrm";
            this.Load += new System.EventHandler(this.PickAPatientFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridpatients;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Button btnSave;
    }
}