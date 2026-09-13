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
    public partial class AddEditGuest : Form
    {
        private int guestID = 0;

        string[] Gender = ["Male", "Female"];
        string[] ValidID = ["Voter's ID", "National ID", "Driver's License"];
        string[] Nationality = ["Filipino", "American", "European","Japanese","Chinese","Others"];

        public AddEditGuest()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Guest guest = new()
            {
                GuestsID = this.guestID,
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

            var repo = new GuestService();

            if (guestID == 0)
            {
                string message = repo.AddGuest(guest);
                MessageBox.Show(message);
            }
            else
            {
                string message = repo.UpdateGuest(guest);
                MessageBox.Show(message);
            }
            
            this.DialogResult = DialogResult.OK;
        }
        public void UpdateGuest(Guest guest)
        {
            this.lbTitle.Text = "Update Guest";
            this.btnSave.Text = "Update Guest";

            this.tbFirstName.Text = guest.FirstName;
            this.tbLastName.Text = guest.LastName;
            this.cbGender.Text = guest.Gender;
            this.birthDate.Value = guest.Birthdate;
            this.tbPhone.Text = guest.Phone;
            this.tbEmail.Text = guest.Email;
            this.tbAddress.Text = guest.Address;
            this.cbNationality.Text = guest.Nationality;
            this.cbValidID.Text = guest.ValidID;

            this.guestID = guest.GuestsID;
        }
    }
}
