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
    public partial class UC_CustomerProfile : UserControl
    {
        public UC_CustomerProfile()
        {
            InitializeComponent();
        }
        private void UC_CustomerProfile_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = Customer.CustomerName;
            lblPhoneNumber.Text = Customer.PhoneNumber;
            lblAddress.Text = Customer.Address;
            lblEmail.Text = Customer.CustomerEmail;
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}
