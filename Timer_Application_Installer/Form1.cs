﻿using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Timer_Application_Installer
{
    public partial class Installer : Form
    {       
        readonly string fileName = "C:/Program Files/Timer/Timer.exe";
        readonly string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + @"\Timer.lnk";

        public Installer()
        {
            InitializeComponent();       
        }

        private void Installer_Load(object sender, EventArgs e)
        {
            Thread backgroundThread = new Thread(new ThreadStart(BackgroundMethod));
            backgroundThread.Start();
        }

        private void Update(int value)
        {
            Invoke((MethodInvoker)delegate
            {
                InstallProgress.Increment(value);
                Refresh();
            });
        }

        private void BackgroundMethod()
        {
            Thread.Sleep(1000);
            Directory.CreateDirectory("C:/Program Files/Timer");
            Update(1);
            GetFile().Wait();    
        }

        private async Task GetFile()
        {               
            try
            {
                var httpContentClient = new HttpClient();
                httpContentClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("TimerApplication", "1"));
                var contentsUrl = $"https://api.github.com/repos/darynliebenberg/Timer-Resources/releases/latest";
                Update(1);
                var contentsJson = await httpContentClient.GetStringAsync(contentsUrl).ConfigureAwait(false);
                Update(4);
                var contents = (JToken)JsonConvert.DeserializeObject(contentsJson);
                var download = (string)contents["assets"][0]["url"];
                Update(1);

                WebClient wc = new WebClient();
                wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.77 Safari/537.36");
                wc.Headers.Add(HttpRequestHeader.Accept, "application/octet-stream");
                Update(1);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                wc.DownloadFile(download, fileName);
                Update(1);
                // Create a new instance of the WshShellClass
                var wshShell = new WshShell();

                // Create a new shortcut
                IWshShortcut shortcut = (IWshShortcut)wshShell.CreateShortcut(shortcutPath);

                // Set the target path of the shortcut
                shortcut.TargetPath = fileName;

                // Save the shortcut
                shortcut.Save();
                Update(1);
                Console.WriteLine($"File downloaded: {fileName}");
                
                Thread.Sleep(1000);
                Invoke((MethodInvoker)delegate
                {
                    FinishPanel.Show();
                    Installing.Hide();
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Invoke((MethodInvoker)delegate
                {
                    ErrorPanel.Show();
                    Installing.Hide();
                });
            }               
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (StartApp.Checked)
            {
                ProcessStartInfo start = new ProcessStartInfo()
                {
                    FileName = fileName
                };
                Process.Start(start);
            }
            Application.Exit();
        }

        private void WebsiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/darynliebenberg/Timer-Resources/releases");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}