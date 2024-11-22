using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNameSpace;

namespace Main
{
    public partial class Multiloader : Form
    {
        public Multiloader()
        {
            InitializeComponent();
        }

        private void Multiloader_Load(object sender, EventArgs e)
        {
            // 800, 450 is the size of the multiloader
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            //761, 12
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Path.GetTempPath(), "gh_loader.exe");
            if (!File.Exists(exePath))
            {
                using (FileStream fs = new FileStream(exePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] exeBytes = Properties.Resources.gh_loader;
                    fs.Write(exeBytes, 0, exeBytes.Length);
                }
            }
            Process.Start(exePath);
            this.Close();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm f2 = new MainForm();
            f2.ShowDialog();
            this.Close();
        }

        private async void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            string fileUrl = "https://files.catbox.moe/n52zeh.bin"; 
            string tempFilePath = Path.Combine(Path.GetTempPath(), "downloadedfile.exe");
            using (WebClient client = new WebClient())
            {
                try
                {
                    await client.DownloadFileTaskAsync(new Uri(fileUrl), tempFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to download the file: " + ex.Message);
                    return;
                }
            }
            Process process = new Process();
            process.StartInfo.FileName = tempFilePath;
            process.StartInfo.UseShellExecute = true;
            process.Start();
            await Task.Run(() => process.WaitForExit());
            try
            {
                File.Delete(tempFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete the file: " + ex.Message);
            }
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            //25, 45 location
            //750, 360 size
        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Path.GetTempPath(), "gh_loader.exe");
            if (!File.Exists(exePath))
            {
                using (FileStream fs = new FileStream(exePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] exeBytes = Properties.Resources.gh_loader;
                    fs.Write(exeBytes, 0, exeBytes.Length);
                }
            }
            Process.Start(exePath);
            this.Close();
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm f2 = new MainForm();
            f2.ShowDialog();
            this.Close();
        }

        private async void guna2ImageButton6_Click(object sender, EventArgs e)
        {

            string fileUrl = "http://192.168.1.37:8080/Colorpicker-Portable-2.2.2.exe"; 
            string tempFilePath = Path.Combine(Path.GetTempPath(), "downloadedfile.exe");
            using (WebClient client = new WebClient())
            {
                try
                {
                    await client.DownloadFileTaskAsync(new Uri(fileUrl), tempFilePath);
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Failed to download the file: " + ex.Message);
                    return;
                }
            }
            Process process = new Process();
            process.StartInfo.FileName = tempFilePath;
            process.StartInfo.UseShellExecute = true;
            process.Start();
            await Task.Run(() => process.WaitForExit());
            try
            {
                File.Delete(tempFilePath);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Failed to delete the file: " + ex.Message);
            }
            this.Close();
        }

        private void guna2ImageButton12_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Path.GetTempPath(), "Support_remake.exe");
            if (!File.Exists(exePath))
            {
                using (FileStream fs = new FileStream(exePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] exeBytes = Properties.Resources.support_remake;
                    fs.Write(exeBytes, 0, exeBytes.Length);
                }
            }
            Process.Start(exePath);
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string exePath = Path.Combine(Path.GetTempPath(), "gh_loader.exe");
            if (!File.Exists(exePath))
            {
                using (FileStream fs = new FileStream(exePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] exeBytes = Properties.Resources.gh_loader;
                    fs.Write(exeBytes, 0, exeBytes.Length);
                }
            }
            Process.Start(exePath);
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm f2 = new MainForm();
            f2.ShowDialog();
            this.Close();
        }

        private async void guna2Button3_Click(object sender, EventArgs e)
        {

            string fileUrl = "http://192.168.1.37:8080/Colorpicker-Portable-2.2.2.exe";
            string tempFilePath = Path.Combine(Path.GetTempPath(), "downloadedfile.exe");
            using (WebClient client = new WebClient())
            {
                try
                {
                    await client.DownloadFileTaskAsync(new Uri(fileUrl), tempFilePath);
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Failed to download the file: " + ex.Message);
                    return;
                }
            }
            Process process = new Process();
            process.StartInfo.FileName = tempFilePath;
            process.StartInfo.UseShellExecute = true;
            process.Start();
            await Task.Run(() => process.WaitForExit());
            try
            {
                File.Delete(tempFilePath);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Failed to delete the file: " + ex.Message);
            }
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Path.GetTempPath(), "Support_remake.exe");
            if (!File.Exists(exePath))
            {
                using (FileStream fs = new FileStream(exePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] exeBytes = Properties.Resources.support_remake;
                    fs.Write(exeBytes, 0, exeBytes.Length);
                }
            }
            Process.Start(exePath);
            this.Close();
        }
    }
}
