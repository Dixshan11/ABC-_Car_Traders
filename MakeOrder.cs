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
    public partial class MakeOrder : Form
    {
        string usertype;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public MakeOrder(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }
        public DataTable partsgrid()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM part ", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt=null;
                //throw;
            }

        }


        public DataTable cargrid()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM car ", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt2.Load(dr);
                con.Close();
                return dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt2=null;
                //throw;
            }

        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {
            dt2= cargrid();
            orderGridView.DataSource = dt2;
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
        
           dt= partsgrid();
            orderGridView.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            cargrid();
            orderGridView.DataSource = dt2;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtsearch_TextChanged_1(object sender, EventArgs e)
        {
            if (comsearchType.SelectedIndex < 0)
            {
                return;
            }
            try
            {
                string cmbSearch = comsearchType.SelectedItem.ToString();
                DataView dv = new DataView(dt, cmbSearch + " LIKE '" + txtsearch.Text + "*' ", cmbSearch, DataViewRowState.CurrentRows);
                orderGridView.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }
    }
}
