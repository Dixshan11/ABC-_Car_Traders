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

    public partial class Register : Form
    {
        //connection for the database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dixdi\source\repos\ABC_Car_Traders\ABC_Traders.mdf;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }
        //register user
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //check any user is already have the username 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*)FROM login WHERE user_name='" + txtusername.Text + "' ", con);
            //create datatable object as dt
            DataTable dt = new DataTable();
             //fill the data table 
            sda.Fill(dt);
            //check the data table had the record
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("This user name is already taken.please try again");
                Clear();
            }
            else
            {
                //check empty fileds
                if ((txtusername.Text == "") || (txtpassword.Text == "") || (txtConfirmPassword.Text == "") )
                {
                    MessageBox.Show("plese fill all the fields");
                }
                else
                {
                    //check password and conform password are matched
                    if (txtpassword.Text == txtConfirmPassword.Text)
                    {
                        //save the data into login table
                        SqlCommand cmd = new SqlCommand("INSERT INTO login(user_name,user_type,password)VALUES('" + txtusername.Text + "','" + "customer" + "','" + txtpassword.Text + "')", con);
                        //save the data into customer table
                        SqlCommand cmd2 = new SqlCommand("INSERT INTO customer(FirstName,LastName,PhoneNo,Address,Email,username)VALUES('" + txtfname.Text + "','" + txtlname.Text + "','" + txtPhoneNo.Text + "','" + txtAddress.Text + "','" + txtemail.Text + "','" + txtusername.Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Registered successfully...", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        //hide the login page and show the admin dashboard
                        Login loginpage = new Login();
                        loginpage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(" password not matched..");
                    }
                }
            }
        }

        //clear all input fields
        private void Clear()
        {
            txtusername.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
            txtemail.Text = "";
            txtpassword.Text = "";
            txtConfirmPassword.Text = "";
        }
        //someload events for passwords
        private void Register_Load(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            txtpassword.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
