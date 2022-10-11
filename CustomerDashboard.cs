using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CustomerDashboard : Form
    {
        string user;
        // get the username as function arguments
        public CustomerDashboard(string username)
        {
            InitializeComponent();
            user = username;

        }

        //link to the OderCar form
        private void btnOrderCar_Click(object sender, EventArgs e)
        {
            OderCar myform = new OderCar(user);
            myform.Show();
            this.Hide();
        }

        //link to the ShowCAr form
        private void btnShowCar_Click(object sender, EventArgs e)
        {
            ShowCar myform = new ShowCar(user);
            myform.Show();
            this.Hide();
        }

        //link to the CustomerDashboard form
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CustomerDashboard myform = new CustomerDashboard(user);
            myform.Show();
            this.Hide();
        }

        //link to the OderCar form
        private void btnOrderParts_Click(object sender, EventArgs e)
        {
            OrderParts myform = new OrderParts(user);
            myform.Show();
            this.Hide();
        }

        //link to the ShowParts form
        private void btnShowParts_Click(object sender, EventArgs e)
        {
            ShowParts myform = new ShowParts(user);
            myform.Show();
            this.Hide();
        }

        //link to the OrderHistory form
        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistory myform = new OrderHistory(user);
            myform.Show();
            this.Hide();
        }

        //link to the CustomerProfile form
        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile myform = new CustomerProfile(user);
            myform.Show();
            this.Hide();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
