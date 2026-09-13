using HotelManagementSystem.Model;
using HotelManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms
{
    public partial class AddEditReservation : Form
    {

        private List<Guest> additionalGuest = new();
        private List<Guest> allGuestsCache;

        private readonly GuestService guestService = new();
        private readonly RoomTypeService roomTypeService = new();
        private readonly RoomService roomService = new();

        private string[] type = ["Adult", "Child"];
        private string[] status = ["Pending", "Confirmed", "Cancelled", "Checked In", "Check Out"];

        public AddEditReservation()
        {
            InitializeComponent();
        }

        private async Task InitializeCombo(int? selectedId = null)
        {
            List<Guest> guestList = await guestService.GetGuests();
            List<RoomType> roomTypeList = await roomTypeService.GetRoomTypesAsync();

            cbPrimaryGuest.DataSource = new List<Guest>(guestList);
            cbPrimaryGuest.DisplayMember = "FullName";
            cbPrimaryGuest.ValueMember = "GuestsID";
            cbPrimaryGuest.SelectedValue = -1;

            cbAdditionalGuest.DataSource = guestList;
            cbAdditionalGuest.DisplayMember = "FullName";
            cbAdditionalGuest.ValueMember = "GuestsID";
            cbAdditionalGuest.SelectedValue = -1;

            cbRoomType.DataSource = roomTypeList;
            cbRoomType.DisplayMember = "Name";
            cbRoomType.ValueMember = "RoomTypeID";

            cbStatus.DataSource = status;
            cbStatus.SelectedItem = 0;

            if (selectedId != null)
            {
                cbPrimaryGuest.SelectedValue = selectedId.Value;
            }
        }

        private async void btnAddGuest_Click(object sender, EventArgs e)
        {
            AddGuest form = new();

            if (form.ShowDialog() == DialogResult.OK)
            {
                int newGuestID = form.NewGuestID;

                await InitializeCombo(newGuestID);

                MessageBox.Show("Guest added and selected");
            }
        }

        private async void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbRoomType.SelectedItem is RoomType selected)
            {
                List<Room>? roomList = await roomService.GetRoomsByTypeAsync(selected.RoomTypeID);

                cbRoom.DisplayMember = "RoomNumber";
                cbRoom.ValueMember = "RoomID";

                cbRoom.DataSource = roomList;
                cbRoom.SelectedValue = -1;

                txtCapacity.Text = selected.Capacity.ToString();
                txtPrice.Text = "P" + selected.BasePrice.ToString("N2");
            }
        }

        private async void AddEditReservation_Load(object sender, EventArgs e)
        {
            allGuestsCache = await guestService.GetGuests();

            await InitializeCombo();
            SetupTable();
        }

        private void SetupTable()
        {
            additionalGuestTable.AutoGenerateColumns = false;
            additionalGuestTable.Columns.Clear();
            additionalGuestTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "FullName", Name = "FullName", FillWeight = 70 });

            var btnRemove = new DataGridViewButtonColumn { HeaderText = "", Text = "Remove", UseColumnTextForButtonValue = true, Name = "btnRemove", FillWeight = 30 };
            additionalGuestTable.Columns.Add(btnRemove);
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (cbAdditionalGuest.SelectedItem == null) return;

            var selected = (Guest)cbAdditionalGuest.SelectedItem;

            if (cbPrimaryGuest.SelectedValue != null && (int)cbPrimaryGuest.SelectedValue == selected.GuestsID)
            {
                MessageBox.Show("This is already the Primary Guest");
                return;
            }

            if (additionalGuest.Any(g => g.GuestsID == selected.GuestsID))
            {
                MessageBox.Show("Guest already added!");
                return;
            }

            additionalGuest.Add(selected);
            RefreshTable();
        }

        private void RefreshTable()
        {
            additionalGuestTable.DataSource = null;
            additionalGuestTable.DataSource = additionalGuest;


        }

        private void additionalGuestTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (additionalGuestTable.Columns[e.ColumnIndex].Name == "btnRemove")
            {
                var guestToRemove = additionalGuest[e.RowIndex];
                additionalGuest.Remove(guestToRemove);
                RefreshTable();
            }
        }

        private void btnAddNewGuestForAddtional_Click(object sender, EventArgs e)
        {
            var form = new AddGuest();

            if (form.ShowDialog() == DialogResult.OK)
            {
                int newID = form.NewGuestID;

                var newGuest = guestService.GetGuest(newID);

                if (newGuest == null) return;

                allGuestsCache.Add(newGuest);
                cbPrimaryGuest.DataSource = new List<Guest>(allGuestsCache);
                cbAdditionalGuest.DataSource = new List<Guest>(allGuestsCache);

                additionalGuest.Add(newGuest);
                RefreshTable();
            }
        }

        private void checkoutDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateNights();
        }

        private void checkinDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateNights();
        }

        private void CalculateNights()
        {
            DateTime checkIn = checkinDate.Value.Date;
            DateTime checkOut = checkoutDate.Value.Date;

            if (checkOut <= checkIn)
            {
                txtNights.Text = "0";
                return;
            }

            int nights = (checkOut - checkIn).Days;

            txtNights.Text = nights.ToString() == "1" ? nights.ToString() + " Night" : nights.ToString() + " Nights";
        }

    
    }
}
