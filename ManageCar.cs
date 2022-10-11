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
    public partial class ManageCar : Form
    {
        string usertype;
        //connection for the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
       
        public ManageCar(string usertype)
        {
            InitializeComponent();
            this.usertype = usertype;
        }

      //save the car details  
        private void btnSave_Click(object sender, EventArgs e)
        {
            //get the picturebox value 
            Image img = pictureBox1.Image;
            // craete an object for imageconverter
            ImageConverter imgconverter = new ImageConverter();
            var ConvertedImage = imgconverter.ConvertTo(img,typeof(byte[]));
            //save the car details is car table
            SqlCommand cmd = new SqlCommand("INSERT INTO car(Itemid,Brand,Model,Color,Price,Cc,EngNo,MadeBy,picture)VALUES('" + txtid.Text + "','" + comBrand.Text + "','" + comModel.Text + "','" + txtcolour.Text + "','" + txtPrice.Text + "','" + txtCc.Text + "','" + txtEngNo.Text + "','" + txtContry.Text + "','" +ConvertedImage+ "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //clear input fileds after submission 
            clear();
            dt = cargrid();
            //load the gridview afer add the data 
            dataGridView1.DataSource = dt;
            gridview();
        }

        // clear the input fields 
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
            pictureBox1.Image = null;
            con.Close();
        }

        // load the gridview when form is loaded 
        private void ManageCar_Load(object sender, EventArgs e)
        {

            dt = cargrid();
            dataGridView1.DataSource = dt;
            gridview();

        }

        //load the car details  in gridview
        public DataTable cargrid()
        {
            //create object for datatable
            DataTable dt = new DataTable();
            try
            {
                //select all the car form car table
                SqlCommand cmd = new SqlCommand("SELECT * FROM car ", con);
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
        
        //clear data when click clear button
      private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
    // some gridview modifications
        void gridview()
        {
            dataGridView1.Columns["picture"].Visible = false;
            dataGridView1.Columns["EngNo"].Width = 80;
            dataGridView1.Columns["EngNo"].HeaderText = "Engine Number";
            dataGridView1.Columns["Cc"].HeaderText = "CC";
            dataGridView1.Columns["EngNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }
      
        //search in gridview
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (comsearchType.SelectedIndex <0)
            {
                return;
            }
            try
            {                
                string cmbSearch = comsearchType.SelectedItem.ToString();
                DataView dv = new DataView(dt,cmbSearch+" LIKE '"+txtsearch.Text+"*' ",cmbSearch, DataViewRowState.CurrentRows);
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }

        //for update
        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE car SET Brand='" + comBrand.Text + "',Model='" + comModel.Text + "',Color='" + txtcolour.Text + "',Price='" + txtPrice.Text + "',Cc='" + txtCc.Text + "',EngNo='" + txtEngNo.Text + "',MadeBy='" + txtContry.Text + "' WHERE Itemid='" + txtid.Text + "' ", con);
            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Updated successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            clear();
            dt = cargrid();
            dataGridView1.DataSource = dt;
            gridview();
        }

        // for choose the image for cars 
        private void btnselectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Title = "Open Image";
            ofdlg.Filter = "Image Files(*.JPG;*.PNG,*.GIF)|*.JPG;*.PNG,*.GIF";

            if (ofdlg.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofdlg.FileName);
                    
            }
        }


        //when click the datatable single record it will show in the form
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtcolour.Text = dataGridView1.CurrentRow.Cells["Color"].Value.ToString();
            comBrand.Text = dataGridView1.CurrentRow.Cells["Brand"].Value.ToString();
            comModel.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            txtCc.Text = dataGridView1.CurrentRow.Cells["Cc"].Value.ToString();
            txtEngNo.Text = dataGridView1.CurrentRow.Cells["EngNo"].Value.ToString();
            txtContry.Text = dataGridView1.CurrentRow.Cells["MadeBy"].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells["Itemid"].Value.ToString();
        }

        //for  search the car with id or brand or model
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //chceck the car by id
            if (comsearchType.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*)FROM car WHERE Itemid='" + txtsearch.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM car WHERE Itemid='" + txtsearch.Text + "'", con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        txtid.Text = sdr[0].ToString();
                        comBrand.Text = sdr[1].ToString();
                        comModel.Text = sdr[2].ToString();
                        txtcolour.Text = sdr[3].ToString();
                        txtPrice.Text = sdr[4].ToString();
                        txtCc.Text = sdr[5].ToString();
                        txtEngNo.Text = sdr[6].ToString();
                        txtContry.Text = sdr[8].ToString();
                    }
                    con.Close();
                }
            }
            //check the var by model or brand
            else if (comsearchType.Text == "Brand" || comsearchType.Text == "Model")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*)FROM car WHERE  Brand='" + txtsearch.Text + "'OR Model='" + txtsearch.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM car WHERE  Brand='" + txtsearch.Text + "'OR Model='" + txtsearch.Text + "'", con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        txtid.Text = sdr[0].ToString();
                        comBrand.Text = sdr[1].ToString();
                        comModel.Text = sdr[2].ToString();
                        txtcolour.Text = sdr[3].ToString();

                        txtPrice.Text = sdr[4].ToString();
                        txtCc.Text = sdr[5].ToString();
                        txtEngNo.Text = sdr[6].ToString();
                        txtContry.Text = sdr[7].ToString();
                    }
                    con.Close();
                }
            }
        }
        // detele the car details 
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcom = new SqlCommand("DELETE car WHERE Itemid='" + txtid.Text + "' ", con);
            con.Open();

            sqlcom.ExecuteNonQuery();

            MessageBox.Show("vehicle Deleted", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

            dt = cargrid();
            dataGridView1.DataSource = dt;
        }

        // link to admindashboard
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AdminDashboard frm = new AdminDashboard(usertype);
            frm.Show();
            this.Hide();
        }
        //link to manage car 
        private void btnCar_Click(object sender, EventArgs e)
        {
            ManageCar frm = new ManageCar(usertype);
            frm.Show();
            this.Hide();
        }
        //link to manage parts
        private void btnparts_Click(object sender, EventArgs e)
        {
            ManageParts frm = new ManageParts(usertype);
            frm.Show();
            this.Hide();
        }
        //link to manage customer
        private void btncustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer frm = new ManageCustomer(usertype);
            frm.Show();
            this.Hide();
        }
        //linkto manage order
        private void btnorder_Click(object sender, EventArgs e)
        {
            ManagOrder frm = new ManagOrder(usertype);
            frm.Show();
            this.Hide();
        }
        //link to sales
        private void btnsales_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales(usertype);
            frm.Show();
            this.Hide();
        }
        //link to reports
        private void btnreport_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports(usertype);
            frm.Show();
            this.Hide();
        }
        //link to  backuo
        private void btnbackup_Click(object sender, EventArgs e)
        {

            Backup frm = new Backup(usertype);
            frm.Show();
            this.Hide();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
