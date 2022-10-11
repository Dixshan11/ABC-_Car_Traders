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
    public partial class AdminDashboard : Form
    {
        string usertype;
        // connection for the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        public AdminDashboard(String usertype)
        {
            InitializeComponent();
            //set usertype 
            this.usertype = usertype;
        }

     //some load events
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            btnDashBoard.TabStop = false;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.FlatAppearance.BorderSize = 0;
        }

      
        // link to the admin dashboard
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard(usertype);
            frm.Show();
            this.Hide();
        }

        //link to the ManageCar form
        private void btnCar_Click(object sender, EventArgs e)
        {
            ManageCar frm = new ManageCar(usertype);
            frm.Show();
            this.Hide();
        }

        //link to the ManageParts form
        private void btnparts_Click(object sender, EventArgs e)
        {
            ManageParts frm = new ManageParts(usertype);
            frm.Show();
            this.Hide();
        }

        //link to the ManageCustomer form
        private void btncustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer frm = new ManageCustomer(usertype);
            frm.Show();
            this.Hide();
        }

        //link to the ManageOrder form
        private void btnorder_Click(object sender, EventArgs e)
        {
            ManagOrder frm = new ManagOrder(usertype);
            frm.Show();
            this.Hide();
        }

        //link to the Report form
        private void btnreport_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports(usertype);
            frm.Show();
            this.Hide();
        }

        //link to the SaleForm form
        private void btnsales_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales(usertype);
            frm.Show();
            this.Hide();
        }

        //link to the Backup form
        private void btnbackup_Click(object sender, EventArgs e)
        {
            Backup frm = new Backup(usertype);
            frm.Show();
            this.Hide();
        }

       
    }
}
