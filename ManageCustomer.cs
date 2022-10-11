using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABC_Car_Traders
{
    public partial class ManageCustomer : Form
    {
        string usertype;
        //connection for the dataase
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        public ManageCustomer(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        public void customergrid()
        {
            try
            {  
                //select all the customer for customer table
                SqlCommand cmd = new SqlCommand("SELECT * FROM customer ", con);
                con.Open();
                //create an object 
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
                //throw;
            }

        }

        //load the details while load the page
        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            customergrid();
            customerGridView.DataSource = dt;
        }
        //get the data into input fileds form  gridview 
        private void customerGridView_SelectionChanged(object sender, EventArgs e)
        {
            txtcustomerid.Text = customerGridView.CurrentRow.Cells["Id"].Value.ToString();
            txtfname.Text = customerGridView.CurrentRow.Cells["FirstName"].Value.ToString();
            txtlname.Text = customerGridView.CurrentRow.Cells["LastName"].Value.ToString();
            txtphone.Text = customerGridView.CurrentRow.Cells["PhoneNo"].Value.ToString();
            txtaddress.Text = customerGridView.CurrentRow.Cells["Address"].Value.ToString();
            txtemail.Text = customerGridView.CurrentRow.Cells["Email"].Value.ToString();

        }
        void gridview()
        {
            customerGridView.Columns["username"].Visible = false;
            //customerGridView.Columns["EngNo"].Width = 80;
            customerGridView.Columns["Id"].HeaderText = "Customer ID";

        }
        //search the data into gridview 
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (comsearchType.SelectedIndex < 0)
            {
                return;
            }
            try
            {
                // search the data
                string cmbSearch = comsearchType.SelectedItem.ToString();
                DataView dv = new DataView(dt, cmbSearch + " LIKE '" + txtsearch.Text + "*' ", cmbSearch, DataViewRowState.CurrentRows);
                customerGridView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }

     
        // link to the dashboard
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard(usertype);
            frm.Show();
            this.Hide();
        }
        //link to ManageCar
        private void btnCar_Click(object sender, EventArgs e)
        {
            ManageCar frm = new ManageCar(usertype);
            frm.Show();
            this.Hide();
        }
        //link to ManageParts
        private void btnparts_Click(object sender, EventArgs e)
        {
            ManageParts frm = new ManageParts(usertype);
            frm.Show();
            this.Hide();
        }
        //link to Manage Customer form
        private void btncustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer frm = new ManageCustomer(usertype);
            frm.Show();
            this.Hide();
        }
        //link to manageorder form
        private void btnorder_Click(object sender, EventArgs e)
        {
            ManagOrder frm = new ManagOrder(usertype);
            frm.Show();
            this.Hide();
        }
        //link to sale form
        private void btnsales_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales(usertype);
            frm.Show();
            this.Hide();
        }
        //link to Report page
        private void btnreport_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports(usertype);
            frm.Show();
            this.Hide();
        }
        //link to bakcup page
        private void btnbackup_Click(object sender, EventArgs e)
        {

            Backup frm = new Backup(usertype);
            frm.Show();
            this.Hide();
        }

      
    }
}
