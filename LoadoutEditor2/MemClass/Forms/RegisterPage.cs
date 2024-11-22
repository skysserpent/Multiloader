using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNameSpace;

namespace Main
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f2 = new LoginForm();
            f2.ShowDialog();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Key.Text == "Nigger")
            {
                CustomMessageBox.Show("Login Success", "Success");
                this.Hide();
                Multiloader f2 = new Multiloader();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                CustomMessageBox.Show("Login Failed", "Failed");
                Environment.Exit(0);
            }
        }
    }
}
