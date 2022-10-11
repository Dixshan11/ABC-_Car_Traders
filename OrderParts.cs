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
    public partial class OrderParts : Form
    {
        //database connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        string user;
        //functional arguments
        public OrderParts(string username)
        {
            InitializeComponent();
            user = username;
        }
        //select all the parts details 
        public void partsgrid()
        {
          try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM part ", con);
                con.Open();
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

        //assigen the data table value in to the grird 
        private void OrderParts_Load(object sender, EventArgs e)
        {
            partsgrid();
            partsOrderGridView.DataSource = dt;
        }

        //search the parts in the grid view
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (comsearchType.SelectedIndex < 0)
            {
                return;
            }
            try
            {
                string cmbSearch = comsearchType.SelectedItem.ToString();
                DataView dv = new DataView(dt, cmbSearch + " LIKE '" + txtsearch.Text + "*' ", cmbSearch, DataViewRowState.CurrentRows);
                partsOrderGridView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }

        // assigen the grid view selected index values in the input fields
        private void partsOrderGridView_SelectionChanged(object sender, EventArgs e)
        {
            txtname.Text = partsOrderGridView.CurrentRow.Cells["Name"].Value.ToString();
            txtid.Text = partsOrderGridView.CurrentRow.Cells["Itemid"].Value.ToString();
            comBrand.Text = partsOrderGridView.CurrentRow.Cells["Brand"].Value.ToString();
            comModel.Text = partsOrderGridView.CurrentRow.Cells["Model"].Value.ToString();
            txtPrice.Text = partsOrderGridView.CurrentRow.Cells["Price"].Value.ToString();
            txtQuantity.Text = partsOrderGridView.CurrentRow.Cells["Quantity"].Value.ToString();
        }

       

        private void btnDashboard_Click_1(object sender, EventArgs e)
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

        private void btnmakeorder_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO booked(Item,Name,Brand,Customer,Price,Quantity)VALUES('" + txtid.Text + "','" + comModel.Text + "','" + comBrand.Text + "','" + user + "','" + txtPrice.Text + "','" + txtQuantity.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ordered Successfully ...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();



        }
    }
}
