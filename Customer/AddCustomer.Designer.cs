namespace Customer
{
    partial class AddCustomer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(205, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 47);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(54, 459);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 47);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIN.ForeColor = System.Drawing.Color.White;
            this.txtPIN.Location = new System.Drawing.Point(262, 61);
            this.txtPIN.MaxLength = 4;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(67, 23);
            this.txtPIN.TabIndex = 3;
            this.txtPIN.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            // 
            // txtPNum
            // 
            this.txtPNum.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNum.ForeColor = System.Drawing.Color.White;
            this.txtPNum.Location = new System.Drawing.Point(202, 406);
            this.txtPNum.MaxLength = 15;
            this.txtPNum.Name = "txtPNum";
            this.txtPNum.Size = new System.Drawing.Size(135, 23);
            this.txtPNum.TabIndex = 11;
            this.txtPNum.TextChanged += new System.EventHandler(this.txtPNum_TextChanged);
            // 
            // txtTelNum
            // 
            this.txtTelNum.BackColor = System.Drawing.Color.SteelBlue;
            this.txtTelNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelNum.ForeColor = System.Drawing.Color.White;
            this.txtTelNum.Location = new System.Drawing.Point(36, 406);
            this.txtTelNum.MaxLength = 7;
            this.txtTelNum.Name = "txtTelNum";
            this.txtTelNum.Size = new System.Drawing.Size(135, 23);
            this.txtTelNum.TabIndex = 10;
            this.txtTelNum.TextChanged += new System.EventHandler(this.txtTelNum_TextChanged);
            // 
            // txtWorkingAdd
            // 
            this.txtWorkingAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.txtWorkingAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWorkingAdd.ForeColor = System.Drawing.Color.White;
            this.txtWorkingAdd.Location = new System.Drawing.Point(36, 335);
            this.txtWorkingAdd.Name = "txtWorkingAdd";
            this.txtWorkingAdd.Size = new System.Drawing.Size(268, 23);
            this.txtWorkingAdd.TabIndex = 9;
            this.txtWorkingAdd.TextChanged += new System.EventHandler(this.txtWorkingAdd_TextChanged);
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.BackColor = System.Drawing.Color.SteelBlue;
            this.txtJobDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobDesc.ForeColor = System.Drawing.Color.White;
            this.txtJobDesc.Location = new System.Drawing.Point(36, 267);
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.Size = new System.Drawing.Size(268, 23);
            this.txtJobDesc.TabIndex = 8;
            this.txtJobDesc.TextChanged += new System.EventHandler(this.txtJobDesc_TextChanged);
            // 
            // txtHomeAdd
            // 
            this.txtHomeAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.txtHomeAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHomeAdd.ForeColor = System.Drawing.Color.White;
            this.txtHomeAdd.Location = new System.Drawing.Point(36, 199);
            this.txtHomeAdd.Name = "txtHomeAdd";
            this.txtHomeAdd.Size = new System.Drawing.Size(268, 23);
            this.txtHomeAdd.TabIndex = 7;
            this.txtHomeAdd.TextChanged += new System.EventHandler(this.txtHomeAdd_TextChanged);
            // 
            // txtLN
            // 
            this.txtLN.BackColor = System.Drawing.Color.SteelBlue;
            this.txtLN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLN.ForeColor = System.Drawing.Color.White;
            this.txtLN.Location = new System.Drawing.Point(138, 61);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(88, 23);
            this.txtLN.TabIndex = 2;
            this.txtLN.TextChanged += new System.EventHandler(this.txtLN_TextChanged);
            // 
            // txtFN
            // 
            this.txtFN.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFN.ForeColor = System.Drawing.Color.White;
            this.txtFN.Location = new System.Drawing.Point(36, 61);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(88, 23);
            this.txtFN.TabIndex = 1;
            this.txtFN.TextChanged += new System.EventHandler(this.txtFN_TextChanged);
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIN.Location = new System.Drawing.Point(272, 32);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(29, 18);
            this.lblPIN.TabIndex = 21;
            this.lblPIN.Text = "PIN";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(32, 32);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(75, 18);
            this.lblFN.TabIndex = 22;
            this.lblFN.Text = "First Name";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(199, 380);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(100, 18);
            this.lblPhoneNum.TabIndex = 23;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.Location = new System.Drawing.Point(134, 32);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(73, 18);
            this.lblLN.TabIndex = 24;
            this.lblLN.Text = "Last Name";
            // 
            // lblTelNum
            // 
            this.lblTelNum.AutoSize = true;
            this.lblTelNum.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelNum.Location = new System.Drawing.Point(32, 380);
            this.lblTelNum.Name = "lblTelNum";
            this.lblTelNum.Size = new System.Drawing.Size(78, 18);
            this.lblTelNum.TabIndex = 25;
            this.lblTelNum.Text = "Tel Number";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(39, 105);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 18);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "Gender";
            // 
            // lblWorkingAddress
            // 
            this.lblWorkingAddress.AutoSize = true;
            this.lblWorkingAddress.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingAddress.Location = new System.Drawing.Point(34, 310);
            this.lblWorkingAddress.Name = "lblWorkingAddress";
            this.lblWorkingAddress.Size = new System.Drawing.Size(111, 18);
            this.lblWorkingAddress.TabIndex = 27;
            this.lblWorkingAddress.Text = "Working Address";
            // 
            // lblCivilStatus
            // 
            this.lblCivilStatus.AutoSize = true;
            this.lblCivilStatus.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCivilStatus.Location = new System.Drawing.Point(259, 105);
            this.lblCivilStatus.Name = "lblCivilStatus";
            this.lblCivilStatus.Size = new System.Drawing.Size(78, 18);
            this.lblCivilStatus.TabIndex = 28;
            this.lblCivilStatus.Text = "Civil Status";
            // 
            // lblJobDescription
            // 
            this.lblJobDescription.AutoSize = true;
            this.lblJobDescription.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDescription.Location = new System.Drawing.Point(32, 241);
            this.lblJobDescription.Name = "lblJobDescription";
            this.lblJobDescription.Size = new System.Drawing.Size(108, 18);
            this.lblJobDescription.TabIndex = 29;
            this.lblJobDescription.Text = "Job Description";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(134, 105);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(73, 18);
            this.lblBirthDate.TabIndex = 30;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeAddress.Location = new System.Drawing.Point(32, 173);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(97, 18);
            this.lblHomeAddress.TabIndex = 31;
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
            this.cBoxGender.Location = new System.Drawing.Point(36, 130);
            this.cBoxGender.Name = "cBoxGender";
            this.cBoxGender.Size = new System.Drawing.Size(88, 26);
            this.cBoxGender.TabIndex = 4;
            // 
            // dtpBdate
            // 
            this.dtpBdate.CalendarForeColor = System.Drawing.Color.White;
            this.dtpBdate.CalendarMonthBackground = System.Drawing.Color.SlateBlue;
            this.dtpBdate.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.dtpBdate.CalendarTitleForeColor = System.Drawing.Color.Cyan;
            this.dtpBdate.CustomFormat = "MM/dd/yyyy";
            this.dtpBdate.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBdate.Location = new System.Drawing.Point(137, 133);
            this.dtpBdate.Name = "dtpBdate";
            this.dtpBdate.Size = new System.Drawing.Size(107, 25);
            this.dtpBdate.TabIndex = 5;
            this.dtpBdate.Value = new System.DateTime(2017, 2, 15, 0, 0, 0, 0);
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
            this.cBoxCivilStatus.Location = new System.Drawing.Point(256, 132);
            this.cBoxCivilStatus.Name = "cBoxCivilStatus";
            this.cBoxCivilStatus.Size = new System.Drawing.Size(106, 26);
            this.cBoxCivilStatus.TabIndex = 6;
            // 
            // AddCustomer
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(400, 549);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtPNum);
            this.Controls.Add(this.txtTelNum);
            this.Controls.Add(this.txtWorkingAdd);
            this.Controls.Add(this.txtJobDesc);
            this.Controls.Add(this.txtHomeAdd);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblTelNum);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblWorkingAddress);
            this.Controls.Add(this.lblCivilStatus);
            this.Controls.Add(this.lblJobDescription);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblHomeAddress);
            this.Controls.Add(this.cBoxGender);
            this.Controls.Add(this.dtpBdate);
            this.Controls.Add(this.cBoxCivilStatus);
            this.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCustomer_FormClosing);
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.TextBox txtPNum;
        private System.Windows.Forms.TextBox txtTelNum;
        private System.Windows.Forms.TextBox txtWorkingAdd;
        private System.Windows.Forms.TextBox txtJobDesc;
        private System.Windows.Forms.TextBox txtHomeAdd;
        private System.Windows.Forms.TextBox txtLN;
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
        private System.Windows.Forms.ComboBox cBoxGender;
        private System.Windows.Forms.DateTimePicker dtpBdate;
        private System.Windows.Forms.ComboBox cBoxCivilStatus;
    }
}