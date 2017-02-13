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
            customerPIN = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
            label1.Text = "Viewing customer: " + dgvCustomers.Rows[e.RowIndex].Cells[0].Value;

            loadCustomerDetails(customerPIN);
            loadCustomerAccounts(customerPIN);
            loadAccountsSummary(customerPIN);
        }


        private void btnMgtAcc_Click(object sender, EventArgs e)
        {

        }

        private void loadCustomerDetails(string customerPIN)
        {
            string[] customerProfile = dh.getCustomerProfile(customerPIN);
            txtFN.Text = customerProfile[1];
            txtLN.Text = customerProfile[2];
            txtGender.Text = customerProfile[3];
            txtCivilStatus.Text = customerProfile[4];
            txtBdate.Text = customerProfile[5];
            txtHomeAdd.Text = customerProfile[6];
            txtJobDesc.Text = customerProfile[7];
            txtWorkingAdd.Text = customerProfile[8];
            txtTelNum.Text = customerProfile[9];
            txtPNum.Text = customerProfile[10];
            txtPIN.Text = customerProfile[11];

        }

        private void loadCustomerAccounts(string customerPIN)
        {
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
                dr[2] = ((DateTime)temp.Rows[i][3]).ToString("MM-dd-yyyy"); ;
                dr[3] = temp.Rows[i][4];
                dr[4] = temp.Rows[i][5];
                customerAccounts.Rows.Add(dr);
            }

            dgvAccounts.DataSource = customerAccounts;
            dgvAccounts.ClearSelection();

            dgvAccounts.Columns[0].Visible = false; //Hides accountID columnf
            panelBreakdown.Visible = false;
            
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
            lblAmountPaid.Text = "Amount Paid: " + dh.getTotalPayment(accountID);
            lblAmountRemaining.Text = "Amount Remaining: " + (dh.getInterestAmount(accountID) + double.Parse(accountDetails[2]) - dh.getTotalPayment(accountID));

            panelBreakdown.Visible = true;

        }

        private void dgvAccounts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int accountID = int.Parse(dgvAccounts.Rows[e.RowIndex].Cells[0].Value.ToString());
            refreshAccountProfile(accountID);

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
            lblBalanceSummary.Text =  "Total Balance: " + dh.getTotalBalance(customerPIN).ToString();
            lblMoneyLentSummary.Text = "Total Money Lent: " + dh.getTotalMoneyLent(dh.getCustomerID(customerPIN));
        }
    }
}
