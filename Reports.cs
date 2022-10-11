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
    public partial class Reports : Form
    {
        string usertype;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        DataTable t = new DataTable();

        public Reports(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard(usertype);
            frm.Show();
            this.Hide();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            ManageCar frm = new ManageCar(usertype);
            frm.Show();
            this.Hide();
        }

        private void btnparts_Click(object sender, EventArgs e)
        {
            ManageParts frm = new ManageParts(usertype);
            frm.Show();
            this.Hide();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer frm = new ManageCustomer(usertype);
            frm.Show();
            this.Hide();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            ManagOrder frm = new ManagOrder(usertype);
            frm.Show();
            this.Hide();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales(usertype);
            frm.Show();
            this.Hide();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports(usertype);
            frm.Show();
            this.Hide();
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            Backup frm = new Backup(usertype);
            frm.Show();
            this.Hide();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            showindatagridview();
            t.Rows.Add("120","40", "9200000", "11", "2000000", "7200000", "5100000", "2100000");

        }

        public void showindatagridview()
        {
            t.Columns.Add("TOTAL CUSTOMER", typeof(string));
            t.Columns.Add("TOTAL ORDER", typeof(string));
            t.Columns.Add("ORDER AMOUNT", typeof(string));
            t.Columns.Add("REJECTED", typeof(string));
            t.Columns.Add("REJECTED AMOUNT", typeof(string));
            t.Columns.Add("SALES", typeof(string));
            t.Columns.Add("COST", typeof(string));
            t.Columns.Add("PROFIT", typeof(string));
            dataGridView1.DataSource = t;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
