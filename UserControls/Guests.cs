using HotelManagementSystem.Forms;
using HotelManagementSystem.Repositories;
using HotelManagementSystem.Services;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem.UserControls
{
    public partial class Guests : UserControl
    {
        private int pageSize = 20;
        private int currentPage = 1;
        private int totalRecords = 0;
        private int totalPages = 0;

        private readonly GuestService repo = new();
        public Guests()
        {
            InitializeComponent();

            LoadPage();
        }

        private void LoadPage()
        {
            string keyword = tbSearch.Text.Trim();

            totalRecords = repo.GetTotalGuestCount(keyword);

            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            // Make sure currentPage is always valid
            if (totalPages == 0)
                currentPage = 1;
            else if (currentPage > totalPages)
                currentPage = totalPages;

            var guests = repo.PaginatedGuest(currentPage, pageSize, keyword);

            DataTable dataTable = new();

            dataTable.Columns.Add("Guest ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Nationality");

            foreach (var guest in guests)
            {
                var row = dataTable.NewRow();

                row["Guest ID"] = guest.GuestsID;
                row["Name"] = guest.FirstName + " " + guest.LastName;
                row["Phone"] = guest.Phone;
                row["Email"] = guest.Email;
                row["Address"] = guest.Address;
                row["Nationality"] = guest.Nationality;

                dataTable.Rows.Add(row);
            }

            this.guestsGrid.DataSource = dataTable;

            int firstRecord = totalRecords == 0
                ? 0
                : ((currentPage - 1) * pageSize) + 1;

            int lastRecord = Math.Min(currentPage * pageSize, totalRecords);

            lblPageInfo.Text =
                $"Showing {firstRecord} to {lastRecord} of {totalRecords} entries";

            btnFirst.Enabled = currentPage > 1;
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;
        }

        private void btnUpdateGuest_Click(object sender, EventArgs e)
        {
            try
            {
                var val = this.guestsGrid.SelectedRows[0].Cells[0].Value.ToString();

                if (val == null || val.Length == 0) return;

                int guestId = int.Parse(val);

                var guest = repo.GetGuest(guestId);

                if (guest == null) return;

                AddEditGuest form = new();
                form.UpdateGuest(guest);

                if (form.ShowDialog() == DialogResult.OK)
                    LoadPage();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            AddEditGuest form = new();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPage();
            }
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            try
            {
                var val = this.guestsGrid.SelectedRows[0].Cells[0].Value.ToString();

                if (val == null || val.Length == 0) return;

                int guestId = int.Parse(val);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this guest?", "Delete Guest", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No) return;

                string message = repo.DeleteGuest(guestId);
                MessageBox.Show(message);

                LoadPage();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.btnSearch.Text == "Search")
            {
                string keyword = this.tbSearch.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Please enter a keyword");
                    return;
                }

                currentPage = 1;
                LoadPage();

                this.btnSearch.Text = "X";
            }
            else
            {
                this.tbSearch.Text = "";

                currentPage = 1;
                LoadPage();

                this.btnSearch.Text = "Search";
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadPage();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadPage();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guestsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
