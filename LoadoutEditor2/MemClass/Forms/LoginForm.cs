using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using YourNameSpace;

namespace Main
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Removed KeyAuth related functionality
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            // Hardcoded username and password check (i have not added keyauth to this its just an example)
            if (Username.Text == "Skysserpent" && Password.Text == "Winter2012")
            {
                CustomMessageBox.Show("Login Success", "Success");
                this.Hide();
                Multiloader f2 = new Multiloader();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                CustomMessageBox.Show("Wrong Login kys");
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
                this.Hide();
                RegisterPage f2 = new RegisterPage();
                f2.ShowDialog();
                this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
