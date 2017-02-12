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
    public partial class Login : Form
    {
        DataHandler dh = new DataHandler("localhost", "BoomBroom", "root", "root");
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dh.pinExists(txtboxLogin.Text))
            {
                string[] customer = dh.getCustomerProfile(txtboxLogin.Text);
                MessageBox.Show("Welcome, " + customer[1]); //gets FirstName
                this.Hide();
                CustomerProfile cp = new CustomerProfile(dh.getCustomerID(txtboxLogin.Text));
                cp.Show();
            }
            else
                MessageBox.Show("Who are you?");
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Panel Shows up here");
            CustomerMgt cm = new CustomerMgt();
            cm.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
