namespace BonsApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnRecovery = new System.Windows.Forms.Button();
            this.lblHomeBonSecours = new System.Windows.Forms.Label();
            this.btnDayward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecovery
            // 
            this.btnRecovery.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnRecovery.FlatAppearance.BorderSize = 2;
            this.btnRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecovery.Font = new System.Drawing.Font("OpenSymbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecovery.ForeColor = System.Drawing.Color.Navy;
            this.btnRecovery.Location = new System.Drawing.Point(47, 271);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(125, 57);
            this.btnRecovery.TabIndex = 1;
            this.btnRecovery.Text = "Recovery";
            this.btnRecovery.UseVisualStyleBackColor = true;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // lblHomeBonSecours
            // 
            this.lblHomeBonSecours.AutoSize = true;
            this.lblHomeBonSecours.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeBonSecours.Location = new System.Drawing.Point(28, 13);
            this.lblHomeBonSecours.Name = "lblHomeBonSecours";
            this.lblHomeBonSecours.Size = new System.Drawing.Size(191, 34);
            this.lblHomeBonSecours.TabIndex = 0;
            this.lblHomeBonSecours.Text = "Bon Secours";
            // 
            // btnDayward
            // 
            this.btnDayward.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnDayward.FlatAppearance.BorderSize = 2;
            this.btnDayward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDayward.Font = new System.Drawing.Font("OpenSymbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDayward.ForeColor = System.Drawing.Color.Navy;
            this.btnDayward.Location = new System.Drawing.Point(286, 271);
            this.btnDayward.Name = "btnDayward";
            this.btnDayward.Size = new System.Drawing.Size(125, 57);
            this.btnDayward.TabIndex = 2;
            this.btnDayward.Text = "Dayward";
            this.btnDayward.UseVisualStyleBackColor = true;
            this.btnDayward.Click += new System.EventHandler(this.btnDayward_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 380);
            this.Controls.Add(this.btnDayward);
            this.Controls.Add(this.lblHomeBonSecours);
            this.Controls.Add(this.btnRecovery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.Label lblHomeBonSecours;
        private System.Windows.Forms.Button btnDayward;
    }
}