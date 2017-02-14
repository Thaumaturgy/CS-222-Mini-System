using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class CustomerMgt : Form
    {
        DataHandler dh = new DataHandler("localhost", "boombroom", "root", "root");
        string customerPIN;
        public CustomerMgt()
        {
            InitializeComponent();
        }

        private void CustomerMgt_Load(object sender, EventArgs e)
        {
            loadCustomersTable();
            //dgvAccounts.ClearSelection();
            //dgvCustomers.Rows[0].Selected = true;
            
        }

        public void loadCustomersTable()
        {
            DataTable temp = dh.getAllCustomersDataTable();

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                for (int j = 0; j < temp.Columns.Count; j++)
                {
                    Console.Write(temp.Rows[i][j] + " ");
                }
                Console.WriteLine();
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("PIN");
            dt.Columns.Add("Status"); //Not inherent in DBMS
            

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = temp.Rows[i][1] +"  "+ temp.Rows[i][2];
                dr[1] = temp.Rows[i][10];
                dr[2] = temp.Rows[i][11];
                
                bool customerActive = dh.customerIsActive(temp.Rows[i][11].ToString());
                if (customerActive)
                    dr[3] = "Active"; //Status
                else
                    dr[3] = "Inactive";
                dt.Rows.Add(dr);
                
            }


            dgvCustomers.DataSource = dt;
            dgvCustomers.ClearSelection();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvCustomers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //ssageBox.Show("Cell clicked in dgvCustomers");
            customerPIN = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
            label1.Text = "Viewing customer: " + dgvCustomers.Rows[e.RowIndex].Cells[0].Value;

           //essageBox.Show("Loading CustomerDetails, CustomerAccounts, AccuntsSummary");
            loadCustomerDetails(customerPIN);
            loadCustomerAccounts(customerPIN);
            loadAccountsSummary(customerPIN);
            //panelBreakdown.Visible = false;
            //dgvAccounts.ClearSelection();

        }


        private void btnMgtAcc_Click(object sender, EventArgs e)
        {

        }

        private void loadCustomerDetails(string customerPIN)
        {
            string[] customerProfile = dh.getCustomerProfile(customerPIN);
            txtFN.Text = customerProfile[1];
            txtLN.Text = customerProfile[2];

            //txtGender.Text = customerProfile[3];
            cBoxGender.Text = customerProfile[3] == "M" ? "Male" : "Female";

            //txtCivilStatus.Text = customerProfile[4];
            cBoxCivilStatus.Text = customerProfile[4];

            dtpBdate.Value = dh.getBDate(customerPIN);
            //txtBdate.Text = customerProfile[5];

            txtHomeAdd.Text = customerProfile[6];
            txtJobDesc.Text = customerProfile[7];
            txtWorkingAdd.Text = customerProfile[8];
            txtTelNum.Text = customerProfile[9];
            txtPNum.Text = customerProfile[10];
            txtPIN.Text = customerProfile[11];

        }

        private void loadCustomerAccounts(string customerPIN)
        {
            //MessageBox.Show("Loading Customer Accounts");
            DataTable temp = dh.getAllAccountsByCustomerDataTable(customerPIN);
            
            DataTable customerAccounts = new DataTable();
            customerAccounts.Columns.Add("accountID"); //For Data storing only!
            customerAccounts.Columns.Add("Money Lent");
            customerAccounts.Columns.Add("Entry Date");
            customerAccounts.Columns.Add("Status");
            customerAccounts.Columns.Add("Interest");

            Console.WriteLine("THis guy has n accounts :" + temp.Rows.Count);
            for(int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = customerAccounts.NewRow();
                dr[0] = temp.Rows[i][0];
                dr[1] = temp.Rows[i][2];
                dr[2] = ((DateTime)temp.Rows[i][3]).ToString("MM-dd-yyyy");
                dr[3] = temp.Rows[i][4];
                dr[4] = temp.Rows[i][5];
                customerAccounts.Rows.Add(dr);
            }

            dgvAccounts.DataSource = customerAccounts;

            dgvAccounts.Columns[0].Visible = false; //Hides accountID columnf
            panelBreakdown.Visible = false;


            dgvAccounts.ClearSelection();
        }

        private void refreshAccountProfile(int accountID)
        {

            string[] accountDetails = dh.getAccountDetails(accountID);
            /*if (accountDetails[4] == "Paid")
                panelBreakdown.Visible = false;
            else
                panelBreakdown.Visible = true;*/

            lblMoneyLent.Text = "Money Lent: " + accountDetails[2];
            lblInterest.Text = "Interest: " + dh.getInterestAmount(accountID);
            lblTotalLoan.Text = "Total Loan: " + (dh.getInterestAmount(accountID) + double.Parse(accountDetails[2]));
            lblAmountPaid.Text = "Amount Paid: " + dh.getTotalPaymentOfAccount(accountID);
            lblAmountRemaining.Text = "Amount Remaining: " + (dh.getInterestAmount(accountID) + double.Parse(accountDetails[2]) - dh.getTotalPaymentOfAccount(accountID));

            panelBreakdown.Visible = true;

        }

        private void dgvAccounts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           //essageBox.Show("Cell clicked in dgvAccounts");
            int accountID = int.Parse(dgvAccounts.Rows[e.RowIndex].Cells[0].Value.ToString());
            refreshAccountProfile(accountID);
            loadPaymentHistory(accountID);

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration regis = new Registration();
            regis.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadSearchCustomer(txtSearchFN.Text, txtSearchLN.Text, rbtnActive.Checked);


        }

        private void loadSearchCustomer(string fn, string ln, bool isActive)
        {
            DataTable temp = dh.searchCustomers(fn, ln, isActive);
            DataTable dt = new DataTable();
            //Filter Columns
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("PIN");
            dt.Columns.Add("Status"); //Not inherent in DBMS


            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = temp.Rows[i][1] + "  " + temp.Rows[i][2];
                dr[1] = temp.Rows[i][10];
                dr[2] = temp.Rows[i][11];

                bool customerActive = dh.customerIsActive(temp.Rows[i][11].ToString());
                if (customerActive)
                    dr[3] = "Active"; //Status
                else
                    dr[3] = "Inactive";
                dt.Rows.Add(dr);

            }



            dgvCustomers.DataSource = dt;
            dgvCustomers.ClearSelection();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadCustomersTable();
        }

        private void loadAccountsSummary(string customerPIN)
        {
            int customerID = dh.getCustomerID(customerPIN);

            double totalLoan = dh.getTotalMoneyLentOfCustomer(customerID, 1) + dh.getTotalInterestOfCustomer(dh.getCustomerID(customerPIN), 1);

            lblBalanceSummary.Text =  "Total Balance: " + dh.getTotalBalanceOfCustomer(customerID).ToString();
            lblMoneyLentSummary.Text = "Total Loan: " + totalLoan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvAccounts.ClearSelection();
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPIN_KeyDown(object sender, KeyEventArgs e)
        {
            bool isNum = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);
            bool isBack = e.KeyCode == Keys.Back;

            if (!(isNum || isBack))
                e.SuppressKeyPress = true;
        }



        private void txtFN_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtTelNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)) && e.KeyCode != Keys.Back)
                e.SuppressKeyPress = true;
        }

        private void txtPNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)) && e.KeyCode != Keys.Back)
                e.SuppressKeyPress = true;
        }

        private void checkBoxEditMode_CheckedChanged(object sender, EventArgs e)
        {
                txtFN.Enabled = checkBoxEditMode.Checked;
                txtLN.Enabled = checkBoxEditMode.Checked;
                cBoxGender.Enabled = checkBoxEditMode.Checked;
                cBoxCivilStatus.Enabled = checkBoxEditMode.Checked;
                dtpBdate.Enabled = checkBoxEditMode.Checked;
                txtHomeAdd.Enabled = checkBoxEditMode.Checked;
                txtJobDesc.Enabled = checkBoxEditMode.Checked;
                txtWorkingAdd.Enabled = checkBoxEditMode.Checked;
                txtTelNum.Enabled = checkBoxEditMode.Checked;
                txtPNum.Enabled = checkBoxEditMode.Checked;
                txtPIN.Enabled = checkBoxEditMode.Checked;


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dh.hasPaidMoreThanHalf(dh.getCustomerID(customerPIN)))
                MessageBox.Show("He can Add!");
            else
                MessageBox.Show("He can Cannot Add!");
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {

        }

        public void loadPaymentHistory(int accountID)
        {
            DataTable temp = dh.getAllPaymentsByAccountDataTable(accountID);

            DataTable accountPayments = new DataTable();
            accountPayments.Columns.Add("accountID"); //For Data Storing ONLY!!
            accountPayments.Columns.Add("Payment Amount");
            accountPayments.Columns.Add("Payment Date");
            

            Console.WriteLine("THis guy has n payments :" + temp.Rows.Count);
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = accountPayments.NewRow();
                dr[0] = temp.Rows[i][0];
                dr[1] = temp.Rows[i][1];
                dr[2] = ((DateTime)temp.Rows[i][2]).ToString("MM-dd-yyyy");
                accountPayments.Rows.Add(dr);
            }

            dgvPaymentHistory.DataSource = accountPayments;

            dgvPaymentHistory.Columns[0].Visible = false; //Hide accountID!
            dgvPaymentHistory.ClearSelection();
        }

        private void dtpBdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
