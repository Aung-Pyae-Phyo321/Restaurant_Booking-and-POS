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
    public partial class UC_BookingList : UserControl
    {
        Restaruant_Booking_DBTableAdapters.BookingTableAdapter booking = new Restaruant_Booking_DBTableAdapters.BookingTableAdapter();
        string bookingId;
        public UC_BookingList()
        {
            InitializeComponent();
        }

        private void UCBookingView_Load(object sender, EventArgs e)
        {
            dataGridViewBookingList.DataSource = booking.GetData();
            btnApprove.Enabled = false;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            int row = dataGridViewBookingList.CurrentCell.RowIndex;
            string BookingID = dataGridViewBookingList[0, row].Value.ToString();
            booking.UpdateQuery(BookingID);
            MessageBox.Show("Booking Confirm");
            dataGridViewBookingList.DataSource = booking.GetData();
            dataGridViewBookingList.Refresh();
        }

        private void dataGridViewBookingList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnApprove.Enabled = true;
            bookingId = dataGridViewBookingList.CurrentRow.Cells["BookingID"].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int row = dataGridViewBookingList.CurrentCell.RowIndex;
            string BookingID = dataGridViewBookingList[0, row].Value.ToString();
            booking.DeleteQuery(BookingID);
            MessageBox.Show("Booking Confirm");
            dataGridViewBookingList.DataSource = booking.GetData();
            dataGridViewBookingList.Refresh();
        }
    }
}
