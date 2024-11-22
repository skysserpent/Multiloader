using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetCamo2_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

        // Uncomment and use the following method if needed
        // private void guna2Button2_Click(object sender, EventArgs e)
        // {
        //     Process.Start("https://link2");
        //     Process.Start("https://link2");
        // }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/plo1xmodz");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://e-z.bio/skysserpent");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/gmodz");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            // Multi-line message text
            string message = "Turn off your antivirus and run the support tool!!\n" +
                             "This is a Note\n" +
                             "https://discord.gg/plo1xmodz/";

            // Show the message box
            MessageBox.Show(message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void BytesChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}