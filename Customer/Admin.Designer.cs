namespace Customer
{
    partial class Admin
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
            this.btnMgtCustomers = new System.Windows.Forms.Button();
            this.btnMgtAccounts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMgtCustomers
            // 
            this.btnMgtCustomers.Location = new System.Drawing.Point(80, 52);
            this.btnMgtCustomers.Name = "btnMgtCustomers";
            this.btnMgtCustomers.Size = new System.Drawing.Size(201, 43);
            this.btnMgtCustomers.TabIndex = 0;
            this.btnMgtCustomers.Text = "Manage Customers";
            this.btnMgtCustomers.UseVisualStyleBackColor = true;
            this.btnMgtCustomers.Click += new System.EventHandler(this.btnMgtCustomers_Click);
            // 
            // btnMgtAccounts
            // 
            this.btnMgtAccounts.Location = new System.Drawing.Point(80, 101);
            this.btnMgtAccounts.Name = "btnMgtAccounts";
            this.btnMgtAccounts.Size = new System.Drawing.Size(201, 43);
            this.btnMgtAccounts.TabIndex = 0;
            this.btnMgtAccounts.Text = "Manage Accounts";
            this.btnMgtAccounts.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 224);
            this.Controls.Add(this.btnMgtAccounts);
            this.Controls.Add(this.btnMgtCustomers);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMgtCustomers;
        private System.Windows.Forms.Button btnMgtAccounts;
    }
}