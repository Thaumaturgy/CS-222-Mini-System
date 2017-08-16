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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.tabPagePersonalDetails = new System.Windows.Forms.TabPage();
            this.checkBoxEditMode = new System.Windows.Forms.CheckBox();
            this.btnResetEdit = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.txtPNum = new System.Windows.Forms.TextBox();
            this.txtTelNum = new System.Windows.Forms.TextBox();
            this.txtWorkingAdd = new System.Windows.Forms.TextBox();
            this.txtJobDesc = new System.Windows.Forms.TextBox();
            this.txtHomeAdd = new System.Windows.Forms.TextBox();
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
            this.cBoxGender = new System.Windows.Forms.ComboBox();
            this.dtpBdate = new System.Windows.Forms.DateTimePicker();
            this.cBoxCivilStatus = new System.Windows.Forms.ComboBox();
            this.txtBoxDTP = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtCivilStatus = new System.Windows.Forms.TextBox();
            this.tabPageAccounts = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panelBreakdown = new System.Windows.Forms.Panel();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
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
            this.btnReset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.tabPagePersonalDetails.SuspendLayout();
            this.tabPageAccounts.SuspendLayout();
            this.panelBreakdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dgvCustomers.ColumnHeadersHeight = 25;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.GridColor = System.Drawing.Color.White;
            this.dgvCustomers.Location = new System.Drawing.Point(16, 143);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(473, 361);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.TabStop = false;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            this.dgvCustomers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellEnter);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCustomer.FlatAppearance.BorderSize = 2;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(16, 106);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(111, 31);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.TabStop = false;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
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
            this.tabCustomer.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCustomer.Location = new System.Drawing.Point(495, 12);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(492, 571);
            this.tabCustomer.TabIndex = 5;
            // 
            // tabPagePersonalDetails
            // 
            this.tabPagePersonalDetails.BackColor = System.Drawing.Color.SlateBlue;
            this.tabPagePersonalDetails.Controls.Add(this.checkBoxEditMode);
            this.tabPagePersonalDetails.Controls.Add(this.btnResetEdit);
            this.tabPagePersonalDetails.Controls.Add(this.btnApply);
            this.tabPagePersonalDetails.Controls.Add(this.txtPIN);
            this.tabPagePersonalDetails.Controls.Add(this.txtPNum);
            this.tabPagePersonalDetails.Controls.Add(this.txtTelNum);
            this.tabPagePersonalDetails.Controls.Add(this.txtWorkingAdd);
            this.tabPagePersonalDetails.Controls.Add(this.txtJobDesc);
            this.tabPagePersonalDetails.Controls.Add(this.txtHomeAdd);
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
            this.tabPagePersonalDetails.Controls.Add(this.cBoxGender);
            this.tabPagePersonalDetails.Controls.Add(this.dtpBdate);
            this.tabPagePersonalDetails.Controls.Add(this.cBoxCivilStatus);
            this.tabPagePersonalDetails.Controls.Add(this.txtBoxDTP);
            this.tabPagePersonalDetails.Controls.Add(this.txtGender);
            this.tabPagePersonalDetails.Controls.Add(this.txtCivilStatus);
            this.tabPagePersonalDetails.ForeColor = System.Drawing.Color.White;
            this.tabPagePersonalDetails.Location = new System.Drawing.Point(4, 29);
            this.tabPagePersonalDetails.Name = "tabPagePersonalDetails";
            this.tabPagePersonalDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalDetails.Size = new System.Drawing.Size(484, 538);
            this.tabPagePersonalDetails.TabIndex = 0;
            this.tabPagePersonalDetails.Text = "Personal Details";
            // 
            // checkBoxEditMode
            // 
            this.checkBoxEditMode.AutoSize = true;
            this.checkBoxEditMode.FlatAppearance.BorderSize = 2;
            this.checkBoxEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxEditMode.Location = new System.Drawing.Point(25, 460);
            this.checkBoxEditMode.Name = "checkBoxEditMode";
            this.checkBoxEditMode.Size = new System.Drawing.Size(93, 24);
            this.checkBoxEditMode.TabIndex = 21;
            this.checkBoxEditMode.TabStop = false;
            this.checkBoxEditMode.Text = "Edit Mode";
            this.checkBoxEditMode.UseVisualStyleBackColor = true;
            this.checkBoxEditMode.CheckedChanged += new System.EventHandler(this.checkBoxEditMode_CheckedChanged);
            // 
            // btnResetEdit
            // 
            this.btnResetEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnResetEdit.Enabled = false;
            this.btnResetEdit.FlatAppearance.BorderSize = 2;
            this.btnResetEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnResetEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnResetEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetEdit.ForeColor = System.Drawing.Color.White;
            this.btnResetEdit.Location = new System.Drawing.Point(116, 401);
            this.btnResetEdit.Name = "btnResetEdit";
            this.btnResetEdit.Size = new System.Drawing.Size(85, 42);
            this.btnResetEdit.TabIndex = 17;
            this.btnResetEdit.TabStop = false;
            this.btnResetEdit.Text = "Reset";
            this.btnResetEdit.UseVisualStyleBackColor = false;
            this.btnResetEdit.Click += new System.EventHandler(this.btnResetEdit_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnApply.Enabled = false;
            this.btnApply.FlatAppearance.BorderSize = 2;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(25, 401);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(85, 42);
            this.btnApply.TabIndex = 17;
            this.btnApply.TabStop = false;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIN.ForeColor = System.Drawing.Color.White;
            this.txtPIN.Location = new System.Drawing.Point(369, 45);
            this.txtPIN.MaxLength = 4;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.ReadOnly = true;
            this.txtPIN.Size = new System.Drawing.Size(60, 25);
            this.txtPIN.TabIndex = 17;
            this.txtPIN.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            this.txtPIN.Enter += new System.EventHandler(this.txtBoxes_Enter);
            this.txtPIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPIN_KeyDown);
            this.txtPIN.Leave += new System.EventHandler(this.txtBoxes_Leave);
            // 
            // txtPNum
            // 
            this.txtPNum.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNum.ForeColor = System.Drawing.Color.White;
            this.txtPNum.Location = new System.Drawing.Point(215, 352);
            this.txtPNum.MaxLength = 11;
            this.txtPNum.Name = "txtPNum";
            this.txtPNum.ReadOnly = true;
            this.txtPNum.Size = new System.Drawing.Size(154, 25);
            this.txtPNum.TabIndex = 25;
            this.txtPNum.TextChanged += new System.EventHandler(this.txtPNum_TextChanged);
            this.txtPNum.Enter += new System.EventHandler(this.txtBoxes_Enter);
            this.txtPNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelNum_KeyDown_1);
            this.txtPNum.Leave += new System.EventHandler(this.txtBoxes_Leave);
            // 
            // txtTelNum
            // 
            this.txtTelNum.BackColor = System.Drawing.Color.SteelBlue;
            this.txtTelNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelNum.ForeColor = System.Drawing.Color.White;
            this.txtTelNum.Location = new System.Drawing.Point(25, 352);
            this.txtTelNum.MaxLength = 7;
            this.txtTelNum.Name = "txtTelNum";
            this.txtTelNum.ReadOnly = true;
            this.txtTelNum.Size = new System.Drawing.Size(154, 25);
            this.txtTelNum.TabIndex = 24;
            this.txtTelNum.TextChanged += new System.EventHandler(this.txtTelNum_TextChanged);
            this.txtTelNum.Enter += new System.EventHandler(this.txtBoxes_Enter);
            this.txtTelNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelNum_KeyDown_1);
            this.txtTelNum.Leave += new System.EventHandler(this.txtBoxes_Leave);
            // 
            // txtWorkingAdd
            // 
            this.txtWorkingAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.txtWorkingAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWorkingAdd.ForeColor = System.Drawing.Color.White;
            this.txtWorkingAdd.Location = new System.Drawing.Point(25, 289);
            this.txtWorkingAdd.Name = "txtWorkingAdd";
            this.txtWorkingAdd.ReadOnly = true;
            this.txtWorkingAdd.Size = new System.Drawing.Size(306, 25);
            this.txtWorkingAdd.TabIndex = 23;
            this.txtWorkingAdd.TextChanged += new System.EventHandler(this.txtWorkingAdd_TextChanged);
            this.txtWorkingAdd.Enter += new System.EventHandler(this.txtBoxes_Enter);
            this.txtWorkingAdd.Leave += new System.EventHandler(this.txtBoxes_Leave);
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.BackColor = System.Drawing.Color.SteelBlue;
            this.txtJobDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobDesc.ForeColor = System.Drawing.Color.White;
            this.txtJobDesc.Location = new System.Drawing.Point(25, 228);
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.ReadOnly = true;
            this.txtJobDesc.Size = new System.Drawing.Size(306, 25);
            this.txtJobDesc.TabIndex = 22;
            this.txtJobDesc.TextChanged += new System.EventHandler(this.txtJobDesc_TextChanged);
            this.txtJobDesc.Enter += new System.EventHandler(this.txtBoxes_Enter);
            this.txtJobDesc.Leave += new System.EventHandler(this.txtBoxes_Leave);
            // 
            // txtHomeAdd
            // 
            this.txtHomeAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.txtHomeAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHomeAdd.ForeColor = System.Drawing.Color.White;
            this.txtHomeAdd.Location = new System.Drawing.Point(25, 168);
            this.txtHomeAdd.Name = "txtHomeAdd";
            this.txtHomeAdd.ReadOnly = true;
            this.txtHomeAdd.Size = new System.Drawing.Size(306, 25);
            this.txtHomeAdd.TabIndex = 21;
            this.txtHomeAdd.TextChanged += new System.EventHandler(this.txtHomeAdd_TextChanged);
            this.txtHomeAdd.Enter += new System.EventHandler(this.txtBoxes_Enter);
            this.txtHomeAdd.Leave += new System.EventHandler(this.txtBoxes_Leave);
            // 
            // txtLN
            // 
            this.txtLN.BackColor = System.Drawing.Color.SteelBlue;
            this.txtLN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLN.ForeColor = System.Drawing.Color.White;
            this.txtLN.Location = new System.Drawing.Point(188, 45);
            this.txtLN.Name = "txtLN";
            this.txtLN.ReadOnly = true;
            this.txtLN.Size = new System.Drawing.Size(140, 25);
            this.txtLN.TabIndex = 16;
            this.txtLN.TextChanged += new System.EventHandler(this.txtLN_TextChanged);
            this.txtLN.Enter += new System.EventHandler(this.txtBoxes_Enter);
            this.txtLN.Leave += new System.EventHandler(this.txtBoxes_Leave);
            // 
            // txtFN
            // 
            this.txtFN.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFN.ForeColor = System.Drawing.Color.White;
            this.txtFN.Location = new System.Drawing.Point(25, 45);
            this.txtFN.Name = "txtFN";
            this.txtFN.ReadOnly = true;
            this.txtFN.Size = new System.Drawing.Size(140, 25);
            this.txtFN.TabIndex = 15;
            this.txtFN.TextChanged += new System.EventHandler(this.txtFN_TextChanged);
            this.txtFN.Enter += new System.EventHandler(this.txtBoxes_Enter);
            this.txtFN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFN_KeyDown);
            this.txtFN.Leave += new System.EventHandler(this.txtBoxes_Leave);
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIN.Location = new System.Drawing.Point(365, 19);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(36, 20);
            this.lblPIN.TabIndex = 4;
            this.lblPIN.Text = "PIN";
            this.lblPIN.Click += new System.EventHandler(this.lblPIN_Click);
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
            this.lblLN.Location = new System.Drawing.Point(184, 19);
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
            this.lblCivilStatus.Location = new System.Drawing.Point(304, 81);
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
            this.lblBirthDate.Location = new System.Drawing.Point(161, 88);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(86, 20);
            this.lblBirthDate.TabIndex = 13;
            this.lblBirthDate.Text = "Birth Date";
            this.lblBirthDate.Click += new System.EventHandler(this.lblBirthDate_Click);
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
            // cBoxGender
            // 
            this.cBoxGender.BackColor = System.Drawing.Color.SteelBlue;
            this.cBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxGender.ForeColor = System.Drawing.Color.White;
            this.cBoxGender.FormattingEnabled = true;
            this.cBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cBoxGender.Location = new System.Drawing.Point(25, 106);
            this.cBoxGender.Name = "cBoxGender";
            this.cBoxGender.Size = new System.Drawing.Size(100, 28);
            this.cBoxGender.TabIndex = 18;
            this.cBoxGender.Visible = false;
            this.cBoxGender.SelectedIndexChanged += new System.EventHandler(this.cBoxGender_SelectedIndexChanged);
            this.cBoxGender.Enter += new System.EventHandler(this.cBoxes_Enter);
            this.cBoxGender.Leave += new System.EventHandler(this.cBoxCivilStatus_Leave);
            // 
            // dtpBdate
            // 
            this.dtpBdate.CustomFormat = "MM/dd/yyyy";
            this.dtpBdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBdate.Location = new System.Drawing.Point(165, 111);
            this.dtpBdate.Name = "dtpBdate";
            this.dtpBdate.Size = new System.Drawing.Size(122, 25);
            this.dtpBdate.TabIndex = 19;
            this.dtpBdate.Value = new System.DateTime(2017, 2, 15, 0, 0, 0, 0);
            this.dtpBdate.Visible = false;
            this.dtpBdate.ValueChanged += new System.EventHandler(this.dtpBdate_ValueChanged);
            // 
            // cBoxCivilStatus
            // 
            this.cBoxCivilStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.cBoxCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCivilStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxCivilStatus.ForeColor = System.Drawing.Color.White;
            this.cBoxCivilStatus.FormattingEnabled = true;
            this.cBoxCivilStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widowed"});
            this.cBoxCivilStatus.Location = new System.Drawing.Point(309, 104);
            this.cBoxCivilStatus.Name = "cBoxCivilStatus";
            this.cBoxCivilStatus.Size = new System.Drawing.Size(121, 28);
            this.cBoxCivilStatus.TabIndex = 20;
            this.cBoxCivilStatus.Visible = false;
            this.cBoxCivilStatus.SelectedIndexChanged += new System.EventHandler(this.cBoxCivilStatus_SelectedIndexChanged);
            this.cBoxCivilStatus.Enter += new System.EventHandler(this.cBoxes_Enter);
            this.cBoxCivilStatus.Leave += new System.EventHandler(this.cBoxCivilStatus_Leave);
            // 
            // txtBoxDTP
            // 
            this.txtBoxDTP.BackColor = System.Drawing.Color.White;
            this.txtBoxDTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDTP.Location = new System.Drawing.Point(165, 111);
            this.txtBoxDTP.Name = "txtBoxDTP";
            this.txtBoxDTP.ReadOnly = true;
            this.txtBoxDTP.Size = new System.Drawing.Size(122, 25);
            this.txtBoxDTP.TabIndex = 19;
            this.txtBoxDTP.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            this.txtBoxDTP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPIN_KeyDown);
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.SteelBlue;
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.ForeColor = System.Drawing.Color.White;
            this.txtGender.Location = new System.Drawing.Point(25, 107);
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(100, 25);
            this.txtGender.TabIndex = 18;
            this.txtGender.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            this.txtGender.Enter += new System.EventHandler(this.txtBoxes_Enter);
            this.txtGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPIN_KeyDown);
            this.txtGender.Leave += new System.EventHandler(this.txtBoxes_Leave);
            // 
            // txtCivilStatus
            // 
            this.txtCivilStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCivilStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCivilStatus.ForeColor = System.Drawing.Color.White;
            this.txtCivilStatus.Location = new System.Drawing.Point(308, 107);
            this.txtCivilStatus.Multiline = true;
            this.txtCivilStatus.Name = "txtCivilStatus";
            this.txtCivilStatus.ReadOnly = true;
            this.txtCivilStatus.Size = new System.Drawing.Size(122, 23);
            this.txtCivilStatus.TabIndex = 20;
            this.txtCivilStatus.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            this.txtCivilStatus.Enter += new System.EventHandler(this.txtBoxes_Enter);
            this.txtCivilStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPIN_KeyDown);
            this.txtCivilStatus.Leave += new System.EventHandler(this.txtBoxes_Leave);
            // 
            // tabPageAccounts
            // 
            this.tabPageAccounts.BackColor = System.Drawing.Color.SlateBlue;
            this.tabPageAccounts.Controls.Add(this.label4);
            this.tabPageAccounts.Controls.Add(this.btnAddAccount);
            this.tabPageAccounts.Controls.Add(this.panelBreakdown);
            this.tabPageAccounts.Controls.Add(this.dgvAccounts);
            this.tabPageAccounts.Location = new System.Drawing.Point(4, 29);
            this.tabPageAccounts.Name = "tabPageAccounts";
            this.tabPageAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccounts.Size = new System.Drawing.Size(484, 538);
            this.tabPageAccounts.TabIndex = 2;
            this.tabPageAccounts.Text = "Accounts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Accounts";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddAccount.FlatAppearance.BorderSize = 2;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(345, 35);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(133, 33);
            this.btnAddAccount.TabIndex = 13;
            this.btnAddAccount.TabStop = false;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // panelBreakdown
            // 
            this.panelBreakdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBreakdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBreakdown.Controls.Add(this.btnAddPayment);
            this.panelBreakdown.Controls.Add(this.label2);
            this.panelBreakdown.Controls.Add(this.dgvPaymentHistory);
            this.panelBreakdown.Controls.Add(this.lblMoneyLent);
            this.panelBreakdown.Controls.Add(this.lblAmountRemaining);
            this.panelBreakdown.Controls.Add(this.lblAmountPaid);
            this.panelBreakdown.Controls.Add(this.lblTotalLoan);
            this.panelBreakdown.Controls.Add(this.lblInterest);
            this.panelBreakdown.Location = new System.Drawing.Point(3, 320);
            this.panelBreakdown.Name = "panelBreakdown";
            this.panelBreakdown.Size = new System.Drawing.Size(478, 214);
            this.panelBreakdown.TabIndex = 4;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPayment.FlatAppearance.BorderSize = 2;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayment.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayment.Location = new System.Drawing.Point(23, 172);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(116, 37);
            this.btnAddPayment.TabIndex = 14;
            this.btnAddPayment.TabStop = false;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loan Breakdown";
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.AllowUserToAddRows = false;
            this.dgvPaymentHistory.AllowUserToDeleteRows = false;
            this.dgvPaymentHistory.AllowUserToResizeRows = false;
            this.dgvPaymentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaymentHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentHistory.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaymentHistory.GridColor = System.Drawing.Color.Turquoise;
            this.dgvPaymentHistory.Location = new System.Drawing.Point(241, 3);
            this.dgvPaymentHistory.MultiSelect = false;
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.ReadOnly = true;
            this.dgvPaymentHistory.RowHeadersVisible = false;
            this.dgvPaymentHistory.RowTemplate.Height = 24;
            this.dgvPaymentHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentHistory.Size = new System.Drawing.Size(232, 206);
            this.dgvPaymentHistory.TabIndex = 0;
            this.dgvPaymentHistory.TabStop = false;
            // 
            // lblMoneyLent
            // 
            this.lblMoneyLent.AutoSize = true;
            this.lblMoneyLent.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyLent.Location = new System.Drawing.Point(25, 53);
            this.lblMoneyLent.Name = "lblMoneyLent";
            this.lblMoneyLent.Size = new System.Drawing.Size(88, 18);
            this.lblMoneyLent.TabIndex = 0;
            this.lblMoneyLent.Text = "Money Lent:";
            // 
            // lblAmountRemaining
            // 
            this.lblAmountRemaining.AutoSize = true;
            this.lblAmountRemaining.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountRemaining.Location = new System.Drawing.Point(27, 145);
            this.lblAmountRemaining.Name = "lblAmountRemaining";
            this.lblAmountRemaining.Size = new System.Drawing.Size(135, 18);
            this.lblAmountRemaining.TabIndex = 2;
            this.lblAmountRemaining.Text = "Amount Remaining: ";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(27, 122);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(97, 18);
            this.lblAmountPaid.TabIndex = 2;
            this.lblAmountPaid.Text = "Amount Paid: ";
            // 
            // lblTotalLoan
            // 
            this.lblTotalLoan.AutoSize = true;
            this.lblTotalLoan.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLoan.Location = new System.Drawing.Point(27, 99);
            this.lblTotalLoan.Name = "lblTotalLoan";
            this.lblTotalLoan.Size = new System.Drawing.Size(81, 18);
            this.lblTotalLoan.TabIndex = 2;
            this.lblTotalLoan.Text = "Total Loan: ";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(27, 76);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(64, 18);
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
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccounts.GridColor = System.Drawing.Color.Turquoise;
            this.dgvAccounts.Location = new System.Drawing.Point(3, 70);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(475, 244);
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.TabStop = false;
            this.dgvAccounts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Controls.Add(this.lblBalanceSummary);
            this.groupBox1.Controls.Add(this.lblMoneyLentSummary);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 510);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Accounts Summary";
            // 
            // lblBalanceSummary
            // 
            this.lblBalanceSummary.AutoSize = true;
            this.lblBalanceSummary.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceSummary.Location = new System.Drawing.Point(211, 21);
            this.lblBalanceSummary.Name = "lblBalanceSummary";
            this.lblBalanceSummary.Padding = new System.Windows.Forms.Padding(4);
            this.lblBalanceSummary.Size = new System.Drawing.Size(64, 26);
            this.lblBalanceSummary.TabIndex = 0;
            this.lblBalanceSummary.Text = "Balance";
            // 
            // lblMoneyLentSummary
            // 
            this.lblMoneyLentSummary.AutoSize = true;
            this.lblMoneyLentSummary.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyLentSummary.Location = new System.Drawing.Point(6, 20);
            this.lblMoneyLentSummary.Name = "lblMoneyLentSummary";
            this.lblMoneyLentSummary.Padding = new System.Windows.Forms.Padding(4);
            this.lblMoneyLentSummary.Size = new System.Drawing.Size(80, 26);
            this.lblMoneyLentSummary.TabIndex = 0;
            this.lblMoneyLentSummary.Text = "Total Loan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rbtnInactive);
            this.panel1.Controls.Add(this.rbtnActive);
            this.panel1.Controls.Add(this.txtSearchLN);
            this.panel1.Controls.Add(this.txtSearchFN);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 58);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status";
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactive.Location = new System.Drawing.Point(216, 29);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(80, 22);
            this.rbtnInactive.TabIndex = 12;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Checked = true;
            this.rbtnActive.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActive.Location = new System.Drawing.Point(143, 28);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(70, 22);
            this.rbtnActive.TabIndex = 12;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // txtSearchLN
            // 
            this.txtSearchLN.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSearchLN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchLN.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLN.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearchLN.Location = new System.Drawing.Point(2, 30);
            this.txtSearchLN.Name = "txtSearchLN";
            this.txtSearchLN.Size = new System.Drawing.Size(122, 25);
            this.txtSearchLN.TabIndex = 11;
            this.txtSearchLN.Text = "Last Name";
            this.txtSearchLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchLN.Enter += new System.EventHandler(this.txtSearchLN_Enter);
            this.txtSearchLN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchFN_KeyDown);
            this.txtSearchLN.Leave += new System.EventHandler(this.txtSearchLN_Leave);
            // 
            // txtSearchFN
            // 
            this.txtSearchFN.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSearchFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchFN.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFN.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearchFN.Location = new System.Drawing.Point(3, 1);
            this.txtSearchFN.Name = "txtSearchFN";
            this.txtSearchFN.Size = new System.Drawing.Size(122, 25);
            this.txtSearchFN.TabIndex = 10;
            this.txtSearchFN.Text = "First Name";
            this.txtSearchFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchFN.Enter += new System.EventHandler(this.txtSearchFN_Enter);
            this.txtSearchFN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchFN_KeyDown);
            this.txtSearchFN.Leave += new System.EventHandler(this.txtSearchFN_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(399, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 50);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(133, 106);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 31);
            this.btnReset.TabIndex = 3;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset Table";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(250, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 31);
            this.button3.TabIndex = 4;
            this.button3.TabStop = false;
            this.button3.Text = "Can Add?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // CustomerMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(994, 588);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.tabCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddCustomer);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CustomerMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMgt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerMgt_FormClosing);
            this.Load += new System.EventHandler(this.CustomerMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.tabPagePersonalDetails.ResumeLayout(false);
            this.tabPagePersonalDetails.PerformLayout();
            this.tabPageAccounts.ResumeLayout(false);
            this.tabPageAccounts.PerformLayout();
            this.panelBreakdown.ResumeLayout(false);
            this.panelBreakdown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
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
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.TextBox txtPNum;
        private System.Windows.Forms.TextBox txtTelNum;
        private System.Windows.Forms.TextBox txtWorkingAdd;
        private System.Windows.Forms.TextBox txtJobDesc;
        private System.Windows.Forms.TextBox txtHomeAdd;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnResetEdit;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Panel panelBreakdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMoneyLent;
        private System.Windows.Forms.Label lblAmountRemaining;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblTotalLoan;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Button btnAddAccount;
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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cBoxGender;
        private System.Windows.Forms.DateTimePicker dtpBdate;
        private System.Windows.Forms.ComboBox cBoxCivilStatus;
        private System.Windows.Forms.CheckBox checkBoxEditMode;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.TextBox txtBoxDTP;
        private System.Windows.Forms.TextBox txtCivilStatus;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Label label4;
    }
}