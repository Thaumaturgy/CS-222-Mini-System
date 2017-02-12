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

        int customerID;
        public CustomerProfile(int customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource;
            DataTable temp = dh.getAllAccountsByCustomerDataTable(customerID);
            lblAccount.Text = "Number of Active Accounts: " + dh.numberOfActiveAccounts(customerID);
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Account ID");
            dt.Columns.Add("Money Lent");
            dt.Columns.Add("Entry Date");
            dt.Columns.Add("Status");
            /*dt.Columns.Add("Home Address");
            dt.Columns.Add("Job Description");
            dt.Columns.Add("Working Address");
            dt.Columns.Add("Telephone Number");
            dt.Columns.Add("Phone Number");
            dt.Columns.Add("PIN");*/


            Console.WriteLine(temp.Rows[0][3].GetType());
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = temp.Rows[i][0];
                dr[1] = temp.Rows[i][2];
                dr[2] = ((DateTime)temp.Rows[i][3]).ToString("MM-dd-yyyy"); ;
                dr[3] = temp.Rows[i][4];

                dt.Rows.Add(dr);
            }

            dgvAccounts.DataSource = dt;
            dgvAccounts.Sort(dgvAccounts.Columns[3], ListSortDirection.Ascending);

        }


    }
}
