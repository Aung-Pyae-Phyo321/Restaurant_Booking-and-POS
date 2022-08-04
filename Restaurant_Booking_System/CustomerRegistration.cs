using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Booking_System
{
    public partial class CustomerRegistration : Form
    {
        // Connect the DataBase
        Restaruant_Booking_DBTableAdapters.CustomerTableAdapter CustomerDB = new Restaruant_Booking_DBTableAdapters.CustomerTableAdapter();


        public CustomerRegistration()
        {
            InitializeComponent();
        }

        public void AutoCustomerID()
        {
            DataTable dt = new DataTable();
            dt = CustomerDB.GetData();
            if (dt.Rows.Count == 0)
            {
                lblCustomerID.Text = "C_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(2, 3));
                if (newid >= 1 && newid < 9)
                {
                    lblCustomerID.Text = "C_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblCustomerID.Text = "C0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblCustomerID.Text = "C" + (newid + 1);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Check_Registration();
        }
        public void Check_Registration()
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtEmail.Text);

            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Enter Customer Name", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtCustomerName.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Enter User Name", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtUserName.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Enter Phone Number", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtPhoneNumber.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter Email", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter Address", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtAddress.Focus();
            }
            else if (!match.Success)
            {
                MessageBox.Show(txtEmail.Text + " email formant is uncorrect", "Customer Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                // ....Cus = customer....

                ClassCustomer Cus = new ClassCustomer();
                Cus.Customer_ID = lblCustomerID.Text;
                Cus.Customer_Name = txtCustomerName.Text;
                Cus.User_Name = txtUserName.Text;
                Cus.password = txtPassword.Text;
                Cus.Phone_Number = txtPhoneNumber.Text;
                Cus.email = txtEmail.Text;
                Cus.address = txtAddress.Text;

                int data;
                data = CustomerDB.Insert(Cus.Customer_ID, Cus.Customer_Name, Cus.User_Name, Cus.password, Cus.Phone_Number, Cus.email, Cus.address);
                if (data > 0)
                {
                    MessageBox.Show("Register Save Sucessful", "Registration Foorm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                Customer Cu = new Customer();
                Cu.Show();
                this.Hide();
            }
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            AutoCustomerID();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerID_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }
    }
}
