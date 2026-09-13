using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagementSystem.Forms;

namespace HotelManagementSystem.UserControls
{
    public partial class Reservations : UserControl
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditReservation form = new();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPage();
            }
        }

        private void LoadPage()
        {

        }
    }
}
