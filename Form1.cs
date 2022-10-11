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
    public partial class Login : Form
    {
        //connection for the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // setthe password char as *
            txtpassword.PasswordChar = '*';
            txtpassword.MaxLength = 10;
        }

      
        // login code 
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
        //get the data from data base and store in SqlDataAdapter Object sda
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*)FROM login WHERE user_name='" + txtusername.Text + "' AND password='" + txtpassword.Text + "'AND user_type='" + comusertype.Text + "'", con);
        // create DataTable instance dt
            DataTable dt = new DataTable();
        // fill the data table with the value stored in the DataAdapter instance
            sda.Fill(dt);
        // check the data table has value or not
            if (dt.Rows[0][0].ToString() == "1")
            {
        // check the user is admin if admin show admin page
                if (comusertype.Text == "admin")
                {
                    AdminDashboard frm = new AdminDashboard(comusertype.Text);
                    frm.Show();
                    this.Hide();

                }
        // check the user is customer if user is customer show customer dashboard 
                else if (comusertype.Text == "customer")
                {
                    CustomerDashboard frm = new CustomerDashboard(txtusername.Text);
                    frm.Show();
                    this.Hide();
                }

            }
            else
            {
        // if user name or passsword not macth bring the error message to the user
                MessageBox.Show("Invalid user name or password");
                txtusername.Text = "";
                txtpassword.Text = "";
                comusertype.SelectedIndex = 0;
            }
        }

        // to close the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
        // to Open register form and hide the login page
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerpage = new Register();
            registerpage.Show();
            this.Hide();
        }

        

    }
}
