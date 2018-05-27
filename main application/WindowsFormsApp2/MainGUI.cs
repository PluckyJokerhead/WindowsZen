using System;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApp2
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }
        // Downloads classic shell and calls install function when complete
        public void DownloadClassicShell()
        {
            Application.UseWaitCursor = true;
            var client = new WebClient();
            var uri = new Uri("https://sourceforge.net/projects/classicshell/files/latest/download");
            client.DownloadFileCompleted += (sender, e) => installclassicshell();
            client.DownloadFileAsync(uri, "classicshell.exe");
        }

        public void installclassicshell()
        {
            Console.WriteLine("Downloaded classicshell.exe");
            //wait 5 seconds
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(5) > DateTime.Now);
            //open the file
            Console.WriteLine("Opening it");
            Application.UseWaitCursor = false;
            System.Diagnostics.Process.Start("classicshell.exe");
            warning1 dialog = new warning1();
            dialog.Show();
        }

        //when button 1 is clicked downloadclassicshell function is called
        private void button1_Click(object sender, EventArgs e)
        {
            DownloadClassicShell();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
