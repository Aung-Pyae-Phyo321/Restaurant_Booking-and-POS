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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminName.Text == "")
            {
                MessageBox.Show("Enter User Name", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if(txtAdminPw.Text == "")
            {
                MessageBox.Show("Enter Your Password", "Admin Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Focus();
            }
            else
            {
                string UserName, Password, CheckUser, CheckPassword;
                UserName = txtAdminName.Text;
                Password = txtAdminPw.Text;
                UserName = "";
                CheckUser = "Cherry";
                Password = "";
                CheckPassword = "abacd";
                if (txtAdminName.Text == CheckUser && txtAdminPw.Text == CheckPassword)
                {

                    AdminView ADView = new AdminView();
                    ADView.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain  = new frmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
