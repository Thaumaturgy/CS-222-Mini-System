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
    public partial class AddAccount : Form
    {
        DataHandler dh = new DataHandler("localhost", "boombroom", "root", "root");

        int customerID;
        public AddAccount(int customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            
            if(txtMoneyLent.Text == "")
            {
                MessageBox.Show("Please input loan amount", "Empty Field", MessageBoxButtons.OK);
                return;
            }

            double interestRate;
            if (rbtn1Month.Checked)
                interestRate = 0.03;
            else if (rbtn3Months.Checked)
                interestRate = 0.05;
            else
                interestRate = 0.07;

            double moneyLent = int.Parse(txtMoneyLent.Text);
            double totalBalance = dh.getTotalBalanceOfCustomer(customerID);

            

            if (moneyLent > 20000) {
                MessageBox.Show("New Overall Balance Exceeds 20000!");
                return;
            }

            bool createAccSuccess = dh.addAccount(customerID, int.Parse(txtMoneyLent.Text), DateTime.Now.ToString("yyyy-MM-dd"), "Active", interestRate); //Add account

            int accountID = dh.getLastInsertedIDOfAccounts();
            

            for(int i = 0; i < dgvCards.Rows.Count; i++) //Add all cards
            {
                dh.addCard(dgvCards.Rows[i].Cells[0].Value.ToString(), dgvCards.Rows[i].Cells[1].Value.ToString());
                dh.addAccountCard(accountID, dh.getCardID(dgvCards.Rows[i].Cells[0].Value.ToString(), dgvCards.Rows[i].Cells[1].Value.ToString()));
                Console.WriteLine("CARD ID is " + dh.getCardID(dgvCards.Rows[i].Cells[0].Value.ToString(), dgvCards.Rows[i].Cells[1].Value.ToString()));
            }

            if (createAccSuccess)
                MessageBox.Show("Account Added", "Success", MessageBoxButtons.OK);
            else
                MessageBox.Show("Account Not Added", "Failure", MessageBoxButtons.OK);
        }

        public void updateAddAccountStatus()
        {

            btnAddAccount.Enabled = dgvCards.Rows.Count != 0 && txtMoneyLent.Text != "";

        }

        private void txtMoneyLent_TextChanged(object sender, EventArgs e)
        {

            panel1.Enabled = txtMoneyLent.Text.Length > 0;
            Console.WriteLine("panel1 ENabled: " + (txtMoneyLent.Text.Length > 0));
            updateLoanBreakdown();
            updateAddAccountStatus();

        }

        private void txtMoneyLent_KeyDown(object sender, KeyEventArgs e)
        {
            bool isNum = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);
            bool isBack = e.KeyCode == Keys.Back;

            if (!(isNum || isBack))
                e.SuppressKeyPress = true;
        }

        private void rbtn1Month_CheckedChanged(object sender, EventArgs e)
        {
            updateLoanBreakdown();
        }

        private void rbtn3Months_CheckedChanged(object sender, EventArgs e)
        {
            updateLoanBreakdown();
        }

        private void rbtn6Months_CheckedChanged(object sender, EventArgs e)
        {
            updateLoanBreakdown();
        }

        public void updateLoanBreakdown()
        {
            double interestRate;
            if (rbtn1Month.Checked)
                interestRate = 0.03;
            else if (rbtn3Months.Checked)
                interestRate = 0.05;
            else
                interestRate = 0.07;

            if (txtMoneyLent.Text.Length > 0)
            {
                lblMoneyLent.Text = "Money Lent: " + double.Parse(txtMoneyLent.Text);
                lblInterest.Text = "Interest: " + (double.Parse(txtMoneyLent.Text) * interestRate);
                lblTotalLoan.Text = "Total: " + (double.Parse(txtMoneyLent.Text) + double.Parse(txtMoneyLent.Text) * interestRate);
            }
            else
            {
                lblMoneyLent.Text = "Money Lent: ";
                lblInterest.Text = "Interest: ";
                lblTotalLoan.Text = "Total: ";
            }

            

        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < dgvCards.Rows.Count; i++)
            {
                if (dgvCards.Rows[i].Cells[0].Value.ToString() == txtCardNumber.Text && dgvCards.Rows[i].Cells[1].Value.ToString() == txtBank.Text)
                {
                    MessageBox.Show("Card Number already exists!");
                    return;
                }
            }

            dgvCards.Rows.Add(new string[] { txtCardNumber.Text, txtBank.Text });
            updateAddAccountStatus();
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            changeBtnAddCardStatus();
        }

        public void changeBtnAddCardStatus()
        {
            btnAddCard.Enabled = txtBank.Text != "" && txtCardNumber.Text != "";
        }

        private void txtBank_TextChanged(object sender, EventArgs e)
        {
            changeBtnAddCardStatus();
        }
    }
}
