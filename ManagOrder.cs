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
    public partial class ManagOrder : Form
    {
        string usertype;
        // connection for the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        public ManagOrder(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        //load the data when load the page 
        private void ManagOrder_Load(object sender, EventArgs e)
        {
            dt = manageordergrid();
            dataGridView1.DataSource = dt;
        }
        //show data into input field form datagaridview
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["Item"].Value.ToString();
            txtorderid.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();

            comBrand.Text = dataGridView1.CurrentRow.Cells["Brand"].Value.ToString();
            txtcustomer.Text = dataGridView1.CurrentRow.Cells["Customer"].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            txtQuantity.Text = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
        }



        //save the data into datatable
        public DataTable manageordergrid()
        {
            //create datatable object
            DataTable dt = new DataTable();
            try
            {
                //get the data from booked
                SqlCommand cmd = new SqlCommand("SELECT * FROM booked  ", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt = null;

            }

        }


        //link to dashboard
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard(usertype);
            frm.Show();
            this.Hide();
        }

        //link ManageCar form
        private void btnCar_Click_1(object sender, EventArgs e)
        {
            ManageCar frm = new ManageCar(usertype);
            frm.Show();
            this.Hide();
        }
        //link manage Parts form
        private void btnparts_Click(object sender, EventArgs e)
        {
            ManageParts frm = new ManageParts(usertype);
            frm.Show();
            this.Hide();
        }
        //link Managecustomer form
        private void btncustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer frm = new ManageCustomer(usertype);
            frm.Show();
            this.Hide();
        }
        //link ManageOrder form
        private void btnorder_Click(object sender, EventArgs e)
        {
            ManagOrder frm = new ManagOrder(usertype);
            frm.Show();
            this.Hide();
        }
        //link to Sales form
        private void btnsales_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales(usertype);
            frm.Show();
            this.Hide();
        }
        //link to report form
        private void btnreport_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports(usertype);
            frm.Show();
            this.Hide();
        }
        //link Backup page
        private void btnbackup_Click(object sender, EventArgs e)
        {
            Backup frm = new Backup(usertype);
            frm.Show();
            this.Hide();
        }

      
       
    }
}
