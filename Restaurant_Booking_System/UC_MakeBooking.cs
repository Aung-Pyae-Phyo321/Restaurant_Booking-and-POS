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
    public partial class UC_MakeBooking : UserControl
    {
        Restaruant_Booking_DBTableAdapters.ViewServiceTableAdapter viewService = new Restaruant_Booking_DBTableAdapters.ViewServiceTableAdapter();
        Restaruant_Booking_DBTableAdapters.ServiceTableAdapter service = new Restaruant_Booking_DBTableAdapters.ServiceTableAdapter();
        Restaruant_Booking_DBTableAdapters.BookingDetailTableAdapter bookingDetail = new Restaruant_Booking_DBTableAdapters.BookingDetailTableAdapter();
        Restaruant_Booking_DBTableAdapters.BookingTableAdapter bookingTable = new Restaruant_Booking_DBTableAdapters.BookingTableAdapter();

        DataTable dataTable = new DataTable();
        string ServiceId;
        DataRow dataRow;
        string bookingId;
        public UC_MakeBooking()
        {
            InitializeComponent();
        }

        public void ChooseServiceType()
        {
            DataTable dt = new DataTable();
            dt = service.GetData();
            if (dt.Rows.Count > 0)
            {
                DataRow R = dt.NewRow();
                R[0] = 0;
                R[1] = "Choose Service";
                dt.Rows.InsertAt(R, 0);
                cboServiceTypeID.DataSource = dt;
                cboServiceTypeID.ValueMember = "ServiceName";
            }
        }
        public void AutoBookingID()
        {
            DataTable dt = new DataTable();
            dt = bookingDetail.GetData();
            if (dt.Rows.Count == 0)
            {
                lblBookingID.Text = "B_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;
                String oldid = dt.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    lblBookingID.Text = "B_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblBookingID.Text = "B_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblBookingID.Text = "B_" + (newid + 1);
                }
            }
        }

        public int totalAmount1()
        {
            int TotalAmount = 0;
            String BookingAmount;
            int TotalRow;
            TotalRow = dataTable.Rows.Count;
            for (int i = 0; i <= TotalRow - 1; i++)
            {
                BookingAmount = dataTable.Rows[i]["Service Amount"].ToString();
                TotalAmount += Convert.ToInt32(BookingAmount);
            }
            lblTotalAmount.Text = TotalAmount.ToString();
            return TotalAmount;
        }

        public int TotalQuantity1()
        {
            int TotalQuantity = 0;
            String BookingQuantity;
            int TotalRow;
            TotalRow = dataTable.Rows.Count;
            for (int i = 0; i <= TotalRow - 1; i++)
            {
                BookingQuantity = dataTable.Rows[i]["Service Quantity"].ToString();
                TotalQuantity += Convert.ToInt32(BookingQuantity);
            }
            lblServiceQuantity.Text = TotalQuantity.ToString();
            return TotalQuantity;
        }
        public void ServiceList()
        {
            dataRow = dataTable.NewRow();
            dataTable.Columns.Add("Booking ID").ToString();
            dataTable.Columns.Add("Service ID").ToString();
            dataTable.Columns.Add("Service Type").ToString();
            dataTable.Columns.Add("Service Name").ToString();
            dataTable.Columns.Add("Service Quantity").ToString();
            dataTable.Columns.Add("Service Price").ToString();
            dataTable.Columns.Add("Service Amount").ToString();
            dataGridView.Refresh();
            dataGridView.DataSource = dataTable;
        }

        private void UC_MakeBooking_Load(object sender, EventArgs e)
        {
            ChooseServiceType();
            AutoBookingID();
            ServiceList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            { 
                int UnitPrice, UnitQty;
                int TotalPrice;
                UnitPrice = Convert.ToInt32(lblServicePrice.Text);
                UnitQty = Convert.ToInt32(txtTotalUser.Text);
                TotalPrice = UnitQty * UnitPrice;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (Convert.ToString(row.Cells["Service Name"].Value) == cboServiceTypeID.Text)
                    {
                        row.Cells["Service Quantity"].Value = Convert.ToInt32(txtTotalUser.Text) + Convert.ToInt32(row.Cells["Service Quantity"].Value);
                        row.Cells["Service Amount"].Value = Convert.ToInt32(row.Cells["Service Price"].Value) * Convert.ToInt32(row.Cells["Service Quantity"].Value);
                        totalAmount1();
                        TotalQuantity1();
                        break;
                    }
                    else
                    {
                        dataRow = dataTable.NewRow();
                        dataRow["Booking ID"] = lblBookingID.Text;
                        dataRow["Service ID"] = ServiceId;
                        dataRow["Service Type"] = lblServiceType.Text;
                        dataRow["Service Name"] = cboServiceTypeID.Text;
                        dataRow["Service Quantity"] = txtTotalUser.Text;
                        dataRow["Service Price"] = lblServicePrice.Text;
                        dataRow["Service Amount"] = TotalPrice;
                        lblTotalAmount.Text = Convert.ToString(totalAmount1() + TotalPrice);
                        int i = 0;
                        i = Convert.ToInt32(txtTotalUser.Text);
                        lblServiceQuantity.Text = Convert.ToString(TotalQuantity1() + i);
                        dataTable.Rows.Add(dataRow);
                        dataGridView.Refresh();
                        dataGridView.DataSource = dataTable;
                        totalAmount1();
                        TotalQuantity1();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the user amount");
            }
        }

        private void cboServiceTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ServiceName = cboServiceTypeID.SelectedValue.ToString();
          
            DataTable dt = new DataTable();
            dt = viewService.CheckService(ServiceName);
           

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                lblServiceType.Text = dt.Rows[0][1].ToString();
                lblServicePrice.Text = dt.Rows[0][2].ToString();
                picBox.ImageLocation = dt.Rows[0]["ServiceImage"].ToString();
                ServiceId = dt.Rows[0][3].ToString();
            }
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            try
            {
                String Status = "Booking";
                int Totaluser = Convert.ToInt32(txtTotalUser.Text);
                bookingId = lblBookingID.Text;
                int TotalAmount = Convert.ToInt32(lblTotalAmount.Text);
                int TotalService = Convert.ToInt32(lblServiceQuantity.Text);
                string CustomerId = Customer.CustomerID;
                bookingTable.Insert(bookingId, Convert.ToDateTime(dateTimeConfirm.Value), CustomerId, Totaluser, TotalAmount, TotalService, Status);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    String BookingId = dataTable.Rows[i]["Booking ID"].ToString();
                    String ServiceID = dataTable.Rows[i]["Service ID"].ToString();
                    int ServiceQuantity = Convert.ToInt32(dataTable.Rows[i]["Service Quantity"].ToString());
                    int ServicePrice = Convert.ToInt32(dataTable.Rows[i]["Service Price"].ToString());
                    bookingDetail.Insert(BookingId, ServiceID, ServicePrice, ServiceQuantity);
                }
                MessageBox.Show("Thank you for Booking! Booking placed successfully!");
            
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Data");
            }

        }
        private void lblServiceType_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int deleterow = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows.RemoveAt(deleterow);
            totalAmount1();
            totalAmount1();
        }

        private void lblServicePrice_Click(object sender, EventArgs e)
        {

        }

       
    }
}
