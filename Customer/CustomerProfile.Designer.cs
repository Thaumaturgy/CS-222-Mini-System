namespace Customer
{
    partial class CustomerProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.grpboxAccountDetails = new System.Windows.Forms.GroupBox();
            this.panelBreakdown = new System.Windows.Forms.Panel();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoneyLent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmountRemaining = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblTotalLoan = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.grpboxAccountDetails.SuspendLayout();
            this.panelBreakdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(211, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(128, 36);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.White;
            this.lblAccount.Location = new System.Drawing.Point(12, 62);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(143, 23);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "Active Accounts: ";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeColumns = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounts.GridColor = System.Drawing.Color.SlateBlue;
            this.dgvAccounts.Location = new System.Drawing.Point(12, 96);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowTemplate.Height = 35;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(560, 476);
            this.dgvAccounts.TabIndex = 2;
            this.dgvAccounts.TabStop = false;
            this.dgvAccounts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellEnter);
            // 
            // grpboxAccountDetails
            // 
            this.grpboxAccountDetails.Controls.Add(this.panelBreakdown);
            this.grpboxAccountDetails.Controls.Add(this.lblInterestRate);
            this.grpboxAccountDetails.Controls.Add(this.label3);
            this.grpboxAccountDetails.Controls.Add(this.lblStatus);
            this.grpboxAccountDetails.Controls.Add(this.lblEntryDate);
            this.grpboxAccountDetails.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxAccountDetails.ForeColor = System.Drawing.Color.White;
            this.grpboxAccountDetails.Location = new System.Drawing.Point(578, 12);
            this.grpboxAccountDetails.Name = "grpboxAccountDetails";
            this.grpboxAccountDetails.Size = new System.Drawing.Size(370, 560);
            this.grpboxAccountDetails.TabIndex = 3;
            this.grpboxAccountDetails.TabStop = false;
            this.grpboxAccountDetails.Text = "Account Details";
            // 
            // panelBreakdown
            // 
            this.panelBreakdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBreakdown.Controls.Add(this.dgvPaymentHistory);
            this.panelBreakdown.Controls.Add(this.label2);
            this.panelBreakdown.Controls.Add(this.lblMoneyLent);
            this.panelBreakdown.Controls.Add(this.label4);
            this.panelBreakdown.Controls.Add(this.lblAmountRemaining);
            this.panelBreakdown.Controls.Add(this.lblAmountPaid);
            this.panelBreakdown.Controls.Add(this.lblTotalLoan);
            this.panelBreakdown.Controls.Add(this.lblInterest);
            this.panelBreakdown.Location = new System.Drawing.Point(6, 174);
            this.panelBreakdown.Name = "panelBreakdown";
            this.panelBreakdown.Size = new System.Drawing.Size(358, 380);
            this.panelBreakdown.TabIndex = 3;
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.AllowUserToAddRows = false;
            this.dgvPaymentHistory.AllowUserToDeleteRows = false;
            this.dgvPaymentHistory.AllowUserToResizeRows = false;
            this.dgvPaymentHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentHistory.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dgvPaymentHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentHistory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaymentHistory.GridColor = System.Drawing.Color.SlateBlue;
            this.dgvPaymentHistory.Location = new System.Drawing.Point(3, 209);
            this.dgvPaymentHistory.MultiSelect = false;
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.ReadOnly = true;
            this.dgvPaymentHistory.RowHeadersVisible = false;
            this.dgvPaymentHistory.RowTemplate.Height = 24;
            this.dgvPaymentHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentHistory.Size = new System.Drawing.Size(350, 166);
            this.dgvPaymentHistory.TabIndex = 4;
            this.dgvPaymentHistory.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loan Breakdown";
            // 
            // lblMoneyLent
            // 
            this.lblMoneyLent.AutoSize = true;
            this.lblMoneyLent.Location = new System.Drawing.Point(73, 42);
            this.lblMoneyLent.Name = "lblMoneyLent";
            this.lblMoneyLent.Size = new System.Drawing.Size(102, 23);
            this.lblMoneyLent.TabIndex = 0;
            this.lblMoneyLent.Text = "Money Lent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Payment History";
            // 
            // lblAmountRemaining
            // 
            this.lblAmountRemaining.AutoSize = true;
            this.lblAmountRemaining.Location = new System.Drawing.Point(75, 134);
            this.lblAmountRemaining.Name = "lblAmountRemaining";
            this.lblAmountRemaining.Size = new System.Drawing.Size(163, 23);
            this.lblAmountRemaining.TabIndex = 2;
            this.lblAmountRemaining.Text = "Amount Remaining: ";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(75, 111);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(116, 23);
            this.lblAmountPaid.TabIndex = 2;
            this.lblAmountPaid.Text = "Amount Paid: ";
            // 
            // lblTotalLoan
            // 
            this.lblTotalLoan.AutoSize = true;
            this.lblTotalLoan.Location = new System.Drawing.Point(75, 88);
            this.lblTotalLoan.Name = "lblTotalLoan";
            this.lblTotalLoan.Size = new System.Drawing.Size(100, 23);
            this.lblTotalLoan.TabIndex = 2;
            this.lblTotalLoan.Text = "Total Loan: ";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(75, 65);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(77, 23);
            this.lblInterest.TabIndex = 1;
            this.lblInterest.Text = "Interest:";
            this.lblInterest.Click += new System.EventHandler(this.lblRemainingLoan_Click);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(6, 78);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(111, 23);
            this.lblInterestRate.TabIndex = 0;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStatus.Location = new System.Drawing.Point(80, 32);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 23);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "status";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Location = new System.Drawing.Point(6, 55);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(90, 23);
            this.lblEntryDate.TabIndex = 0;
            this.lblEntryDate.Text = "Entry Date";
            // 
            // CustomerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(960, 584);
            this.Controls.Add(this.grpboxAccountDetails);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblWelcome);
            this.KeyPreview = true;
            this.Name = "CustomerProfile";
            this.Text = "Customer Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerProfile_FormClosing);
            this.Load += new System.EventHandler(this.CustomerProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.grpboxAccountDetails.ResumeLayout(false);
            this.grpboxAccountDetails.PerformLayout();
            this.panelBreakdown.ResumeLayout(false);
            this.panelBreakdown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.GroupBox grpboxAccountDetails;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblMoneyLent;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblTotalLoan;
        private System.Windows.Forms.Panel panelBreakdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmountRemaining;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}