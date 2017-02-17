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
        public AddPayment()
        {

            InitializeComponent();
            lblPaymentDate.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }

        private void lblPaymentDate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
