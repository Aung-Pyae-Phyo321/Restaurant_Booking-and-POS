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
    public partial class UC_CustomerHomePage : UserControl
    {
        Restaruant_Booking_DBTableAdapters.ReviewTableAdapter review = new Restaruant_Booking_DBTableAdapters.ReviewTableAdapter();
        string id;

        public UC_CustomerHomePage()
        {
            InitializeComponent();
        }

        public void AutoReviewID()
        {
            DataTable dt = new DataTable();
            dt = review.GetData();
            if (dt.Rows.Count == 0)
            {
                id = "R_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    id = "R_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    id = "R_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    id = "R_" + (newid + 1);
                }
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if (txtReview.Text == "")
            {
                MessageBox.Show("Please Enter Review");
                txtReview.Focus();
            }
            else
            {
                string ReviewText = txtReview.Text;
                review.Insert(id, ReviewText, Customer.CustomerID);
                MessageBox.Show("Save Your Review");
                ReviewDtGrid.DataSource = review.GetData();
                ReviewDtGrid.Refresh();
                btnReview.Enabled = false;
                txtReview.Enabled = false;
            }
        }

        private void UC_CustomerHomePage_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + Customer.CustomerName;
            string CustomerId = Customer.CustomerID;
            ReviewDtGrid.DataSource = review.CheckReview(CustomerId);
            AutoReviewID();
        }
    }
}
