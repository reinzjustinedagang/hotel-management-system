using HotelManagementSystem.Model;
using HotelManagementSystem.Services;
using HotelManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms
{
    public partial class AddEditRoom : Form
    {
        private readonly RoomService repo = new();
        private readonly RoomTypeService rtRepo = new();

        private readonly string[] status = ["Available", "Reserved", "Occupied", "Maintenance"];

        private int roomID = 0;

        public AddEditRoom()
        {
            InitializeComponent();
            _ = InitializeCombo();
            this.DialogResult = DialogResult.Cancel;
        }

        private async Task InitializeCombo()
        {
            List<RoomType> types = await rtRepo.GetRoomTypesAsync();

            this.cbStatus.DataSource = status;

            this.cbRoomType.DisplayMember = "Name";
            this.cbRoomType.ValueMember = "RoomTypeID";

            this.cbRoomType.DataSource = types;
        }

        public async Task UpdateRoom(Room room)
        {
            await InitializeCombo();

            this.lbTitle.Text = "Update Room";
            this.btnAddEdit.Text = "Update Room";

            this.roomID = room.RoomID;
            this.numRoomNum.Value = room.RoomNumber;
            this.cbRoomType.SelectedValue = room.RoomTypeID;
            this.numFloor.Value = room.Floor;
            this.cbStatus.SelectedItem = room.Status;
            this.tbDescription.Text = room.Description;
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbRoomType.SelectedItem is RoomType selected)
            {
                this.numCapacity.Value = selected.Capacity;
                this.numPrice.Value = selected.BasePrice;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = new()
                {
                    RoomID = this.roomID,
                    RoomNumber = (int)this.numRoomNum.Value,
                    RoomTypeID = Convert.ToInt32(this.cbRoomType.SelectedValue),
                    Floor = (int)this.numFloor.Value,
                    Status = this.cbStatus.Text,
                    Description = this.tbDescription.Text
                };

                if (roomID == 0)
                {
                    string result = await repo.AddRoomAsync(room);
                    MessageBox.Show(result);
                }
                else
                {
                    string result = await repo.UpdateRoomAsync(room);
                    MessageBox.Show(result);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
