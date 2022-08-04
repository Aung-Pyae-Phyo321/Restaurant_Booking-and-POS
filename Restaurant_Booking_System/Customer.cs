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
    public partial class Customer : Form
    {
        Restaruant_Booking_DBTableAdapters.CustomerTableAdapter CustomerDB = new Restaruant_Booking_DBTableAdapters.CustomerTableAdapter();

        public Customer()
        {
            InitializeComponent();
        }
        private void PatientSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegistration CustomerReg = new CustomerRegistration();
            CustomerReg.Show();
            this.Close();
        }

       private int LogInCount = 0;
       public static string CustomerID, CustomerName, CustomerEmail, PhoneNumber, Address, Password, User_Name;

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LogInCount == 3)
            {
                MessageBox.Show("Login Fail");
                Application.Exit();
            }
            else  if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter UserName");
                txtUserName.Focus();
            }
            else if (txtCustomerPw.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                txtCustomerPw.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                string UserName, Password;
                UserName = txtUserName.Text;
                Password = txtCustomerPw.Text;
                dt = CustomerDB.CheckCustomer(UserName, Password);
                /*MessageBox.Show("Customer Login Successful")*/;
                
                if (dt.Rows.Count > 0)
                {
                    CustomerID = dt.Rows[0][0].ToString();
                    CustomerName = dt.Rows[0][1].ToString();
                    PhoneNumber = dt.Rows[0][5].ToString();
                    Address = dt.Rows[0][6].ToString();
                    User_Name = dt.Rows[0]["UserName"].ToString();
                    Password = dt.Rows[0]["Password"].ToString();
                    PhoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
                    CustomerEmail = dt.Rows[0]["Email"].ToString();
                    MessageBox.Show("Customer Login Successful");
                    CustomerDashboard customerDashboard = new CustomerDashboard();
                    customerDashboard.Show();
                    
                }
                else 
                {
                    LogInCount += 1;
                    MessageBox.Show("Invalid Login");
                } 
            }
        }
    }
}
