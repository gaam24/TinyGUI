using Timer = System.Timers.Timer;
using TinyGUI.UI.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Globalization;

namespace TinyGUI.UI.Windows
{
    public partial class MainForm : Form
    {
        private readonly PerformanceCounter cpuCounter = new("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
        private readonly Timer timer = new(800);
        private readonly string defaultTitle;

        public MainForm()
        {
            InitializeComponent();
            defaultTitle = Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RegisterButtons();

            // Usage Timer
            timer.Elapsed += ElapsedEventHandler;
            timer.Start();
        }

        private void RegisterButtons()
        {
            MenuManager formsManager = new(lblTitle, pnlTitleBar, kpForm, pnlNav);

            formsManager.AddButton("Dashboard", btnDashboard, new DashboardForm());
            formsManager.AddButton("Compress", btnCompress, new CompressForm());
            formsManager.AddButton("Console", btnConsole, new ConsoleForm());
            formsManager.AddButton("Settings", btnSettings, new SettingsForm());

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
    }
}