using Krypton.Toolkit;
using System.Diagnostics;
using Timer = System.Timers.Timer;
using TinyGUI.UI.Windows.Utils;
using System.Timers;

namespace TinyGUI.UI.Windows.Forms
{
    public partial class DashboardForm : UserControl
    {
        public DashboardForm()
        {
            InitializeComponent();

            klbCompressedCount.MouseLeave += OnMouseLeaveEvent;
            klbCompressedImages.MouseLeave += OnMouseLeaveEvent;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Disable backgrounds
            kpCompressedCount.StateCommon.Draw = InheritBool.False;
            kpCompressedImages.StateCommon.Draw = InheritBool.False;

            // Reset values
            StatisticsUpdateHandler(this, EventArgs.Empty);

            // LoadSettings Settings
            Program.TinyJPG.Statistics.StatisticsUpdate += StatisticsUpdateHandler;
        }

        private void StatisticsUpdateHandler(object sender, EventArgs e)
        {
            var statistics = Program.TinyJPG.Statistics;
            var compressionCount = statistics.GetAPICompressionCount();

            klbCompressedCount.BeginInvoke(new Action(() =>
            {
                klbCompressedCount.Items.Clear();
                foreach (var compression in compressionCount)
                {
                    klbCompressedCount.Items.Add($"{StringUtils.GetCoveredText(compression.Key, showMax: 8)} => {compression.Value}");
                }
            }));

            klbCompressedImages.BeginInvoke(new Action(() =>
            {
                klbCompressedImages.Items.Clear();
                klbCompressedImages.Items.Add($"{statistics.CompressedImages}");
            }));
        }

        private void OnMouseLeaveEvent(object? sender, EventArgs e)
        {
            if (sender is not KryptonListBox box) return;
            box.SelectedItems.Clear();
        }
    }
}