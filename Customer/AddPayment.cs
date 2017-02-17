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
    public partial class AddPayment : Form
    {
        int accountID;
        DataHandler dh = new DataHandler("localhost", "boombroom", "root", "root");

        public AddPayment(int accountID)
        {
            this.accountID = accountID;
            InitializeComponent();
            lblPaymentDate.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }

        private void lblPaymentDate_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            if (txtPayment.Text == "") 
                return;

            int containsPeriod = txtPayment.Text.IndexOf(".");

            double moneyLentWithInterest = double.Parse(dh.getAccountDetails(accountID)[2]) + dh.getInterestAmount(accountID);
            double moneyPaid = dh.getTotalPaymentOfAccount(accountID);

            double payment = double.Parse(txtPayment.Text);
            double balance = moneyLentWithInterest - moneyPaid;

            if (payment > balance)
            {
                txtPayment.Text = balance.ToString("0.00");
            }else
            {
                txtPayment.Text = payment.ToString("0.00");
            }
            if(containsPeriod != -1)
                txtPayment.SelectionStart = txtPayment.Text.Length - 3;

            btnOK.Enabled = double.Parse(txtPayment.Text) != 0;
        }

        private void txtPayment_KeyDown(object sender, KeyEventArgs e)
        {
            bool isNum = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);
            bool isBack = e.KeyCode == Keys.Back;
            bool isPeriod = (e.KeyCode == Keys.OemPeriod) && !(txtPayment.Text.Contains(".")); //ONLY ACCEPTS ONE DECIMAL POINT
            if (!(isNum || isBack || isPeriod))
                e.SuppressKeyPress = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool success = dh.addPayment(accountID, double.Parse(txtPayment.Text), DateTime.Now.ToString("yyyy-MM-dd"));
            if (success)
                MessageBox.Show("Payment Success", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Payment Fail", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
