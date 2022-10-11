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
    public partial class ManageParts : Form
    {
        string usertype;
        //connection for the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
       //create object for DataTable
        DataTable dt = new DataTable();
        public ManageParts(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

       
        //get the data form parts table and load in to the gridview
        public DataTable partgrid()
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
                return dt = null;
                //throw;
            }
        }

        //save the parts details into parts table 
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO part(Itemid,Brand,Model,Name,Price,Quantity)VALUES('" + txtid.Text + "','" + comBrand.Text + "','" + comModel.Text + "','" + txtname.Text + "','" + txtPrice.Text + "','" + txtQuantity.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clear();
        }

        //clear all input fields 
        private void clear()
        {
            txtid.Clear();
            comBrand.SelectedIndex = 0;
            comModel.SelectedIndex = 0;
            txtname.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            
            con.Close();
        }
        // load the data while form load 
        private void ManageParts_Load(object sender, EventArgs e)
        {
             dt= partgrid();
            dataGridView1.DataSource = dt;
        }
        //search data into the grid view
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comsearchType.Text == "ID")
            {
                // get the count 
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*)FROM part WHERE Itemid='" + txtsearch.Text + "' ", con);
                //create object for DataTable 
                DataTable dt = new DataTable();
                //fill the datatable
                sda.Fill(dt);
                //check the data table have the value 
                if (dt.Rows[0][0].ToString() == "1")
                {
                    // select the part details 
                    SqlCommand cmd = new SqlCommand("SELECT * FROM part WHERE Itemid='" + txtsearch.Text + "'", con);
                    con.Open();
                    //create object for SqlDataReader
                    SqlDataReader sdr = cmd.ExecuteReader();
                    //fill the input fields 
                    while (sdr.Read())
                    {
                        txtid.Text = sdr[0].ToString();
                        comBrand.Text = sdr[1].ToString();
                        comModel.Text = sdr[2].ToString();
                        txtname.Text = sdr[3].ToString();
                        txtPrice.Text = sdr[4].ToString();
                        txtQuantity.Text = sdr[5].ToString();
                        
                    }
                    con.Close();
                }
            }
            else if (comsearchType.Text == "Brand" || comsearchType.Text == "Model")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*)FROM part WHERE  Brand='" + txtsearch.Text + "'OR Model='" + txtsearch.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM part WHERE  Brand='" + txtsearch.Text + "'OR Model='" + txtsearch.Text + "'", con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        txtid.Text = sdr[0].ToString();
                        comBrand.Text = sdr[1].ToString();
                        comModel.Text = sdr[2].ToString();
                        txtname.Text = sdr[3].ToString();

                        txtPrice.Text = sdr[4].ToString();
                        txtQuantity.Text = sdr[5].ToString();
                    }
                    con.Close();
               }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
      
        //update part details 
        private void btnupdate_Click(object sender, EventArgs e)
        {
            //update parts 
            SqlCommand cmd = new SqlCommand("UPDATE part SET Brand='" + comBrand.Text + "',Model='" + comModel.Text + "',Name='" + txtname.Text + "',Price='" + txtPrice.Text + "',Quantity='" + txtQuantity.Text + "' WHERE Itemid='" + txtid.Text + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            con.Close();
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
                string cmbSearch = comsearchType.SelectedItem.ToString();
                DataView dv = new DataView(dt, cmbSearch + " LIKE '" + txtsearch.Text + "*' ", cmbSearch, DataViewRowState.CurrentRows);
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }
        //display the data form gridview into the input fields
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtname.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells["Itemid"].Value.ToString();
            comBrand.Text = dataGridView1.CurrentRow.Cells["Brand"].Value.ToString();
            comModel.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            txtQuantity.Text = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
        }

        //delete parts 
        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlCommand sqlcom = new SqlCommand("DELETE part WHERE Itemid='" + txtid.Text + "' ", con);
            con.Open();

            sqlcom.ExecuteNonQuery();

            MessageBox.Show("Vachile Deleted", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

            dt = partgrid();
            dataGridView1.DataSource = dt;
        }

        //link to dashboard 
        private void btnDashBoard_Click_1(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard(usertype);
            frm.Show();
            this.Hide();
        }
        //link to ManageCar form
        private void btnCar_Click(object sender, EventArgs e)
        {
            ManageCar frm = new ManageCar(usertype);
            frm.Show();
            this.Hide();
        }
        //link to ManageParts form
        private void btnparts_Click(object sender, EventArgs e)
        {
            ManageParts frm = new ManageParts(usertype);
            frm.Show();
            this.Hide();
        }
        //link to ManageCustomer form
        private void btncustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer frm = new ManageCustomer(usertype);
            frm.Show();
            this.Hide();
        }
        //link to ManageOrder form
        private void btnorder_Click(object sender, EventArgs e)
        {
            ManagOrder frm = new ManagOrder(usertype);
            frm.Show();
            this.Hide();
        }
        //link to sales form
        private void btnsales_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales(usertype);
            frm.Show();
            this.Hide();
        }
        //link Reports form
        private void btnreport_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports(usertype);
            frm.Show();
            this.Hide();
        }
        //limk Bakcup form
        private void btnbackup_Click(object sender, EventArgs e)
        {
            Backup frm = new Backup(usertype);
            frm.Show();
            this.Hide();
        }
     
      
    }
}
