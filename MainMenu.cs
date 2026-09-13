using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            this.btnDashboard.Checked = true;
            this.dashboardPanel.BringToFront();
        }

        private void guestsPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnRooms_Click_1(object sender, EventArgs e)
        {
            this.btnRooms.Checked = true;
            this.roomsPanel.BringToFront();
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            this.btnGuests.Checked = true;
            this.guestsPanel.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.btnDashboard.Checked = true;
            this.dashboardPanel.BringToFront();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.btnUsers.Checked = true;
            this.usersPanel.BringToFront();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            this.btnReservations.Checked = true;
            this.reservationsPanel.BringToFront();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            this.btnCheckIn.Checked = true;
            this.checkInPanel.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.btnCheckOut.Checked = true;
            this.checkOutPanel.BringToFront();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.btnReports.Checked = true;
            this.reportsPanel.BringToFront();
        }
    }
}
