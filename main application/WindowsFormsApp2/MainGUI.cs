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
            var client = new WebClient();
            var uri = new Uri("https://sourceforge.net/projects/classicshell/files/latest/download");
            client.DownloadFileCompleted += (sender, e) => install();
            client.DownloadFileAsync(uri, "classicshell.exe");
        }
        // trying to figure out how a add a couple seconds wait as a safety measure
        private static System.Timers.Timer aTimer;
        public void install()
        {
            Console.WriteLine("yeah");
            aTimer = new System.Timers.Timer();

            Console.WriteLine("yeahh");
        }
        //when button 1 is clicked downloadclassicshell function is called
        private void button1_Click(object sender, EventArgs e)
        {
            DownloadClassicShell();
        }

    }
}
