using HotelManagementSystem.Model;
using HotelManagementSystem.Repositories;
using HotelManagementSystem.Services;
using HotelManagementSystem.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem.Forms
{
    public partial class AddGuest : Form
    {
        public int NewGuestID {  get; private set; }

        string[] Gender = ["Male", "Female"];
        string[] ValidID = ["Voter's ID", "National ID", "Driver's License"];
        string[] Nationality = ["Filipino", "American", "European","Japanese","Chinese","Others"];

        public AddGuest()
        {
            InitializeComponent();
            InitializeComboBox();

            this.DialogResult = DialogResult.Cancel;
        }

        private void InitializeComboBox()
        {
            cbGender.Items.AddRange(Gender);
            cbGender.SelectedIndex = 0;
            cbValidID.Items.AddRange(ValidID);
            cbValidID.SelectedIndex = 0;
            cbNationality.Items.AddRange(Nationality);
            cbNationality.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Guest guest = new()
            {
                FirstName = this.tbFirstName.Text,
                LastName = this.tbLastName.Text,
                Gender = this.cbGender.SelectedIndex.ToString(),
                Birthdate = this.birthDate.Value,
                Phone = this.tbPhone.Text,
                Email = this.tbEmail.Text,
                Address = this.tbAddress.Text,
                Nationality = this.cbNationality.Text,
                ValidID = this.cbValidID.Text
            };

            var service = new GuestService();

            NewGuestID = await service.CreateAsync(guest);
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
