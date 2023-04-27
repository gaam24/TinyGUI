using Krypton.Toolkit;
using System.Diagnostics;
using System.Globalization;
using System.Timers;
using TinyGUI.Events;
using TinyGUI.UI.Windows.Data;
using TinyGUI.UI.Windows.Forms;
using Timer = System.Timers.Timer;

namespace TinyGUI.UI.Windows
{
    public partial class MainForm : Form
    {
        private readonly PerformanceCounter cpuCounter = new("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
        private readonly Timer timer = new(800);
        private readonly string defaultTitle;

        private readonly string defaultNewVersionText;

        public MainForm()
        {
            InitializeComponent();
            defaultTitle = $"{Text} v{Application.ProductVersion}";
            defaultNewVersionText = btnNewVersion.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Register Buttons
            RegisterButtons();

            // New Version
            btnNewVersion.Hide();
            btnNewVersion.Click += BtnNewVersion_Click;
            Program.TinyJPG.OnVersionChecked += TinyJPG_OnVersionChecked;
            Program.TinyJPG.CheckVersionAsync("TinyGUI.UI.Windows", Application.ProductVersion);

            // Usage Timer
            timer.Elapsed += ElapsedEventHandler;
            timer.Start();
        }

        private void RegisterButtons()
        {
            MenuManager formsManager = new(lblTitle, pnlTitleBar, kpForm);

            formsManager.AddButton("Dashboard", kbDashboard, new DashboardForm());
            formsManager.AddButton("Images", kbImages, new ImagesForm());

            formsManager.AddButton("Console", kbConsole, new ConsoleForm());
            formsManager.AddButton("Settings", kbSettings, new SettingsForm());

            formsManager.AddForceLoad("Console");
            formsManager.AddForceLoad("Settings");
            formsManager.SetDefaultMenu("Dashboard");
            formsManager.Register();
        }

        void ElapsedEventHandler(object? sender, ElapsedEventArgs e)
        {
            var usedRam = ((double)Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024).ToString("0.00", CultureInfo.InvariantCulture);
            var cpuUsage = cpuCounter.NextValue().ToString("0.00", CultureInfo.InvariantCulture);
            BeginInvoke(new Action(() =>
            {
                Text = $"{defaultTitle} [RAM: {usedRam} MB, CPU: {cpuUsage}%]";
            }));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop Timer
            timer.Stop();
            timer.Dispose();

            // Save Settings
            Program.TinyJPG.Save();
        }

        private void TinyJPG_OnVersionChecked(object sender, VersionCheckedEventArgs e)
        {
            if (e.NewestVersion)
            {
                btnNewVersion.BeginInvoke(new Action(() =>
                {
                    string text = defaultNewVersionText;
                    text = text.Replace("{version}", e.Version);

                    btnNewVersion.Text = text;
                    btnNewVersion.Show();
                }));
            }
        }

        private void BtnNewVersion_Click(object? sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer", "https://github.com/gaam24/TinyGUI/releases/latest");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}