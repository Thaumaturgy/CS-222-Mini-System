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
    public partial class CustomerProfile : Form
    {
        DataHandler dh = new DataHandler("localhost", "boombroom", "root", "root");

        string customerPIN;
        //bool isAdmin; //PIVOTAL PARAMETER!
        public CustomerProfile(string customerPIN)
        {
            this.customerPIN = customerPIN;
            InitializeComponent();
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource;
            lblWelcome.Text = "Welcome, " + dh.getCustomerProfile(customerPIN)[1];
            loadCustomerAccounts(dh.getCustomerID(customerPIN));

        }

        private void loadCustomerAccounts(int customerID)
        {
            DataTable temp = dh.getAllAccountsByCustomerDataTable(customerID);
            lblAccount.Text = "Number of Active Accounts: " + dh.numberOfActiveAccounts(customerID);

            DataTable dt = new DataTable();
            dt.Columns.Add("Account ID");
            dt.Columns.Add("Money Lent");
            dt.Columns.Add("Entry Date");
            dt.Columns.Add("Status");

            Console.WriteLine("This customer has n rows: " + temp.Rows.Count);
            //Console.WriteLine(temp.Rows[0][3].GetType());
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = temp.Rows[i][0];
                dr[1] = temp.Rows[i][2];
                dr[2] = ((DateTime)temp.Rows[i][3]).ToString("MM-dd-yyyy");
                dr[3] = temp.Rows[i][4];

                dt.Rows.Add(dr);
            }

            dgvAccounts.DataSource = dt;
            dgvAccounts.Columns[0].Visible = false; //Hide accountID
            dgvAccounts.Sort(dgvAccounts.Columns[3], ListSortDirection.Ascending);
        }

        private void dgvAccounts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int accountID = int.Parse(dgvAccounts.Rows[e.RowIndex].Cells[0].Value.ToString());
            refreshAccountProfile(accountID);
            loadPaymentHistory(accountID);

        }

        private void refreshAccountProfile(int accountID)
        {
            
            string[] accountDetails = dh.getAccountDetails(accountID);
            /*if (accountDetails[4] == "Paid")
                panelBreakdown.Visible = false;
            else
                panelBreakdown.Visible = true;*/

            lblEntryDate.Text = "Entry Date: " + dh.getEntryDate(accountID).ToString("MM-dd-yyyy");
            lblInterestRate.Text = "Interest Rate: " + (double.Parse(accountDetails[5])*100) + "%";
            lblMoneyLent.Text = "Money Lent: " + accountDetails[2];
            lblStatus.Text = accountDetails[4];
            lblInterest.Text = "Interest: " + dh.getInterestAmount(accountID);
            lblTotalLoan.Text = "Total Loan: " + (dh.getInterestAmount(accountID) + double.Parse(accountDetails[2]));
            lblAmountPaid.Text = "Amount Paid: " + dh.getTotalPaymentOfAccount(accountID);
            lblAmountRemaining.Text = "Amount Remaining: " + (dh.getInterestAmount(accountID) + double.Parse(accountDetails[2]) - dh.getTotalPaymentOfAccount(accountID));

            if (accountDetails[4] == "Active")
                lblStatus.ForeColor = Color.LimeGreen;
            else
                lblStatus.ForeColor = Color.Red;

        }

        private void lblRemainingLoan_Click(object sender, EventArgs e)
        {
            lblInterest.Text = "Remaining Loan: "+ dh.getInterestAmount(11);
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
                dr[0] = temp.Rows[i][1];
                dr[1] = temp.Rows[i][2];
                dr[2] = ((DateTime)temp.Rows[i][3]).ToString("MM-dd-yyyy");
                accountPayments.Rows.Add(dr);
            }

            dgvPaymentHistory.DataSource = accountPayments;

            dgvPaymentHistory.Columns[0].Visible = false; //Hide accountID!
           // dgvPaymentHistory.ClearSelection();
        }

        private void CustomerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
