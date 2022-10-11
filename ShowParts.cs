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
    public partial class ShowParts : Form
    {
        //database connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        string user;
        public ShowParts(string username)
        {
            InitializeComponent();
            user = username;
        }

       //select all the parts 
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
            }

        }
        private void ShowParts_Load(object sender, EventArgs e)
        {
            partsgrid();
            partsGridView.DataSource = dt;
           
        }

      
        //search parts in grid view 
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
                partsGridView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
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
    }
}
