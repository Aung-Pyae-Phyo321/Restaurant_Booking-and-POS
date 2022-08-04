using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Booking_System
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
            UC_MakeBooking makebooking = new UC_MakeBooking();
            addUserControl(makebooking);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelShowCus.Controls.Clear();
            panelShowCus.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnBooking_Click(object sender, EventArgs e)
        {
            UC_MakeBooking makeBooking = new UC_MakeBooking();
            addUserControl(makeBooking);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UC_CustomerProfile customerProfile = new UC_CustomerProfile();
            addUserControl(customerProfile);          
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_CustomerHomePage customerHomePage = new UC_CustomerHomePage();
            addUserControl(customerHomePage);
        }

        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            UC_BookingView bookingView = new UC_BookingView();
            addUserControl(bookingView);
        }

        private void btnStaffReg_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
