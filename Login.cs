using HotelManagementSystem.Model;
using HotelManagementSystem.Services;

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            UserService user = new();
            string username = this.tbUsername.Text;
            string password = this.tbPassword.Text;

            User loggedUser = user.Login(username, password);

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
