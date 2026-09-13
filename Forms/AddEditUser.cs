using HotelManagementSystem.Interface;
using HotelManagementSystem.Model;
using HotelManagementSystem.Repositories;
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
    public partial class AddEditUser : Form
    {
        private readonly IUserService service;

        private int UserID = 0;

        private string[] role = ["Receptionist", "Admin"];
        public AddEditUser()
        {
            InitializeComponent();

            IUserRepo repo = new UserRepository();
            service = new UserService(repo);

            this.cbRole.DataSource = role;
            this.cbRole.SelectedItem = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddEditUser_Load(object sender, EventArgs e)
        {

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbShowPassword.Checked)
                this.tbPassword.UseSystemPasswordChar = false;
            else
                this.tbPassword.UseSystemPasswordChar = true;
        }

        public void UpdateUser(User user)
        {
            this.lblTitle.Text = "Update User";
            this.btnAddEdit.Text = "Update User";

            this.UserID = user.UserId;
            this.tbUsername.Text = user.Username;
            this.tbFullname.Text = user.FullName;
            this.tbPassword.Text = user.Password;
            this.cbRole.Text = user.Role;
        }

        private async void btnAddEdit_Click(object sender, EventArgs e)
        {
            User user = new()
            {
                UserId = this.UserID,
                Username = this.tbUsername.Text,
                FullName = this.tbUsername.Text,
                Password = this.tbPassword.Text,
                Role = this.cbRole.Text
            };

            if (UserID == 0)
            {
                string result = await service.AddUserAsync(user);
                MessageBox.Show(result);
            }
            else
            {
                string result = await service.UpdateUserAsync(user);
                MessageBox.Show(result);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
