using HotelManagementSystem.Forms;
using HotelManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem.UserControls
{
    public partial class Rooms : UserControl
    {
        private readonly RoomService repo = new();

        private int pageSize = 20;
        private int currentPage = 1;
        private int totalRecords = 0;
        private int totalPages = 0;

        private int roomID = 0;

        public Rooms()
        {
            InitializeComponent();
            LoadPage();
        }

        private async void LoadPage()
        {
            string keyword = this.tbSearch.Text.Trim();

            totalRecords = await repo.RoomsCountAsync(keyword);
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            if (totalPages == 0)
                totalPages = 1;
            else if (currentPage > totalPages)
                currentPage = totalPages;

            var rooms = await repo.PaginatedRoomAsync(currentPage, pageSize, keyword);

            DataTable table = new();

            table.Columns.Add("Room ID");
            table.Columns.Add("Room No.");
            table.Columns.Add("Room Type");
            table.Columns.Add("Floor");
            table.Columns.Add("Capacity");
            table.Columns.Add("Price");
            table.Columns.Add("Status");

            foreach (var room in rooms)
            {
                var row = table.NewRow();

                row["Room ID"] = room.RoomID;
                row["Room No."] = room.RoomNumber;
                row["Room Type"] = room.RoomType.Name;
                row["Floor"] = room.Floor;
                row["Capacity"] = room.RoomType.Capacity;
                row["Price"] = "P" + room.RoomType.BasePrice;
                row["Status"] = room.Status;

                table.Rows.Add(row);
            }

            this.roomsGrid.DataSource = table;
            this.roomsGrid.Columns["Room ID"]?.Visible = false;

            int firsteRecord = totalRecords == 0
                ? 0
                : ((currentPage - 1) * pageSize) + 1;
            int lastRecord = Math.Min(currentPage * pageSize, totalRecords);

            this.lblPageInfo.Text = $"Showing {firsteRecord} to {lastRecord} of {totalRecords} entries";

            btnFirst.Enabled = currentPage > 1;
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditRoom form = new();

            if (form.ShowDialog() == DialogResult.OK)
                LoadPage();
        }

        private void btnRoomType_Click(object sender, EventArgs e)
        {
            RoomTypeForm form = new();

            form.ShowDialog();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this room?", "Delete", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No) return;

                string result = await repo.DeleteRoomAsync(roomID);
                MessageBox.Show(result);

                LoadPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void roomsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = roomsGrid.SelectedRows[0].Cells[0].Value?.ToString();

            if (selectedRow == null || selectedRow.Length <= 0) return;

            int id = int.Parse(selectedRow);
            this.roomID = id;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (roomID == 0)
                {
                    MessageBox.Show("Select row to update");
                    return;
                }
                    

                var room = await repo.GetRoomAsync(roomID);

                if (room == null) return;

                AddEditRoom form = new();

                await form.UpdateRoom(room);

                if (form.ShowDialog() == DialogResult.OK)
                    LoadPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void roomsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate_Click(sender, e);
        }
    }
}
