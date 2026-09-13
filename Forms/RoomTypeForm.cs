using HotelManagementSystem.Model;
using HotelManagementSystem.Repositories;
using HotelManagementSystem.Services;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms
{
    public partial class RoomTypeForm : Form
    {
        private RoomTypeService repo = new();

        private int roomTypeID = 0;

        public RoomTypeForm()
        {
            InitializeComponent();
            LoadPage();
        }

        private async void LoadPage()
        {
            DataTable table = new();

            table.Columns.Add("Room Type ID");
            table.Columns.Add("Name");
            table.Columns.Add("Capacity");
            table.Columns.Add("Base Price");

            var roomTypes = await repo.GetRoomTypesAsync();

            foreach (var roomType in roomTypes)
            {
                var rows = table.NewRow();

                rows["Room Type ID"] = roomType.RoomTypeID;
                rows["Name"] = roomType.Name;
                rows["Capacity"] = roomType.Capacity;
                rows["Base Price"] = roomType.BasePrice;

                table.Rows.Add(rows);
            }

            this.roomTypeGrid.DataSource = table;

            ClearFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            RoomType roomType = new();
            roomType.Name = tbName.Text;
            roomType.Capacity = (int)numCapacity.Value;
            roomType.BasePrice = (int)numBasePrice.Value;

            string result = await repo.AddRoomTypesAsync(roomType);
            MessageBox.Show(result);

            LoadPage();
            ClearFields();

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this Room Type?", "Update", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            RoomType roomType = new();
            roomType.RoomTypeID = this.roomTypeID;
            roomType.Name = tbName.Text;
            roomType.Capacity = (int)numCapacity.Value;
            roomType.BasePrice= (int)numBasePrice.Value;

            string result = await repo.UpdateRoomTypesAsync(roomType);
            MessageBox.Show(result);

            LoadPage();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogresult = MessageBox.Show("Are you sure to delete this Room Type?", "Delete", MessageBoxButtons.YesNo);

                if (dialogresult == DialogResult.No) return;

                string result = await repo.DeleteRoomTypeAsync(roomTypeID);
                MessageBox.Show(result);

                LoadPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }

        }

        private async void roomTypeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = this.roomTypeGrid.SelectedRows[0]?.Cells[0]?.Value?.ToString();

            if (selectedRow == null || selectedRow.Length == 0) return;

            int id = int.Parse(selectedRow);

            roomTypeID = id;

            if (id == 0) return;

            var roomType = await repo.GetRoomTypeAsync(id);

            this.tbName.Text = roomType.Name;
            this.numCapacity.Value = roomType.Capacity;
            this.numBasePrice.Value = roomType.BasePrice;
        }

        private void ClearFields()
        {
            this.roomTypeID = 0;
            this.tbName.Text = "";
            this.numCapacity.Value = 0;
            this.numBasePrice.Value = 0;

            this.roomTypeGrid.CurrentCell = null;
            this.roomTypeGrid.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        
    }
}
