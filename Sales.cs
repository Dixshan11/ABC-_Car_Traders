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
    public partial class Sales : Form
    {

        string usertype;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        public Sales(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

        private void Sales_Load(object sender, EventArgs e)
        {

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
    }
}
