using System;
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
        const string token = "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";
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
            Update(1);
            Thread.Sleep(1000);
            Invoke((MethodInvoker)delegate
            {
                Installing.Hide();
            });           
        }

        async Task GetFile()
        {               
            try
            {
                var httpContentClient = new HttpClient();
                httpContentClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("TimerApplication", "1"));
                httpContentClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var contentsUrl = $"https://api.github.com/repos/darynliebenberg/Timer/releases/latest";
                Update(1);
                var contentsJson = await httpContentClient.GetStringAsync(contentsUrl).ConfigureAwait(false);
                Update(4);
                var contents = (JToken)JsonConvert.DeserializeObject(contentsJson);
                var download = (string)contents["assets"][0]["url"];
                Update(1);

                WebClient wc = new WebClient();
                wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.77 Safari/537.36");
                wc.Headers.Add(HttpRequestHeader.Authorization, $"token {token}");
                wc.Headers.Add(HttpRequestHeader.Accept, "application/octet-stream");
                Update(1);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                wc.DownloadFile(download, fileName);
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
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
    }
}