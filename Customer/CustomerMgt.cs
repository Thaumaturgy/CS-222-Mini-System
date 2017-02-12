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
            label1.Text = "Viewing customer: " + dgvCustomers.SelectedRows[0].Cells[0].Value.ToString();
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
            /*dt.Columns.Add("Gender");
            dt.Columns.Add("Civil Status");
            dt.Columns.Add("Birth Date");
            dt.Columns.Add("Home Address");
            dt.Columns.Add("Job Description");
            dt.Columns.Add("Working Address");
            dt.Columns.Add("Telephone Number");*/
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("PIN");

            

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = temp.Rows[i][1] +"  "+ temp.Rows[i][2];
                /*dr[1] = temp.Rows[i][3];
                dr[2] = temp.Rows[i][4];
                dr[3] = temp.Rows[i][5];
                dr[4] = temp.Rows[i][6];
                dr[5] = temp.Rows[i][7];
                dr[6] = temp.Rows[i][8];
                dr[7] = temp.Rows[i][9];*/
                dr[1] = temp.Rows[i][10];
                dr[2] = temp.Rows[i][11];

                dt.Rows.Add(dr);
                
            }

            dgvCustomers.DataSource = dt;
            
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvCustomers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            btnMgtAcc.Enabled = true;
            customerPIN = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
            label1.Text = "Viewing customer: " + dgvCustomers.Rows[e.RowIndex].Cells[0].Value;
        }


        private void btnMgtAcc_Click(object sender, EventArgs e)
        {

        }

        private void loadCustomerDetails(int customerID)
        {
            string[] customerProfile = dh.getCustomerProfile(customerPIN);
            
            
        }

        private void tabPagePersonalDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
