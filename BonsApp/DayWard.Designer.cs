using System;

namespace BonsApp
{
    partial class DayWard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayWard));
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.RichTextBox();
            this.grpRecovery = new System.Windows.Forms.GroupBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtEstimateTime = new System.Windows.Forms.TextBox();
            this.lblEstimateTime = new System.Windows.Forms.Label();
            this.txtBayNo = new System.Windows.Forms.TextBox();
            this.lblBayNo = new System.Windows.Forms.Label();
            this.txtPatientType = new System.Windows.Forms.TextBox();
            this.lblPatientType = new System.Windows.Forms.Label();
            this.rchBoxReason = new System.Windows.Forms.RichTextBox();
            this.lblReasonDelay = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.RichTextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPasid = new System.Windows.Forms.Label();
            this.txtPasid = new System.Windows.Forms.TextBox();
            this.btnUpdateRecovery = new System.Windows.Forms.Button();
            this.cmbRecovery = new System.Windows.Forms.ComboBox();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dtvRecovery = new System.Windows.Forms.DataGridView();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpRecovery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRecovery)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnInsert.FlatAppearance.BorderSize = 2;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Navy;
            this.btnInsert.Location = new System.Drawing.Point(634, 802);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(144, 48);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Retrieve Data";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(199, 124);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(296, 31);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Text = "";
            // 
            // grpRecovery
            // 
            this.grpRecovery.Controls.Add(this.lblMin);
            this.grpRecovery.Controls.Add(this.txtEstimateTime);
            this.grpRecovery.Controls.Add(this.lblEstimateTime);
            this.grpRecovery.Controls.Add(this.txtBayNo);
            this.grpRecovery.Controls.Add(this.lblBayNo);
            this.grpRecovery.Controls.Add(this.txtPatientType);
            this.grpRecovery.Controls.Add(this.lblPatientType);
            this.grpRecovery.Controls.Add(this.rchBoxReason);
            this.grpRecovery.Controls.Add(this.lblReasonDelay);
            this.grpRecovery.Controls.Add(this.txtTitle);
            this.grpRecovery.Controls.Add(this.lblTitle);
            this.grpRecovery.Controls.Add(this.txtSurname);
            this.grpRecovery.Controls.Add(this.lblSurname);
            this.grpRecovery.Controls.Add(this.lblPasid);
            this.grpRecovery.Controls.Add(this.txtPasid);
            this.grpRecovery.Controls.Add(this.btnUpdateRecovery);
            this.grpRecovery.Controls.Add(this.cmbRecovery);
            this.grpRecovery.Controls.Add(this.lblTransfer);
            this.grpRecovery.Controls.Add(this.lblFirstName);
            this.grpRecovery.Controls.Add(this.txtFirstName);
            this.grpRecovery.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecovery.Location = new System.Drawing.Point(240, 12);
            this.grpRecovery.Name = "grpRecovery";
            this.grpRecovery.Size = new System.Drawing.Size(538, 610);
            this.grpRecovery.TabIndex = 3;
            this.grpRecovery.TabStop = false;
            this.grpRecovery.Text = "Recovery";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(326, 325);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(75, 22);
            this.lblMin.TabIndex = 21;
            this.lblMin.Text = "Minutes";
            // 
            // txtEstimateTime
            // 
            this.txtEstimateTime.Location = new System.Drawing.Point(199, 322);
            this.txtEstimateTime.Name = "txtEstimateTime";
            this.txtEstimateTime.Size = new System.Drawing.Size(121, 29);
            this.txtEstimateTime.TabIndex = 20;
            // 
            // lblEstimateTime
            // 
            this.lblEstimateTime.AutoSize = true;
            this.lblEstimateTime.Location = new System.Drawing.Point(43, 324);
            this.lblEstimateTime.Name = "lblEstimateTime";
            this.lblEstimateTime.Size = new System.Drawing.Size(136, 22);
            this.lblEstimateTime.TabIndex = 19;
            this.lblEstimateTime.Text = "Estimate Time:";
            // 
            // txtBayNo
            // 
            this.txtBayNo.Location = new System.Drawing.Point(199, 271);
            this.txtBayNo.Name = "txtBayNo";
            this.txtBayNo.ReadOnly = true;
            this.txtBayNo.Size = new System.Drawing.Size(121, 29);
            this.txtBayNo.TabIndex = 18;
            // 
            // lblBayNo
            // 
            this.lblBayNo.AutoSize = true;
            this.lblBayNo.Location = new System.Drawing.Point(59, 278);
            this.lblBayNo.Name = "lblBayNo";
            this.lblBayNo.Size = new System.Drawing.Size(124, 22);
            this.lblBayNo.TabIndex = 17;
            this.lblBayNo.Text = "Bay Number: ";
            // 
            // txtPatientType
            // 
            this.txtPatientType.Location = new System.Drawing.Point(199, 222);
            this.txtPatientType.Name = "txtPatientType";
            this.txtPatientType.ReadOnly = true;
            this.txtPatientType.Size = new System.Drawing.Size(121, 29);
            this.txtPatientType.TabIndex = 16;
            // 
            // lblPatientType
            // 
            this.lblPatientType.AutoSize = true;
            this.lblPatientType.Location = new System.Drawing.Point(58, 229);
            this.lblPatientType.Name = "lblPatientType";
            this.lblPatientType.Size = new System.Drawing.Size(125, 22);
            this.lblPatientType.TabIndex = 15;
            this.lblPatientType.Text = "Patient Type: ";
            // 
            // rchBoxReason
            // 
            this.rchBoxReason.Location = new System.Drawing.Point(199, 426);
            this.rchBoxReason.Name = "rchBoxReason";
            this.rchBoxReason.Size = new System.Drawing.Size(318, 96);
            this.rchBoxReason.TabIndex = 14;
            this.rchBoxReason.Text = "Non To Report";
            // 
            // lblReasonDelay
            // 
            this.lblReasonDelay.AutoSize = true;
            this.lblReasonDelay.Location = new System.Drawing.Point(10, 427);
            this.lblReasonDelay.Name = "lblReasonDelay";
            this.lblReasonDelay.Size = new System.Drawing.Size(173, 22);
            this.lblReasonDelay.TabIndex = 13;
            this.lblReasonDelay.Text = "Reason For Delay: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(199, 73);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(121, 29);
            this.txtTitle.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(127, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 22);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title: ";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(199, 173);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(296, 31);
            this.txtSurname.TabIndex = 10;
            this.txtSurname.Text = "";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(86, 177);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(96, 22);
            this.lblSurname.TabIndex = 9;
            this.lblSurname.Text = "Surname: ";
            // 
            // lblPasid
            // 
            this.lblPasid.AutoSize = true;
            this.lblPasid.Location = new System.Drawing.Point(116, 30);
            this.lblPasid.Name = "lblPasid";
            this.lblPasid.Size = new System.Drawing.Size(63, 22);
            this.lblPasid.TabIndex = 8;
            this.lblPasid.Text = "Pasid:";
            // 
            // txtPasid
            // 
            this.txtPasid.Location = new System.Drawing.Point(199, 23);
            this.txtPasid.Name = "txtPasid";
            this.txtPasid.Size = new System.Drawing.Size(121, 29);
            this.txtPasid.TabIndex = 7;
            // 
            // btnUpdateRecovery
            // 
            this.btnUpdateRecovery.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnUpdateRecovery.FlatAppearance.BorderSize = 2;
            this.btnUpdateRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRecovery.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRecovery.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateRecovery.Location = new System.Drawing.Point(379, 546);
            this.btnUpdateRecovery.Name = "btnUpdateRecovery";
            this.btnUpdateRecovery.Size = new System.Drawing.Size(138, 47);
            this.btnUpdateRecovery.TabIndex = 6;
            this.btnUpdateRecovery.Text = "Allow Transfer";
            this.btnUpdateRecovery.UseVisualStyleBackColor = true;
            this.btnUpdateRecovery.Click += new System.EventHandler(this.btnUpdateRecovery_Click);
            // 
            // cmbRecovery
            // 
            this.cmbRecovery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecovery.FormattingEnabled = true;
            this.cmbRecovery.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbRecovery.Location = new System.Drawing.Point(199, 374);
            this.cmbRecovery.Name = "cmbRecovery";
            this.cmbRecovery.Size = new System.Drawing.Size(121, 30);
            this.cmbRecovery.TabIndex = 5;
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Location = new System.Drawing.Point(8, 382);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(171, 22);
            this.lblTransfer.TabIndex = 4;
            this.lblTransfer.Text = "Ready To Transfer:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(70, 130);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 22);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name: ";
            // 
            // dtvRecovery
            // 
            this.dtvRecovery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRecovery.Location = new System.Drawing.Point(12, 640);
            this.dtvRecovery.Name = "dtvRecovery";
            this.dtvRecovery.ReadOnly = true;
            this.dtvRecovery.Size = new System.Drawing.Size(766, 146);
            this.dtvRecovery.TabIndex = 3;
            this.dtvRecovery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvRecovery_CellContentClick);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(81, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 430);
            this.richTextBox2.TabIndex = 22;
            this.richTextBox2.Text = "";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Navy;
            this.btnLogout.Location = new System.Drawing.Point(12, 802);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 48);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DayWard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 862);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.grpRecovery);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtvRecovery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DayWard";
            this.Text = "Day Ward";
            this.Load += new System.EventHandler(this.DayWard_Load);
            this.grpRecovery.ResumeLayout(false);
            this.grpRecovery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRecovery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RichTextBox txtFirstName;
        private System.Windows.Forms.GroupBox grpRecovery;
        private System.Windows.Forms.DataGridView dtvRecovery;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTransfer;
        public System.Windows.Forms.ComboBox cmbRecovery;
        private System.Windows.Forms.Button btnUpdateRecovery;
        private System.Windows.Forms.TextBox txtPasid;
        private System.Windows.Forms.Label lblPasid;
        private System.Windows.Forms.RichTextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReasonDelay;
        private System.Windows.Forms.RichTextBox rchBoxReason;
        private System.Windows.Forms.Label lblPatientType;
        private System.Windows.Forms.Label lblBayNo;
        private System.Windows.Forms.TextBox txtPatientType;
        private System.Windows.Forms.TextBox txtBayNo;
        private System.Windows.Forms.Label lblMin;
        public System.Windows.Forms.TextBox txtEstimateTime;
        private System.Windows.Forms.Label lblEstimateTime;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnLogout;
    }
}