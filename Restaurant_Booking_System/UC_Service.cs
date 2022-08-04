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
    public partial class UC_Service : UserControl
    {
        Restaruant_Booking_DBTableAdapters.ServiceTableAdapter Service = new Restaruant_Booking_DBTableAdapters.ServiceTableAdapter();
        Restaruant_Booking_DBTableAdapters.ServicetypeTableAdapter ServiceType = new Restaruant_Booking_DBTableAdapters.ServicetypeTableAdapter();
        string ServiceTypeID;
        string ImgLocation;

        public UC_Service()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text == "")
            {
                MessageBox.Show("Please enter servic name");
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter Price");
            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Please enter description");
            }
            else
            {
                int sqlQuery = Service.InsertQuery(lblService_ID.Text, txtServiceName.Text, ServiceTypeID, Convert.ToInt32(txtPrice.Text), ImgLocation, txtDescription.Text);
                if (sqlQuery > 0)
                {
                    MessageBox.Show("Service Save Sucessful");
                    ClearData();
                    AutoServiceID();
                }
            }
        }
        // .....For Auto Generate ID .....//
        public void AutoServiceID()
        {
            DataTable dt = new DataTable();
            dt = Service.GetData();
            if (dt.Rows.Count == 0)
            {
                lblService_ID.Text = "S_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    lblService_ID.Text = "S_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblService_ID.Text = "S_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblService_ID.Text = "S_" + (newid + 1);
                }
            }
        }
        public void ClearData()
        {
            txtServiceName.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            cboServiceTypeID.SelectedIndex = 0;
          
        }
        //.....To select service type in combo box ......//
        public void ChooseServiceType()
        {
            DataTable dt = new DataTable();
            dt = ServiceType.GetData();
            if (dt.Rows.Count > 0)
            {
                DataRow R = dt.NewRow();
                R[0] = 0;
                R[1] = "Choose Service Type";
                dt.Rows.InsertAt(R, 0);
                cboServiceTypeID.DataSource = dt;
                cboServiceTypeID.ValueMember = "ServiceTypeName";
            }
        }

        private void UC_Service_Load(object sender, EventArgs e)
        {
            AutoServiceID();
            ChooseServiceType();
        }

        //.....Count data in combo box...//
        private void cboServiceTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = cboServiceTypeID.SelectedValue.ToString();
            DataTable dt = new DataTable();
            dt = ServiceType.CheckServiceName(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ServiceTypeID = dt.Rows[0][0].ToString();
            }
        }

        //....To add image location....//
        private void btnUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImgLocation = openFileDialog.FileName.ToString();
                picBox.ImageLocation = ImgLocation;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
