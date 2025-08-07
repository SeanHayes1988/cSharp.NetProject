namespace BonsApp
{
    partial class MainMenu1
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
            this.lblName1 = new System.Windows.Forms.Label();
            this.txtNameB = new System.Windows.Forms.TextBox();
            this.txtNameA = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(291, 18);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(40, 13);
            this.lblName1.TabIndex = 0;
            this.lblName1.Text = "Detail: ";
            // 
            // txtNameB
            // 
            this.txtNameB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNameB.Location = new System.Drawing.Point(337, 18);
            this.txtNameB.Multiline = true;
            this.txtNameB.Name = "txtNameB";
            this.txtNameB.ReadOnly = true;
            this.txtNameB.Size = new System.Drawing.Size(204, 205);
            this.txtNameB.TabIndex = 1;
            // 
            // txtNameA
            // 
            this.txtNameA.Location = new System.Drawing.Point(12, 18);
            this.txtNameA.Multiline = true;
            this.txtNameA.Name = "txtNameA";
            this.txtNameA.Size = new System.Drawing.Size(211, 208);
            this.txtNameA.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(148, 232);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MainMenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtNameA);
            this.Controls.Add(this.txtNameB);
            this.Controls.Add(this.lblName1);
            this.Name = "MainMenu1";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.TextBox txtNameB;
        private System.Windows.Forms.TextBox txtNameA;
        private System.Windows.Forms.Button btnSend;
    }
}