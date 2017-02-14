namespace Customer
{
    partial class AddAccount
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
            this.txtMoneyLent = new System.Windows.Forms.TextBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMoneyLent
            // 
            this.txtMoneyLent.Location = new System.Drawing.Point(52, 56);
            this.txtMoneyLent.Name = "txtMoneyLent";
            this.txtMoneyLent.Size = new System.Drawing.Size(100, 22);
            this.txtMoneyLent.TabIndex = 0;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.CustomFormat = "MM/dd/yyyy";
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntryDate.Location = new System.Drawing.Point(52, 85);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEntryDate.TabIndex = 1;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(52, 113);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 22);
            this.txtInterest.TabIndex = 0;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 560);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtMoneyLent);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoneyLent;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.TextBox txtInterest;
    }
}