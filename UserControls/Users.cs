using HotelManagementSystem.Forms;
using HotelManagementSystem.Interface;
using HotelManagementSystem.Repositories;
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
    public partial class Users : UserControl
    {
        private readonly IUserService service;

        private int userID = 0;

        int pageSize = 25;
        int currentPage = 1;
        int totalRecords = 0;
        int totalPages = 0;

        public Users()
        {
            InitializeComponent();

            IUserRepo repo = new UserRepository();
            service = new UserService(repo);

            LoadPage();
        }

        private async void LoadPage()
        {
            string keyword = this.tbSearch.Text.Trim();

            totalRecords = await service.GetUsersCountAsync(keyword);

            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            if (totalPages == 0)
                totalPages = 1;
            else if (currentPage > totalPages)
                currentPage = totalPages;

            var users = await service.GetPaginatedUsersAsync(pageSize, currentPage, keyword);

            DataTable table = new();

            table.Columns.Add("User ID");
            table.Columns.Add("Full Name");
            table.Columns.Add("Username");
            table.Columns.Add("Role");
            table.Columns.Add("Status");

            foreach (var user in users)
            {
                var rows = table.NewRow();

                rows["User ID"] = user.UserId;
                rows["Full Name"] = user.FullName;
                rows["Username"] = user.Username;
                rows["Role"] = user.Role;
                rows["Status"] = user.Status;

                table.Rows.Add(rows);
            }

            this.userTable.DataSource = table;

            int firstRecord = totalRecords == 0
                ? 0
                : ((currentPage - 1) * pageSize) + 1;

            int lastRecord = Math.Min(currentPage * pageSize, totalRecords);

            this.lblPageInfo.Text = $"Showing {firstRecord} to {lastRecord} of {totalRecords} entries";

            this.btnFirst.Enabled = currentPage > 1;
            this.btnPrev.Enabled = currentPage > 1;
            this.btnNext.Enabled = currentPage < totalPages;
            this.btnLast.Enabled = currentPage < totalPages;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditUser form = new AddEditUser();

            if (form.ShowDialog() == DialogResult.OK)
                LoadPage();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.btnSearch.Text == "Search")
            {
                string keyword = this.tbSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
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

        private void userTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedUser = this.userTable.SelectedRows[0].Cells[0].Value?.ToString();

            if (selectedUser == null || selectedUser.Length == 0) return;

            int id = int.Parse(selectedUser);
            this.userID = id;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            AddEditUser form = new AddEditUser();

            var user = await service.GetUserAsync(userID);
            if (user == null)
            {
                MessageBox.Show("Select a row you want to update");
                return;
            }

            form.UpdateUser(user);

            if (form.ShowDialog() == DialogResult.OK)
                LoadPage();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No) return;

            string result = await service.DeleteUserAsync(this.userID);
            MessageBox.Show(result);
        }
    }
}
