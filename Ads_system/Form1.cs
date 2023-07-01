using Bunifu.UI.WinForms;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace Ads_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            string folderPath = @"D:\Face-ads\main\Male";

            Process.Start("explorer.exe", folderPath);


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string folderPath = "D:\\Face-ads\\main";
            string scriptPath = "main.py"; 

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = folderPath;
            process.StartInfo.Arguments = "/K python " + scriptPath; 

            process.Start();
        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            string folderPath = @"D:\Face-ads\main\Female";

            Process.Start("explorer.exe", folderPath);


        }
    }
}