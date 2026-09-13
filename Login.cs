using HotelManagementSystem.Interface;
using HotelManagementSystem.Model;
using HotelManagementSystem.Repositories;
using HotelManagementSystem.Services;

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        private readonly IUserService service;

        public Login()
        {
            InitializeComponent();

            IUserRepo repo = new UserRepository();
            service = new UserService(repo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btnSignin_Click(object sender, EventArgs e)
        {
            
            string username = this.tbUsername.Text;
            string password = this.tbPassword.Text;

            User loggedUser = await service.Login(username, password);

            if (username == "" || password == "")
                MessageBox.Show("Username or Password is empty");
            else if (loggedUser == null)
                MessageBox.Show("Invalid Credentials");
            else
            {
                MessageBox.Show("Login successfully");
                MainMenu menu = new();

                menu.FormClosed += (s, args) => this.Close();

                menu.Show();
                this.Hide();
            }

            }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked) 
                this.tbPassword.UseSystemPasswordChar = false;
            else
                this.tbPassword.UseSystemPasswordChar = true;
        }
    }
}
