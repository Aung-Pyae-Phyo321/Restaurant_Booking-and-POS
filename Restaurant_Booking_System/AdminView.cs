﻿using System;
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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
            UC_BookingList bookingList = new UC_BookingList();
            addUserControl(bookingList);

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelShow.Controls.Clear();
            PanelShow.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnBookingList_Click(object sender, EventArgs e)
        {
            UC_BookingList bookingList = new UC_BookingList();
            addUserControl(bookingList);
        }

        private void btnServiceType_Click(object sender, EventArgs e)
        {
            UC_ServiceType serviceType = new UC_ServiceType();
            addUserControl(serviceType);
        }

        private void btnServie_Click(object sender, EventArgs e)
        {
            UC_Service service = new UC_Service();
            addUserControl(service);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
