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
        int customerID;
        public AddAccount(int customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
