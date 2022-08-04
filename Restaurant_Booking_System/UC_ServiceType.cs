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
    public partial class UC_ServiceType : UserControl
    {
        Restaruant_Booking_DBTableAdapters.ServicetypeTableAdapter ServiceType = new Restaruant_Booking_DBTableAdapters.ServicetypeTableAdapter();  

        public UC_ServiceType()
        {
            InitializeComponent();
        }

        public void AutoServiceTypeID()
        {
            DataTable dt = new DataTable();
            dt = ServiceType.GetData();
            if (dt.Rows.Count == 0)
            {
                lblServiceType_ID.Text = "ST_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(3, 3));

                if (newid >= 1 && newid < 9)
                {
                    lblServiceType_ID.Text = "ST_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblServiceType_ID.Text = "ST_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblServiceType_ID.Text = "ST_" + (newid + 1);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ClassServiceType classServiceType = new ClassServiceType();
            classServiceType.ServiceType_ID = lblServiceType_ID.Text;
            classServiceType.Service_Name = txtServiceName.Text;

            if (txtServiceName.Text == "")
            {
                MessageBox.Show("Enter User Name", "Service Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            else
            {
                int data;
            data = ServiceType.Insert(classServiceType.ServiceType_ID, classServiceType.Service_Name);
                if (data > 0)
                {
                    MessageBox.Show("New Service Save Sucessful", "Service Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }          
        }

        private void UC_ServiceType_Load(object sender, EventArgs e)
        {
            AutoServiceTypeID();
        }

        private void lblServiceType_ID_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            lblServiceName.Text = "";         
        }
    }
}
