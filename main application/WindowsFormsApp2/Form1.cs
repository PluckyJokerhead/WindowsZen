using System;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;

namespace WindowsZen
{
    public partial class programs : Form
    {
        public programs()
        {
            InitializeComponent();
        }

        public void DownloadVLC()
        {
            Application.UseWaitCursor = true;
            var client = new WebClient();
            var uri = new Uri("https://get.videolan.org/vlc/3.0.3/win64/vlc-3.0.3-win64.exe");
            client.DownloadFileAsync(uri, "VLC.exe");
            client.DownloadFileCompleted += (sender, e) => installVLC();
        }

        public void installVLC()
        {
            Console.WriteLine("Downloaded VLC.exe");
            //wait 5 seconds
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(5) > DateTime.Now);
            //open the file
            Console.WriteLine("Opening it");
            Application.UseWaitCursor = false;
            System.Diagnostics.Process.Start("VLC.exe");
        }

        public void DownloadMusicBee()
        {
            Application.UseWaitCursor = true;
            var client = new WebClient();
            var uri = new Uri("https://www.mediafire.com/file/d3fr20dmkwp35aj/MusicBeeSetup_3_1_Update3.zip");
            client.DownloadFileAsync(uri, "musicbee.zip");
            client.DownloadFileCompleted += (sender, e) => installmusicbee();
        }

        public void installmusicbee()
        {
            Console.WriteLine("Downloaded musicbee");
            //wait 5 seconds
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(5) > DateTime.Now);
            //extract the file
            ZipFile.ExtractToDirectory("musicbee.zip", "musicbee");
            //open the file
            Console.WriteLine("Opening it");
            Application.UseWaitCursor = false;
            System.Diagnostics.Process.Start("musicbee\\MusicBeeSetup_3_1_Update3.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DownloadMusicBee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadVLC();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("windowsphotoviewer.reg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("remove windowsapps\\removegroovemusic.bat");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("remove windowsapps\\removemoviesandtv.bat");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("remove windowsapps\\removephotos.bat");
        }
    }
}
