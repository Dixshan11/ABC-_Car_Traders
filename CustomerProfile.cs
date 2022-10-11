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
    public partial class CustomerProfile : Form
    {
        // connection for the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        string user;
        public CustomerProfile(string username)
        {
            InitializeComponent();
                user = username;
        }

        //customer Profile 
        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            // get the current user from customer table
            SqlCommand cmd = new SqlCommand("SELECT * FROM customer WHERE username='" + user + "' ", con);
           
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            
            while (sdr.Read())
            {
           // set the user details in label
                lblfname.Text = sdr[1].ToString();
                lbllname.Text = sdr[2].ToString();
                lblphone.Text = sdr[3].ToString();          
                lbladdress.Text = sdr[4].ToString();
                lblemail.Text = sdr[5].ToString();      
            }

            con.Close();
        }
        //link to the admin dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CustomerDashboard myform = new CustomerDashboard(user);
            myform.Show();
            this.Hide();
        }
        //link to the ShowCar form
        private void btnShowCar_Click(object sender, EventArgs e)
        {
            ShowCar myform = new ShowCar(user);
            myform.Show();
            this.Hide();
        }

        //link to OderCar form
        private void btnOrderCar_Click(object sender, EventArgs e)
        {
            OderCar myform = new OderCar(user);
            myform.Show();
            this.Hide();
        }
    //link to ShowParts form
        private void btnShowParts_Click(object sender, EventArgs e)
        {
            ShowParts myform = new ShowParts(user);
            myform.Show();
            this.Hide();
        }

        //link to OderParts form
        private void btnOrderParts_Click(object sender, EventArgs e)
        {
            OrderParts myform = new OrderParts(user);
            myform.Show();
            this.Hide();
        }

        //link to OderHistory form
        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistory myform = new OrderHistory(user);
            myform.Show();
            this.Hide();
        }

        // link to the CustomerProfile
        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile myform = new CustomerProfile(user);
            myform.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
