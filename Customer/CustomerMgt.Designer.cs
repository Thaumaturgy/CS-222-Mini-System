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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.txtBdate = new System.Windows.Forms.TextBox();
            this.txtPNum = new System.Windows.Forms.TextBox();
            this.txtTelNum = new System.Windows.Forms.TextBox();
            this.txtWorkingAdd = new System.Windows.Forms.TextBox();
            this.txtJobDesc = new System.Windows.Forms.TextBox();
            this.txtHomeAdd = new System.Windows.Forms.TextBox();
            this.txtCivilStatus = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
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
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panelBreakdown = new System.Windows.Forms.Panel();
            this.btnPaymentHistory = new System.Windows.Forms.Button();
            this.btnPayLoan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoneyLent = new System.Windows.Forms.Label();
            this.lblAmountRemaining = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblTotalLoan = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBalanceSummary = new System.Windows.Forms.Label();
            this.lblMoneyLentSummary = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.txtSearchLN = new System.Windows.Forms.TextBox();
            this.txtSearchFN = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetCustomerTable = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.tabPagePersonalDetails.SuspendLayout();
            this.tabPageAccounts.SuspendLayout();
            this.panelBreakdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeight = 25;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 121);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(363, 550);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            this.dgvCustomers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellEnter);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 679);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(129, 31);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
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
            this.tabCustomer.Location = new System.Drawing.Point(381, 121);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(471, 599);
            this.tabCustomer.TabIndex = 5;
            // 
            // tabPagePersonalDetails
            // 
            this.tabPagePersonalDetails.Controls.Add(this.button2);
            this.tabPagePersonalDetails.Controls.Add(this.button1);
            this.tabPagePersonalDetails.Controls.Add(this.txtPIN);
            this.tabPagePersonalDetails.Controls.Add(this.txtBdate);
            this.tabPagePersonalDetails.Controls.Add(this.txtPNum);
            this.tabPagePersonalDetails.Controls.Add(this.txtTelNum);
            this.tabPagePersonalDetails.Controls.Add(this.txtWorkingAdd);
            this.tabPagePersonalDetails.Controls.Add(this.txtJobDesc);
            this.tabPagePersonalDetails.Controls.Add(this.txtHomeAdd);
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
            this.tabPagePersonalDetails.Size = new System.Drawing.Size(463, 570);
            this.tabPagePersonalDetails.TabIndex = 0;
            this.tabPagePersonalDetails.Text = "Personal Details";
            this.tabPagePersonalDetails.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(299, 45);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.ReadOnly = true;
            this.txtPIN.Size = new System.Drawing.Size(60, 22);
            this.txtPIN.TabIndex = 16;
            // 
            // txtBdate
            // 
            this.txtBdate.Location = new System.Drawing.Point(141, 107);
            this.txtBdate.Name = "txtBdate";
            this.txtBdate.ReadOnly = true;
            this.txtBdate.Size = new System.Drawing.Size(100, 22);
            this.txtBdate.TabIndex = 15;
            // 
            // txtPNum
            // 
            this.txtPNum.Location = new System.Drawing.Point(215, 352);
            this.txtPNum.Name = "txtPNum";
            this.txtPNum.ReadOnly = true;
            this.txtPNum.Size = new System.Drawing.Size(154, 22);
            this.txtPNum.TabIndex = 15;
            // 
            // txtTelNum
            // 
            this.txtTelNum.Location = new System.Drawing.Point(25, 352);
            this.txtTelNum.Name = "txtTelNum";
            this.txtTelNum.ReadOnly = true;
            this.txtTelNum.Size = new System.Drawing.Size(154, 22);
            this.txtTelNum.TabIndex = 15;
            // 
            // txtWorkingAdd
            // 
            this.txtWorkingAdd.Location = new System.Drawing.Point(25, 289);
            this.txtWorkingAdd.Name = "txtWorkingAdd";
            this.txtWorkingAdd.ReadOnly = true;
            this.txtWorkingAdd.Size = new System.Drawing.Size(306, 22);
            this.txtWorkingAdd.TabIndex = 15;
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.Location = new System.Drawing.Point(25, 228);
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.ReadOnly = true;
            this.txtJobDesc.Size = new System.Drawing.Size(306, 22);
            this.txtJobDesc.TabIndex = 15;
            // 
            // txtHomeAdd
            // 
            this.txtHomeAdd.Location = new System.Drawing.Point(25, 168);
            this.txtHomeAdd.Name = "txtHomeAdd";
            this.txtHomeAdd.ReadOnly = true;
            this.txtHomeAdd.Size = new System.Drawing.Size(306, 22);
            this.txtHomeAdd.TabIndex = 15;
            // 
            // txtCivilStatus
            // 
            this.txtCivilStatus.Location = new System.Drawing.Point(256, 107);
            this.txtCivilStatus.Name = "txtCivilStatus";
            this.txtCivilStatus.ReadOnly = true;
            this.txtCivilStatus.Size = new System.Drawing.Size(123, 22);
            this.txtCivilStatus.TabIndex = 15;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(25, 107);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(100, 22);
            this.txtGender.TabIndex = 15;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(141, 45);
            this.txtLN.Name = "txtLN";
            this.txtLN.ReadOnly = true;
            this.txtLN.Size = new System.Drawing.Size(100, 22);
            this.txtLN.TabIndex = 15;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(25, 45);
            this.txtFN.Name = "txtFN";
            this.txtFN.ReadOnly = true;
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
            this.tabPageAccounts.Controls.Add(this.btnAddAccount);
            this.tabPageAccounts.Controls.Add(this.panelBreakdown);
            this.tabPageAccounts.Controls.Add(this.dgvAccounts);
            this.tabPageAccounts.Location = new System.Drawing.Point(4, 25);
            this.tabPageAccounts.Name = "tabPageAccounts";
            this.tabPageAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccounts.Size = new System.Drawing.Size(463, 570);
            this.tabPageAccounts.TabIndex = 2;
            this.tabPageAccounts.Text = "Accounts";
            this.tabPageAccounts.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 20);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(108, 33);
            this.btnAddAccount.TabIndex = 5;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // panelBreakdown
            // 
            this.panelBreakdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBreakdown.Controls.Add(this.btnPaymentHistory);
            this.panelBreakdown.Controls.Add(this.btnPayLoan);
            this.panelBreakdown.Controls.Add(this.label2);
            this.panelBreakdown.Controls.Add(this.lblMoneyLent);
            this.panelBreakdown.Controls.Add(this.lblAmountRemaining);
            this.panelBreakdown.Controls.Add(this.lblAmountPaid);
            this.panelBreakdown.Controls.Add(this.lblTotalLoan);
            this.panelBreakdown.Controls.Add(this.lblInterest);
            this.panelBreakdown.Location = new System.Drawing.Point(7, 374);
            this.panelBreakdown.Name = "panelBreakdown";
            this.panelBreakdown.Size = new System.Drawing.Size(450, 190);
            this.panelBreakdown.TabIndex = 4;
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.Location = new System.Drawing.Point(325, 90);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new System.Drawing.Size(97, 43);
            this.btnPaymentHistory.TabIndex = 4;
            this.btnPaymentHistory.Text = "Payment History";
            this.btnPaymentHistory.UseVisualStyleBackColor = true;
            // 
            // btnPayLoan
            // 
            this.btnPayLoan.Location = new System.Drawing.Point(325, 41);
            this.btnPayLoan.Name = "btnPayLoan";
            this.btnPayLoan.Size = new System.Drawing.Size(97, 43);
            this.btnPayLoan.TabIndex = 4;
            this.btnPayLoan.Text = "Pay Loan";
            this.btnPayLoan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loan Breakdown";
            // 
            // lblMoneyLent
            // 
            this.lblMoneyLent.AutoSize = true;
            this.lblMoneyLent.Location = new System.Drawing.Point(60, 41);
            this.lblMoneyLent.Name = "lblMoneyLent";
            this.lblMoneyLent.Size = new System.Drawing.Size(86, 17);
            this.lblMoneyLent.TabIndex = 0;
            this.lblMoneyLent.Text = "Money Lent:";
            // 
            // lblAmountRemaining
            // 
            this.lblAmountRemaining.AutoSize = true;
            this.lblAmountRemaining.Location = new System.Drawing.Point(62, 133);
            this.lblAmountRemaining.Name = "lblAmountRemaining";
            this.lblAmountRemaining.Size = new System.Drawing.Size(135, 17);
            this.lblAmountRemaining.TabIndex = 2;
            this.lblAmountRemaining.Text = "Amount Remaining: ";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(62, 110);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(96, 17);
            this.lblAmountPaid.TabIndex = 2;
            this.lblAmountPaid.Text = "Amount Paid: ";
            // 
            // lblTotalLoan
            // 
            this.lblTotalLoan.AutoSize = true;
            this.lblTotalLoan.Location = new System.Drawing.Point(62, 87);
            this.lblTotalLoan.Name = "lblTotalLoan";
            this.lblTotalLoan.Size = new System.Drawing.Size(84, 17);
            this.lblTotalLoan.TabIndex = 2;
            this.lblTotalLoan.Text = "Total Loan: ";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(62, 64);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(59, 17);
            this.lblInterest.TabIndex = 1;
            this.lblInterest.Text = "Interest:";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            this.dgvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(7, 69);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(449, 299);
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBalanceSummary);
            this.groupBox1.Controls.Add(this.lblMoneyLentSummary);
            this.groupBox1.Location = new System.Drawing.Point(381, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Accounts Summary";
            // 
            // lblBalanceSummary
            // 
            this.lblBalanceSummary.AutoSize = true;
            this.lblBalanceSummary.Location = new System.Drawing.Point(277, 24);
            this.lblBalanceSummary.Name = "lblBalanceSummary";
            this.lblBalanceSummary.Size = new System.Drawing.Size(59, 17);
            this.lblBalanceSummary.TabIndex = 0;
            this.lblBalanceSummary.Text = "Balance";
            // 
            // lblMoneyLentSummary
            // 
            this.lblMoneyLentSummary.AutoSize = true;
            this.lblMoneyLentSummary.Location = new System.Drawing.Point(11, 24);
            this.lblMoneyLentSummary.Name = "lblMoneyLentSummary";
            this.lblMoneyLentSummary.Size = new System.Drawing.Size(118, 17);
            this.lblMoneyLentSummary.TabIndex = 0;
            this.lblMoneyLentSummary.Text = "Total Money Lent";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rbtnInactive);
            this.panel1.Controls.Add(this.rbtnActive);
            this.panel1.Controls.Add(this.txtSearchLN);
            this.panel1.Controls.Add(this.txtSearchFN);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(16, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 58);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status";
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(204, 32);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(77, 21);
            this.rbtnInactive.TabIndex = 12;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Checked = true;
            this.rbtnActive.Location = new System.Drawing.Point(131, 31);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(67, 21);
            this.rbtnActive.TabIndex = 12;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // txtSearchLN
            // 
            this.txtSearchLN.Location = new System.Drawing.Point(3, 31);
            this.txtSearchLN.Name = "txtSearchLN";
            this.txtSearchLN.Size = new System.Drawing.Size(122, 22);
            this.txtSearchLN.TabIndex = 11;
            this.txtSearchLN.Text = "LN";
            // 
            // txtSearchFN
            // 
            this.txtSearchFN.Location = new System.Drawing.Point(3, 3);
            this.txtSearchFN.Name = "txtSearchFN";
            this.txtSearchFN.Size = new System.Drawing.Size(122, 22);
            this.txtSearchFN.TabIndex = 10;
            this.txtSearchFN.Text = "FN";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(295, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 50);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnResetCustomerTable
            // 
            this.btnResetCustomerTable.Location = new System.Drawing.Point(147, 680);
            this.btnResetCustomerTable.Name = "btnResetCustomerTable";
            this.btnResetCustomerTable.Size = new System.Drawing.Size(225, 31);
            this.btnResetCustomerTable.TabIndex = 2;
            this.btnResetCustomerTable.Text = "Reset Customer Table";
            this.btnResetCustomerTable.UseVisualStyleBackColor = true;
            this.btnResetCustomerTable.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(311, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(61, 50);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CustomerMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 723);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetCustomerTable);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "CustomerMgt";
            this.Text = "CustomerMgt";
            this.Load += new System.EventHandler(this.CustomerMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.tabPagePersonalDetails.ResumeLayout(false);
            this.tabPagePersonalDetails.PerformLayout();
            this.tabPageAccounts.ResumeLayout(false);
            this.panelBreakdown.ResumeLayout(false);
            this.panelBreakdown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPNum;
        private System.Windows.Forms.TextBox txtTelNum;
        private System.Windows.Forms.TextBox txtWorkingAdd;
        private System.Windows.Forms.TextBox txtJobDesc;
        private System.Windows.Forms.TextBox txtHomeAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Panel panelBreakdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMoneyLent;
        private System.Windows.Forms.Label lblAmountRemaining;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblTotalLoan;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnPayLoan;
        private System.Windows.Forms.Button btnPaymentHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBalanceSummary;
        private System.Windows.Forms.Label lblMoneyLentSummary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.TextBox txtSearchLN;
        private System.Windows.Forms.TextBox txtSearchFN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnResetCustomerTable;
        private System.Windows.Forms.Button btnReset;
    }
}