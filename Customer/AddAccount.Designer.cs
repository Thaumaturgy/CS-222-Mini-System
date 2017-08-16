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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMoneyLent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn1Month = new System.Windows.Forms.RadioButton();
            this.rbtn3Months = new System.Windows.Forms.RadioButton();
            this.rbtn6Months = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMoneyLent = new System.Windows.Forms.Label();
            this.lblTotalLoan = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMoneyLent
            // 
            this.txtMoneyLent.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyLent.ForeColor = System.Drawing.Color.Indigo;
            this.txtMoneyLent.Location = new System.Drawing.Point(88, 43);
            this.txtMoneyLent.MaxLength = 9;
            this.txtMoneyLent.Name = "txtMoneyLent";
            this.txtMoneyLent.Size = new System.Drawing.Size(185, 31);
            this.txtMoneyLent.TabIndex = 0;
            this.txtMoneyLent.Text = "0.00";
            this.txtMoneyLent.TextChanged += new System.EventHandler(this.txtMoneyLent_TextChanged);
            this.txtMoneyLent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMoneyLent_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan Amount";
            // 
            // rbtn1Month
            // 
            this.rbtn1Month.AutoSize = true;
            this.rbtn1Month.Checked = true;
            this.rbtn1Month.Location = new System.Drawing.Point(4, 10);
            this.rbtn1Month.Name = "rbtn1Month";
            this.rbtn1Month.Size = new System.Drawing.Size(81, 22);
            this.rbtn1Month.TabIndex = 1;
            this.rbtn1Month.TabStop = true;
            this.rbtn1Month.Text = "1 Month";
            this.rbtn1Month.UseVisualStyleBackColor = true;
            this.rbtn1Month.CheckedChanged += new System.EventHandler(this.rbtn1Month_CheckedChanged);
            // 
            // rbtn3Months
            // 
            this.rbtn3Months.AutoSize = true;
            this.rbtn3Months.Location = new System.Drawing.Point(91, 10);
            this.rbtn3Months.Name = "rbtn3Months";
            this.rbtn3Months.Size = new System.Drawing.Size(87, 22);
            this.rbtn3Months.TabIndex = 2;
            this.rbtn3Months.Text = "3 Months";
            this.rbtn3Months.UseVisualStyleBackColor = true;
            this.rbtn3Months.CheckedChanged += new System.EventHandler(this.rbtn3Months_CheckedChanged);
            // 
            // rbtn6Months
            // 
            this.rbtn6Months.AutoSize = true;
            this.rbtn6Months.Location = new System.Drawing.Point(186, 10);
            this.rbtn6Months.Name = "rbtn6Months";
            this.rbtn6Months.Size = new System.Drawing.Size(87, 22);
            this.rbtn6Months.TabIndex = 3;
            this.rbtn6Months.Text = "6 Months";
            this.rbtn6Months.UseVisualStyleBackColor = true;
            this.rbtn6Months.CheckedChanged += new System.EventHandler(this.rbtn6Months_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn1Month);
            this.panel1.Controls.Add(this.rbtn6Months);
            this.panel1.Controls.Add(this.rbtn3Months);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(46, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 46);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loan Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loan Breakdown";
            // 
            // lblMoneyLent
            // 
            this.lblMoneyLent.AutoSize = true;
            this.lblMoneyLent.Location = new System.Drawing.Point(56, 58);
            this.lblMoneyLent.Name = "lblMoneyLent";
            this.lblMoneyLent.Size = new System.Drawing.Size(88, 18);
            this.lblMoneyLent.TabIndex = 7;
            this.lblMoneyLent.Text = "Money Lent:";
            // 
            // lblTotalLoan
            // 
            this.lblTotalLoan.AutoSize = true;
            this.lblTotalLoan.Location = new System.Drawing.Point(58, 110);
            this.lblTotalLoan.Name = "lblTotalLoan";
            this.lblTotalLoan.Size = new System.Drawing.Size(81, 18);
            this.lblTotalLoan.TabIndex = 11;
            this.lblTotalLoan.Text = "Total Loan: ";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(58, 84);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(64, 18);
            this.lblInterest.TabIndex = 8;
            this.lblInterest.Text = "Interest:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblInterest);
            this.panel2.Controls.Add(this.lblMoneyLent);
            this.panel2.Controls.Add(this.lblTotalLoan);
            this.panel2.Location = new System.Drawing.Point(46, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 155);
            this.panel2.TabIndex = 13;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddAccount.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAddAccount.Enabled = false;
            this.btnAddAccount.Location = new System.Drawing.Point(50, 559);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(106, 48);
            this.btnAddAccount.TabIndex = 7;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.Location = new System.Drawing.Point(209, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.ForeColor = System.Drawing.Color.Indigo;
            this.txtCardNumber.Location = new System.Drawing.Point(134, 334);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(102, 23);
            this.txtCardNumber.TabIndex = 4;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // txtBank
            // 
            this.txtBank.ForeColor = System.Drawing.Color.Indigo;
            this.txtBank.Location = new System.Drawing.Point(134, 365);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(102, 23);
            this.txtBank.TabIndex = 5;
            this.txtBank.TextChanged += new System.EventHandler(this.txtBank_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Card Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Bank";
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddCard.Enabled = false;
            this.btnAddCard.Location = new System.Drawing.Point(241, 334);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(74, 56);
            this.btnAddCard.TabIndex = 6;
            this.btnAddCard.Text = "Add Card";
            this.btnAddCard.UseVisualStyleBackColor = false;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // dgvCards
            // 
            this.dgvCards.AllowUserToAddRows = false;
            this.dgvCards.AllowUserToDeleteRows = false;
            this.dgvCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCards.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCards.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCards.Location = new System.Drawing.Point(46, 408);
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.ReadOnly = true;
            this.dgvCards.RowHeadersVisible = false;
            this.dgvCards.RowTemplate.Height = 24;
            this.dgvCards.Size = new System.Drawing.Size(281, 145);
            this.dgvCards.TabIndex = 19;
            this.dgvCards.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Card Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bank";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(366, 619);
            this.Controls.Add(this.dgvCards);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoneyLent);
            this.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddAccount";
            this.Opacity = 0.9D;
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoneyLent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn1Month;
        private System.Windows.Forms.RadioButton rbtn3Months;
        private System.Windows.Forms.RadioButton rbtn6Months;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMoneyLent;
        private System.Windows.Forms.Label lblTotalLoan;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.DataGridView dgvCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}