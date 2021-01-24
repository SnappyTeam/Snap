// https://github.com/SnappyTeam/Snap

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using iTunesLib;
using System.Diagnostics;

namespace Snap
{
    public partial class About : Form
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(String Class, string Window);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr Handle, String String, int Max);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr Handle, StringBuilder StringBuilder, int Max);

        public ContextMenu SnapOptions;
        public MenuItem VersionDetail;
        public MenuItem Seperator;
        public MenuItem BasedDetail;

        public MenuItem WinampMenu;
        public MenuItem VLCMenu;
        public MenuItem FooBar2000Menu;
        public MenuItem iTunesMenu;
        public MenuItem MusicBee;
        public MenuItem Clementine;

        public MenuItem SeperatorAgain;
        public MenuItem ShowWindow;

        public Process ClementineProcess;

        public About()
        {
            InitializeComponent();

            SnapOptions = new ContextMenu();
            VersionDetail = new MenuItem();
            BasedDetail = new MenuItem();
            Seperator = new MenuItem();
            SeperatorAgain = new MenuItem();
            ShowWindow = new MenuItem();

            WinampMenu = new MenuItem();
            VLCMenu = new MenuItem();
            FooBar2000Menu = new MenuItem();
            iTunesMenu = new MenuItem();
            MusicBee = new MenuItem();
            Clementine = new MenuItem();


            SnapMenu.ContextMenu = SnapOptions;
            SnapOptions.MenuItems.AddRange(new MenuItem[] { VersionDetail });
            SnapOptions.MenuItems.AddRange(new MenuItem[] { BasedDetail });
            SnapOptions.MenuItems.AddRange(new MenuItem[] { Seperator });

            SnapOptions.MenuItems.AddRange(new MenuItem[] { WinampMenu });
            SnapOptions.MenuItems.AddRange(new MenuItem[] { VLCMenu });
            SnapOptions.MenuItems.AddRange(new MenuItem[] { FooBar2000Menu });
            SnapOptions.MenuItems.AddRange(new MenuItem[] { iTunesMenu });
            SnapOptions.MenuItems.AddRange(new MenuItem[] { MusicBee });
            SnapOptions.MenuItems.AddRange(new MenuItem[] { Clementine });

            SnapOptions.MenuItems.AddRange(new MenuItem[] { SeperatorAgain });
            SnapOptions.MenuItems.AddRange(new MenuItem[] { ShowWindow });

            VersionDetail.Index = 0;
            VersionDetail.Enabled = false;
            VersionDetail.Text = "Snap = " + Application.ProductVersion.ToString();

            BasedDetail.Enabled = false;
            BasedDetail.Text = "Inspired By Snip By dlrudie";

            Seperator.Text = "-";

            WinampMenu.Text = "Winamp";
            VLCMenu.Text = "VLC Media Player";
            FooBar2000Menu.Text = "FooBar2000";
            iTunesMenu.Text = "iTunes";
            MusicBee.Text = "MusicBee";
            Clementine.Text = "Clementine";

            WinampMenu.Click += WinampMenu_Click;
            VLCMenu.Click += VLCMenu_Click;
            FooBar2000Menu.Click += FooBar2000Menu_Click;
            iTunesMenu.Click += iTunesMenu_Click;
            MusicBee.Click += MusicBee_Click;
            Clementine.Click += Clementine_Click;

            SeperatorAgain.Text = "-";

            ShowWindow.Text = "Show About Window";
            ShowWindow.Click += ShowWindow_Click;

            SnapMenu.ContextMenu = SnapOptions;
        }

        private void Clementine_Click(object sender, EventArgs e)
        {
            Clementine.Checked ^= true;

            if(Clementine.Checked == true)
            {
                VLCMenu.Checked = false;
                FooBar2000Menu.Checked = false;
                iTunesMenu.Checked = false;
                WinampMenu.Checked = false;
                Clementine.Checked = true;
                MusicBee.Checked = false;

                Winamp.Stop();
                VLC.Stop();
                FooBar2000.Stop();
                iTunes.Stop();
                MusicBeeSupport.Stop();
                ClementineSupport.Start();
            }
            else
            {
                return;
            }
        }

        private void MusicBee_Click(object sender, EventArgs e)
        {
            MusicBee.Checked ^= true;

            if(MusicBee.Checked == true)
            {
                VLCMenu.Checked = false;
                FooBar2000Menu.Checked = false;
                iTunesMenu.Checked = false;
                WinampMenu.Checked = false;
                Clementine.Checked = false;
                MusicBee.Checked = true;

                Winamp.Stop();
                VLC.Stop();
                FooBar2000.Stop();
                iTunes.Stop();
                MusicBeeSupport.Start();
                ClementineSupport.Stop();
            }
            else
            {
                return;
            }
        }

        private void ShowWindow_Click(Object sedner, EventArgs e)
        {
            Show();
        }

        private void iTunesMenu_Click(object sender, EventArgs e)
        {
            iTunesMenu.Checked ^= true;

            if(iTunesMenu.Checked == true)
            {
                VLCMenu.Checked = false;
                FooBar2000Menu.Checked = false;
                iTunesMenu.Checked = true;
                WinampMenu.Checked = false;
                Clementine.Checked = false;
                MusicBee.Checked = false;

                Winamp.Stop();
                VLC.Stop();
                FooBar2000.Stop();
                iTunes.Start();
                MusicBeeSupport.Stop();
                ClementineSupport.Stop();
            }
            else
            {
                return;
            }
        }

        private void FooBar2000Menu_Click(object sender, EventArgs e)
        {
            FooBar2000Menu.Checked ^= true;

            if(FooBar2000Menu.Checked == true)
            {
                VLCMenu.Checked = false;
                FooBar2000Menu.Checked = true;
                iTunesMenu.Checked = false;
                WinampMenu.Checked = false;
                Clementine.Checked = false;
                MusicBee.Checked = false;

                Winamp.Stop();
                VLC.Stop();
                FooBar2000.Start();
                iTunes.Stop();
                MusicBeeSupport.Stop();
                ClementineSupport.Stop();
            }
            else
            {
                return;
            }
        }

        private void VLCMenu_Click(object sender, EventArgs e)
        {
            VLCMenu.Checked ^= true;

            if(VLCMenu.Checked == true)
            {
                VLCMenu.Checked = true;
                FooBar2000Menu.Checked = false;
                iTunesMenu.Checked = false;
                WinampMenu.Checked = false;
                Clementine.Checked = false;
                MusicBee.Checked = false;

                Winamp.Stop();
                VLC.Start();
                FooBar2000.Stop();
                iTunes.Stop();
                MusicBeeSupport.Stop();
                ClementineSupport.Stop();
            }
            else
            {
                return;
            }
        }

        private void WinampMenu_Click(object sender, EventArgs e)
        {
            WinampMenu.Checked ^= true;

            if(WinampMenu.Checked == true)
            {
                VLCMenu.Checked = false;
                FooBar2000Menu.Checked = false;
                iTunesMenu.Checked = false;
                Clementine.Checked = false;
                MusicBee.Checked = false;

                Winamp.Start();
                VLC.Stop();
                FooBar2000.Stop();
                iTunes.Stop();
                MusicBeeSupport.Stop();
                ClementineSupport.Stop();
            }
            else
            {
                return;
            }
        }

        private void About_Load(object sender, EventArgs e)
        {
            ProgramVersion.Text = Application.ProductVersion.ToString();

            if(File.Exists("CurrentSong.txt") == true)
            {
                return;
            }
            else
            {
                File.Create("CurrentSong.txt");
            }
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Winamp_Tick(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists("CurrentSong.txt") == true)
                {
                    IntPtr WinampWindow = FindWindow("Winamp v1.x", null);
                    string CurrentSong = new string((char)0, 100);
                    int WindowTitle = GetWindowText(WinampWindow, CurrentSong, CurrentSong.Length);

                    if(WinampWindow.Equals(IntPtr.Zero))
                    {
                        File.WriteAllText("CurrentSong.txt", "");
                    }
                    else
                    {
                        File.WriteAllText("CurrentSong.txt", CurrentSong.Replace("- Winamp", "").Replace("[Paused]", "").Replace("[Stopped]", "").ToString());
                    }
                }
                else
                {
                    File.Create("CurrentSong.txt");
                    Thread.Sleep(1000);
                    Application.Restart();
                }
            }
            catch
            {
                Environment.Exit(1);
            }
        }

        private void FooBar2000_Tick(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists("CurrentSong.txt") == true)
                {
                    IntPtr FooBarWindow = FindWindow("{97E27FAA-C0B3-4b8e-A693-ED7881E99FC1}", null);
                    string CurrentSong = new string((char)0, 100);
                    int WindowTitle = GetWindowText(FooBarWindow, CurrentSong, CurrentSong.Length);

                    if(FooBarWindow.Equals(IntPtr.Zero))
                    {
                        File.WriteAllText("CurrentSong.txt", "");
                    }
                    else
                    {
                        File.WriteAllText("CurrentSong.txt", CurrentSong.Replace("[foobar2000]", "").ToString());
                    }
                }
                else
                {
                    File.Create("CurrentSong.txt");
                    Thread.Sleep(1000);
                    Application.Restart();
                }
            }
            catch
            {
                Environment.Exit(1);
            }
        }

        private void VLC_Tick(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists("CurrentSong.txt") == true)
                {
                    IntPtr VLCWindow = FindWindow("Qt5QWindowIcon", null);
                    string CurrentSong = new string((char)0, 100);
                    int WindowTitle = GetWindowText(VLCWindow, CurrentSong, CurrentSong.Length);

                    if(VLCWindow.Equals(IntPtr.Zero))
                    {
                        File.WriteAllText("CurrentSong.txt", "");
                    }
                    else
                    {
                        File.WriteAllText("CurrentSong.txt", CurrentSong.Replace("- VLC media player", "").Replace(".mp3", "").Replace(".wav", "").Replace(".mp4", ""));
                    }
                }
                else
                {
                    File.Create("CurrentSong.txt");
                    Thread.Sleep(1000);
                    Application.Restart();
                }
            }
            catch
            {
                Environment.Exit(1);
            }
        }

        private void iTunes_Tick(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists("CurrentSong.txt") == true)
                {
                    iTunesApp iTunes = new iTunesApp();
                    IITTrack Track = iTunes.CurrentTrack;
                    if(Track == null)
                    {
                        File.WriteAllText("CurrentSong.txt", "");
                    }
                    else
                    {
                        File.WriteAllText("CurrentSong.txt", Track.Name);
                    }
                }
                else
                {
                    File.Create("CurrentSong.txt");
                    Thread.Sleep(1000);
                    Application.Restart();
                }
            }
            catch
            {
                Environment.Exit(1);
            }
        }

        private void MusicBeeSupport_Tick(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists("CurrentSong.txt") == true)
                {
                    IntPtr MusicBeeWindow = FindWindow("WindowsForms10.Window.8.app.0.2bf8098_r7_ad1", null);
                    string CurrentSong = new string((char)0, 100);
                    int WindowTitle = GetWindowText(MusicBeeWindow, CurrentSong, CurrentSong.Length);

                    if(MusicBeeWindow.Equals(IntPtr.Zero))
                    {
                        File.WriteAllText("CurrentSong.txt", "");
                    }
                    else
                    {
                        File.WriteAllText("CurrentSong.txt", CurrentSong.Replace("- MusicBee", "").ToString());
                    }
                }
                else
                {
                    File.Create("CurrentSong.txt");
                    Thread.Sleep(1000);
                    Application.Restart();
                }
            }
            catch
            {
                Environment.Exit(1);
            }
        }

        private void ClementineSupport_Tick(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists("CurrentSong.txt") == true)
                {
                    Process[] ProcessListed = Process.GetProcesses();
                    
                    foreach(Process Process in ProcessListed)
                    {
                        if(String.IsNullOrEmpty(Process.MainWindowTitle) == false)
                        {
                            if(Process.MainWindowTitle.Contains(".mp3"))
                            {
                                File.WriteAllText("CurrentSong.txt", Process.MainWindowTitle.ToString());
                            }
                            else
                            {
                                if(Process.MainWindowTitle.Contains(".wav"))
                                {
                                    File.WriteAllText("CurrentSong.txt", Process.MainWindowTitle.ToString());
                                }
                                else
                                {
                                    if(Process.MainWindowTitle.Contains(".mp3"))
                                    {
                                        File.WriteAllText("CurrentSong.txt", Process.MainWindowTitle.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    File.Create("CurrentSong.txt");
                    Thread.Sleep(1000);
                    Application.Restart();
                }
            }
            catch
            {
                Environment.Exit(1);
            }
        }
    }
}
