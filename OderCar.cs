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
    public partial class OderCar : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        string user;
        public OderCar(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void OderCar_Load(object sender, EventArgs e)
        {
            cargrid();
            carOrderGridView.DataSource = dt;     
        }
        //make order 
        private void btnmakeorder_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO booked(Item,Name,Brand,Customer,Price,Quantity)VALUES('" + txtid.Text + "','" + comModel.Text + "','" + comBrand.Text + "','" + user + "','" + txtPrice.Text + "','" + "1" + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ordered Successfully ...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clear();
        }

        // select all car in grid view 
        public void cargrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM car ", con);
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
        // seach the cars inthe gridview 
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
                carOrderGridView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }
        // assign the selected gridview cells to input fields 
        private void carOrderGridView_SelectionChanged(object sender, EventArgs e)
        {
            txtcolour.Text = carOrderGridView.CurrentRow.Cells["Color"].Value.ToString();
            comBrand.Text = carOrderGridView.CurrentRow.Cells["Brand"].Value.ToString();
            comModel.Text = carOrderGridView.CurrentRow.Cells["Model"].Value.ToString();
            txtPrice.Text = carOrderGridView.CurrentRow.Cells["Price"].Value.ToString();
            txtCc.Text = carOrderGridView.CurrentRow.Cells["Cc"].Value.ToString();
            txtEngNo.Text = carOrderGridView.CurrentRow.Cells["EngNo"].Value.ToString();
            txtContry.Text = carOrderGridView.CurrentRow.Cells["MadeBy"].Value.ToString();
            txtid.Text = carOrderGridView.CurrentRow.Cells["Itemid"].Value.ToString();
        }
     
        //clear input fields
        private void clear()
        {
            txtid.Clear();
            comBrand.SelectedIndex = 0;
            comModel.SelectedIndex = 0;
            txtcolour.Clear();
            txtPrice.Clear();
            txtCc.Clear();
            txtEngNo.Clear();
            txtContry.Clear();     
            con.Close();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

      
    }
}
