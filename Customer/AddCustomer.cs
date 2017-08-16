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
    public partial class AddCustomer : Form
    {
        DataHandler dh = new DataHandler("localhost", "boombroom", "root", "root");
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            dtpBdate.MaxDate = DateTime.Now;
            cBoxCivilStatus.SelectedIndex = 0;
            cBoxGender.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!dh.pinExists(txtPIN.Text))
            {
                string gender = cBoxGender.Text == "Male" ? "M" : "F";
                bool success = dh.addCustomer(txtFN.Text, txtLN.Text, gender, cBoxCivilStatus.Text, dtpBdate.Value.ToString("yyyy-MM-dd"),
                    txtHomeAdd.Text, txtJobDesc.Text, txtWorkingAdd.Text, txtTelNum.Text, txtPNum.Text, txtPIN.Text);
                if (success)
                {
                    MessageBox.Show("Acccount Added Successfully!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("PIN EXISTS");
            }


        }

        public bool allFieldsFilled()
        {
            return !(txtFN.Text == "" || txtLN.Text == "" || txtHomeAdd.Text == "" || txtWorkingAdd.Text == "" 
                || txtTelNum.Text == "" || txtPNum.Text == "" || txtPNum.Text.Length == 4);
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = allFieldsFilled();
        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = allFieldsFilled();
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = allFieldsFilled();
        }

        private void txtHomeAdd_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = allFieldsFilled();
        }

        private void txtJobDesc_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = allFieldsFilled();
        }

        private void txtWorkingAdd_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = allFieldsFilled();
        }

        private void txtTelNum_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = allFieldsFilled();
        }

        private void txtPNum_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = allFieldsFilled();
        }

        private void AddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
