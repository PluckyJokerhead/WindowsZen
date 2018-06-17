using System;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }
        //Allows the console to be shown later on
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

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

        //DOWNLOAD + INSTALL SOUNDSWITCH

        public void DownloadSoundSwitch()
        {
            Application.UseWaitCursor = true;
            var client = new WebClient();
            var uri = new Uri("https://github.com/Belphemur/SoundSwitch/releases/download/v4.9/SoundSwitch_v4.9.6733.39597_Release_Installer.exe");
            client.DownloadFileCompleted += (sender, e) => installSoundSwitch();
            client.DownloadFileAsync(uri, "soundswitch.exe");
        }

        public void installSoundSwitch()
        {
            Console.WriteLine("Downloaded soundswitch.exe");
            //wait 5 seconds
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(5) > DateTime.Now);
            //open the file
            Console.WriteLine("Opening it");
            Application.UseWaitCursor = false;
            System.Diagnostics.Process.Start("soundswitch.exe");
        }

        public void ProgramsWizard()
        {
            AllocConsole();
            bool video = false;
            bool music = false;
            bool photo = false;
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("This command line wizard will help you change the default applications for photos, videos and music to ones you prefer.");
            Console.WriteLine("#######################################################################################################################");
            while (video == false)
            {
                Console.WriteLine("Choose a video player:");
                Console.WriteLine("1: Windows 10 Default (Do not change)");
                Console.WriteLine("2: Windows Media Player");
                Console.WriteLine("3: VLC");
                Console.WriteLine("Enter an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("The video player will not be changed.");
                    video = true;
                }
                else if (option == 2)
                {
                    Console.WriteLine("Windows Media Player will be downloaded, the installer will be run, and it will be set as your default program.");
                    Console.WriteLine("Continue? (Y/N)");
                    string continue1 = (Console.ReadLine());
                    if (continue1 == "Y" || continue1 == "y")
                    {
                        //install wmp
                    }
                }
                else if (option == 3)
                {
                    Console.WriteLine("VLC media player will be downloaded, the installer will be run, and it will be set as your default program.");
                    Console.WriteLine("Continue? (Y/N)");
                    string continue1 = (Console.ReadLine());
                    if (continue1 == "Y" || continue1 == "y")
                    {
                        //install vlc
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid option. (1, 2 or 3");
                }
            }

        }

        //when button 1 is clicked downloadclassicshell function is called
        private void button1_Click(object sender, EventArgs e)
        {
            //CLASSIC SHELL
            DownloadClassicShell();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TELEMETRY
            System.Diagnostics.Process.Start("DisableTelemetry.reg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //FORCED UPDATES
            MessageBox.Show("NOTICE: This file will not change anything on Windows 10 Home. It won't break anything, but it won't change anything either.",
                "Notice");
            System.Diagnostics.Process.Start("DisableForcedUpdates.reg");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SOUNDSWITCH
            DownloadSoundSwitch();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CLASSIC SHELL CONFIG
            System.Diagnostics.Process.Start("Classic Shell Settings.reg");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //TAKE OWNERSHIP
            System.Diagnostics.Process.Start("takeownership.reg");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //ENABLE CORTANA
            System.Diagnostics.Process.Start("EnableCortana.reg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DISABLE CORTANA
            System.Diagnostics.Process.Start("DisableCortana.reg");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //SOUNDS
            DialogResult result1 = MessageBox.Show("WARNING: This feature is unstable and may not be successful. It could stop your sounds from working. Proceed?",
                "Warning",
                MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("Sounds\\changesounds.bat");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProgramsWizard();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // ENABLE ALL:
            //
            // Add box saying what it does + time or something

            //classic shell
            DownloadClassicShell();
            //telemetry
            System.Diagnostics.Process.Start("DisableTelemetry.reg");
            //forced updates
            MessageBox.Show("NOTICE: This file will not change anything on Windows 10 Home. It won't break anything, but it won't change anything either.",
                "Notice");
            System.Diagnostics.Process.Start("DisableForcedUpdates.reg");
            //soundswitch
            DownloadSoundSwitch();
            //classic shell settings
            System.Diagnostics.Process.Start("Classic Shell Settings.reg");
            //take ownership
            System.Diagnostics.Process.Start("takeownership.reg");
            //cortana ON
            System.Diagnostics.Process.Start("EnableCortana.reg");
            //cortana OFF
            System.Diagnostics.Process.Start("DisableCortana.reg");
            //sounds
            DialogResult result1 = MessageBox.Show("WARNING: This feature is unstable and may not be successful. It could stop your sounds from working. Proceed?",
                "Warning",
                MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("Sounds\\changesounds.bat");
            }
            //default programs
        }
    }
}
