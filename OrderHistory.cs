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
    public partial class OrderHistory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        string user;
        public OrderHistory(string username)
        {
            InitializeComponent();
            user = username;
        }
        //select the current users odered items 
        public DataTable grid()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM booked  WHERE Customer='" + user + "' ", con);
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
        //assigen the grid value in textbox
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
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CustomerDashboard myform = new CustomerDashboard(user);
            myform.Show();
            this.Hide();
        }

        private void btnShowCar_Click(object sender, EventArgs e)
        {
            ShowCar myform = new ShowCar(user);
            myform.Show();
            this.Hide();
        }

        private void btnOrderCar_Click(object sender, EventArgs e)
        {
            OderCar myform = new OderCar(user);
            myform.Show();
            this.Hide();
        }

        private void btnShowParts_Click(object sender, EventArgs e)
        {
            ShowParts myform = new ShowParts(user);
            myform.Show();
            this.Hide();
        }

        private void btnOrderParts_Click(object sender, EventArgs e)
        {
            OrderParts myform = new OrderParts(user);
            myform.Show();
            this.Hide();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistory myform = new OrderHistory(user);
            myform.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile myform = new CustomerProfile(user);
            myform.Show();
            this.Hide();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            dt = grid();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
