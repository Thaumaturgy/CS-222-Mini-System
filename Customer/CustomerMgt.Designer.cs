namespace Customer
{
    partial class CustomerMgt
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.tabPagePersonalDetails = new System.Windows.Forms.TabPage();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.lblPIN = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblTelNum = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblWorkingAddress = new System.Windows.Forms.Label();
            this.lblCivilStatus = new System.Windows.Forms.Label();
            this.lblJobDescription = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.tabPageAccounts = new System.Windows.Forms.TabPage();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtBdate = new System.Windows.Forms.TextBox();
            this.txtCivilStatus = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.tabPagePersonalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeight = 25;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 153);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(344, 482);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            this.dgvCustomers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellEnter);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 83);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(129, 64);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Viewing Customer: ";
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.tabPagePersonalDetails);
            this.tabCustomer.Controls.Add(this.tabPageAccounts);
            this.tabCustomer.Location = new System.Drawing.Point(362, 83);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(403, 552);
            this.tabCustomer.TabIndex = 5;
            // 
            // tabPagePersonalDetails
            // 
            this.tabPagePersonalDetails.Controls.Add(this.button2);
            this.tabPagePersonalDetails.Controls.Add(this.button1);
            this.tabPagePersonalDetails.Controls.Add(this.txtPIN);
            this.tabPagePersonalDetails.Controls.Add(this.txtBdate);
            this.tabPagePersonalDetails.Controls.Add(this.textBox10);
            this.tabPagePersonalDetails.Controls.Add(this.textBox9);
            this.tabPagePersonalDetails.Controls.Add(this.textBox8);
            this.tabPagePersonalDetails.Controls.Add(this.textBox7);
            this.tabPagePersonalDetails.Controls.Add(this.textBox1);
            this.tabPagePersonalDetails.Controls.Add(this.txtCivilStatus);
            this.tabPagePersonalDetails.Controls.Add(this.txtGender);
            this.tabPagePersonalDetails.Controls.Add(this.txtLN);
            this.tabPagePersonalDetails.Controls.Add(this.txtFN);
            this.tabPagePersonalDetails.Controls.Add(this.lblPIN);
            this.tabPagePersonalDetails.Controls.Add(this.lblFN);
            this.tabPagePersonalDetails.Controls.Add(this.lblPhoneNum);
            this.tabPagePersonalDetails.Controls.Add(this.lblLN);
            this.tabPagePersonalDetails.Controls.Add(this.lblTelNum);
            this.tabPagePersonalDetails.Controls.Add(this.lblGender);
            this.tabPagePersonalDetails.Controls.Add(this.lblWorkingAddress);
            this.tabPagePersonalDetails.Controls.Add(this.lblCivilStatus);
            this.tabPagePersonalDetails.Controls.Add(this.lblJobDescription);
            this.tabPagePersonalDetails.Controls.Add(this.lblBirthDate);
            this.tabPagePersonalDetails.Controls.Add(this.lblHomeAddress);
            this.tabPagePersonalDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPagePersonalDetails.Name = "tabPagePersonalDetails";
            this.tabPagePersonalDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalDetails.Size = new System.Drawing.Size(395, 523);
            this.tabPagePersonalDetails.TabIndex = 0;
            this.tabPagePersonalDetails.Text = "Personal Details";
            this.tabPagePersonalDetails.UseVisualStyleBackColor = true;
      //      this.tabPagePersonalDetails.Click += new System.EventHandler(this.tabPagePersonalDetails_Click);
            this.tabPagePersonalDetails.Enter += new System.EventHandler(this.tabPagePersonalDetails_Enter);
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(25, 45);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(100, 22);
            this.txtFN.TabIndex = 15;
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIN.Location = new System.Drawing.Point(295, 19);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(36, 20);
            this.lblPIN.TabIndex = 4;
            this.lblPIN.Text = "PIN";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(21, 19);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(92, 20);
            this.lblFN.TabIndex = 5;
            this.lblFN.Text = "First Name";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(211, 329);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(120, 20);
            this.lblPhoneNum.TabIndex = 6;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.Location = new System.Drawing.Point(137, 19);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(91, 20);
            this.lblLN.TabIndex = 7;
            this.lblLN.Text = "Last Name";
            // 
            // lblTelNum
            // 
            this.lblTelNum.AutoSize = true;
            this.lblTelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelNum.Location = new System.Drawing.Point(21, 329);
            this.lblTelNum.Name = "lblTelNum";
            this.lblTelNum.Size = new System.Drawing.Size(96, 20);
            this.lblTelNum.TabIndex = 8;
            this.lblTelNum.Text = "Tel Number";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(28, 84);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 20);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Gender";
            // 
            // lblWorkingAddress
            // 
            this.lblWorkingAddress.AutoSize = true;
            this.lblWorkingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingAddress.Location = new System.Drawing.Point(28, 266);
            this.lblWorkingAddress.Name = "lblWorkingAddress";
            this.lblWorkingAddress.Size = new System.Drawing.Size(137, 20);
            this.lblWorkingAddress.TabIndex = 10;
            this.lblWorkingAddress.Text = "Working Address";
            // 
            // lblCivilStatus
            // 
            this.lblCivilStatus.AutoSize = true;
            this.lblCivilStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCivilStatus.Location = new System.Drawing.Point(259, 84);
            this.lblCivilStatus.Name = "lblCivilStatus";
            this.lblCivilStatus.Size = new System.Drawing.Size(94, 20);
            this.lblCivilStatus.TabIndex = 11;
            this.lblCivilStatus.Text = "Civil Status";
            // 
            // lblJobDescription
            // 
            this.lblJobDescription.AutoSize = true;
            this.lblJobDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDescription.Location = new System.Drawing.Point(21, 205);
            this.lblJobDescription.Name = "lblJobDescription";
            this.lblJobDescription.Size = new System.Drawing.Size(127, 20);
            this.lblJobDescription.TabIndex = 12;
            this.lblJobDescription.Text = "Job Description";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(137, 84);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(86, 20);
            this.lblBirthDate.TabIndex = 13;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeAddress.Location = new System.Drawing.Point(21, 145);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(121, 20);
            this.lblHomeAddress.TabIndex = 14;
            this.lblHomeAddress.Text = "Home Address";
            // 
            // tabPageAccounts
            // 
            this.tabPageAccounts.Location = new System.Drawing.Point(4, 25);
            this.tabPageAccounts.Name = "tabPageAccounts";
            this.tabPageAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccounts.Size = new System.Drawing.Size(395, 523);
            this.tabPageAccounts.TabIndex = 2;
            this.tabPageAccounts.Text = "Accounts";
            this.tabPageAccounts.UseVisualStyleBackColor = true;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(141, 45);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(100, 22);
            this.txtLN.TabIndex = 15;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(25, 107);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 22);
            this.txtGender.TabIndex = 15;
            // 
            // txtBdate
            // 
            this.txtBdate.Location = new System.Drawing.Point(141, 107);
            this.txtBdate.Name = "txtBdate";
            this.txtBdate.Size = new System.Drawing.Size(100, 22);
            this.txtBdate.TabIndex = 15;
            // 
            // txtCivilStatus
            // 
            this.txtCivilStatus.Location = new System.Drawing.Point(256, 107);
            this.txtCivilStatus.Name = "txtCivilStatus";
            this.txtCivilStatus.Size = new System.Drawing.Size(123, 22);
            this.txtCivilStatus.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 22);
            this.textBox1.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(25, 228);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(306, 22);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(25, 289);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(306, 22);
            this.textBox8.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(25, 352);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(154, 22);
            this.textBox9.TabIndex = 15;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(215, 352);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(154, 22);
            this.textBox10.TabIndex = 15;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(299, 45);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(60, 22);
            this.txtPIN.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CustomerMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 647);
            this.Controls.Add(this.tabCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "CustomerMgt";
            this.Text = "CustomerMgt";
            this.Load += new System.EventHandler(this.CustomerMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.tabPagePersonalDetails.ResumeLayout(false);
            this.tabPagePersonalDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage tabPagePersonalDetails;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblTelNum;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblWorkingAddress;
        private System.Windows.Forms.Label lblCivilStatus;
        private System.Windows.Forms.Label lblJobDescription;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.TabPage tabPageAccounts;
        private System.Windows.Forms.TextBox txtBdate;
        private System.Windows.Forms.TextBox txtCivilStatus;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}