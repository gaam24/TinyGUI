using Krypton.Toolkit;
using TinyGUI.Events;
using TinyGUI.Systems;
using TinyGUI.UI.Windows.Data;
using TinyGUI.UI.Windows.Events;
using TinyGUI.UI.Windows.Utils;

//TODO: Add support to multiple file names (in other directory)
//TODO: Display if api count is empty?
//TODO: Cancel button
namespace TinyGUI.UI.Windows.Forms
{
    public partial class ImagesForm : UserControl
    {
        private readonly TinyCompression compression = new();
        private readonly List<string> pathsList = new();

        private readonly Compress compress = new();

        private readonly string defaultInfoFilesText;
        private readonly string defaultInfoOptimizedText;
        private readonly string defaultInfoSpaceSavedText;
        private readonly string defaultCompressInfoText;

        public ImagesForm()
        {
            InitializeComponent();

            // Optimize Handlers
            compression.APIUpdate += CompressingAPIUpdateHandler;
            compression.APIDone += CompressingAPIDoneHandler;
            compression.LoadingEnded += CompressingEndedHandler;

            // FileDrop Events
            klbFileDrop.KeyDown += FileDrop_KeyDown;
            klbFileDrop.DragDrop += FileDrop_DragDrop;
            klbFileDrop.DragEnter += FileDrop_DragEnter;

            // Optimize Button Events
            kbCompressRun.Click += CompressRun_ClickAsync;

            // Compress Events
            compress.CompressTick += CompressTickHandler;

            // Set defaults texts
            defaultInfoFilesText = lblInfoFiles.Text;
            defaultInfoOptimizedText = lblInfoOptimized.Text;
            defaultInfoSpaceSavedText = lblInfoSpaceSaved.Text;
            defaultCompressInfoText = lblCompressInfo.Text;
        }

        private void CompressForm_Load(object sender, EventArgs e)
        {
            // Disable backgrounds
            kpFileDrop.StateCommon.Draw = InheritBool.False;
            kpInfo.StateCommon.Draw = InheritBool.False;
            kpCompress.StateCommon.Draw = InheritBool.False;

            // Clear FileDrop
            klbFileDrop.Items.Clear();

            // Set default info text
            UpdateInfoText(lblInfoFiles, defaultInfoFilesText);
            UpdateInfoText(lblInfoOptimized, defaultInfoOptimizedText);
            UpdateInfoText(lblInfoSpaceSaved, defaultInfoSpaceSavedText);

            // Reset progress
            UpdateProgressBar(0);
            UpdateETAText(TimeSpan.Zero);
        }

        /*
         * Compress Info Updates
         */

        private void UpdateInfoText(Label label, string defaultText, List<string>? optimizedPaths = null)
        {
            if (defaultText.Clone() is not string text) return;
            optimizedPaths ??= new List<string>();

            long pathsSize = FilesUtils.GetFilesSize(pathsList);
            long optimizedSize = FilesUtils.GetFilesSize(optimizedPaths);

            text = text.Replace("{filesCount}", $"{pathsList.Count}");
            text = text.Replace("{filesSize}", $"{StringUtils.FormatBytes(pathsSize)}");
            text = text.Replace("{optimizedCount}", $"{optimizedPaths.Count}");
            text = text.Replace("{optimizedSize}", $"{StringUtils.FormatBytes(optimizedSize)}");
            text = text.Replace("{spaceSaved}", $"-{StringUtils.GetRatio((int)optimizedSize, (int)pathsSize)}%");

            label.BeginInvoke(new Action(() =>
            {
                label.Text = text;
            }));
        }

        private void UpdateCompressInfo(List<string> compressedPaths)
        {
            // Update Compressed Size
            UpdateInfoText(lblInfoOptimized, defaultInfoOptimizedText, compressedPaths);
            UpdateInfoText(lblInfoSpaceSaved, defaultInfoSpaceSavedText, compressedPaths);
        }

        private void UpdateETAText(TimeSpan elapsed)
        {
            if (defaultCompressInfoText.Clone() is not string text) return;

            text = text.Replace("{percent}", $"{compress.Percent}");
            text = text.Replace("{elapsed}", $"{TimeUtils.GetFormattedETA(elapsed)}");
            text = text.Replace("{eta}", $"{TimeUtils.GetFormattedETA(compress.ETA)}");

            lblCompressInfo.BeginInvoke(new Action(() =>
            {
                lblCompressInfo.Text = text;
            }));
        }

        private void UpdateProgressBar(int count)
        {
            // Update progress bar
            kpbCompressProgress.BeginInvoke(new Action(() =>
            {
                if (count == -1) kpbCompressProgress.Style = ProgressBarStyle.Marquee;
                if (count >= 0) kpbCompressProgress.Style = ProgressBarStyle.Continuous;

                kpbCompressProgress.Value = count < 0 ? 0 : count;
            }));
        }

        /*
         * FileDrop Events
         */
        private void FileDrop_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                List<string> items = new();
                foreach (var selectedItem in klbFileDrop.SelectedItems)
                {
                    if (selectedItem.ToString() is not string text) continue;
                    items.Add(text);
                }

                items.ForEach(item =>
                {
                    var pathItem = pathsList.Where(img => img.Contains(item)).First();

                    pathsList.Remove(pathItem);
                    klbFileDrop.Items.Remove(item);
                });

                UpdateInfoText(lblInfoFiles, defaultInfoFilesText);
            }
        }

        private void FileDrop_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data == null) return;
            if (e.Data.GetData(DataFormats.FileDrop, false) is not string[] filesPaths) return;

            foreach (string path in filesPaths)
            {
                string name = Path.GetFileName(path);
                string ext = Path.GetExtension(path);

                if (pathsList.Contains(path)) continue;
                if (TinyJPG.SupportedExtensions.Contains(ext))
                {
                    pathsList.Add(path);
                    klbFileDrop.Items.Add(name);
                }
            }

            UpdateInfoText(lblInfoFiles, defaultInfoFilesText);
            UpdateInfoText(lblInfoOptimized, defaultInfoOptimizedText);
            UpdateInfoText(lblInfoSpaceSaved, defaultInfoSpaceSavedText);
        }

        private void FileDrop_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data == null) return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /*
         * Compress Button Events
         */
        private async void CompressRun_ClickAsync(object? sender, EventArgs e)
        {
            if (pathsList.Count > 0)
            {
                // Update Text Info
                UpdateInfoText(lblInfoOptimized, defaultInfoOptimizedText);
                UpdateInfoText(lblInfoSpaceSaved, defaultInfoSpaceSavedText);

                // Reset Progress
                kpbCompressProgress.Maximum = pathsList.Count;
                kpbCompressProgress.Value = 0;
                UpdateProgressBar(-1);

                // Disable Editing FileDrop
                klbFileDrop.AllowDrop = false;

                // Set Timer
                compress.Start();

                // Run Compress
                compression.UpdateList(pathsList);
                try
                {
                    await Program.TinyJPG.CompressAsync(compression).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void CompressTickHandler(object? source, CompressTickEventArgs e)
        {
            UpdateETAText(e.Elapsed);
        }

        /*
         * Compress Handlers
         */
        private void CompressingAPIUpdateHandler(object sender, CompressingAPIUpdateEventArgs e)
        {
            // Update Info
            UpdateCompressInfo(e.AllCompressedList);

            // Update Progress
            compress.UpdateProgress(e.TotalElapsed, e.AllCompressedList.Count, e.AllFilesList.Count);
            UpdateProgressBar(e.AllCompressedList.Count);

            // Update Stats
            Program.TinyJPG.Statistics.Update();

            // Console Debug
            Console.WriteLine($"API: {StringUtils.GetCoveredText(e.APIKey.Key, showMax: 8)} done optimizing '{Path.GetFileName(e.CurrentFilePath)}' in {TimeUtils.GetFormattedTime(e.Elapsed)}");
        }

        private void CompressingAPIDoneHandler(object sender, CompressingAPIDoneEventArgs e)
        {
            // Update Progress
            compress.UpdateProgress(e.TotalElapsed, e.AllCompressedList.Count, e.AllFilesList.Count);
            UpdateProgressBar(e.AllCompressedList.Count);

            // Update Stats
            Program.TinyJPG.Statistics.Update();

            // Console Debug
            Console.WriteLine($"API: {StringUtils.GetCoveredText(e.APIKey.Key, showMax: 8)} done optimizing in {TimeUtils.GetFormattedTime(e.Elapsed)}");
        }

        private void CompressingEndedHandler(object sender, CompressingEndedEventArgs e)
        {
            // Dispose compress
            compress.Dispose();

            // Update Progress
            compress.UpdateProgress(e.Elapsed, e.AllCompressedList.Count, e.AllFilesList.Count);
            UpdateProgressBar(e.AllCompressedList.Count);
            UpdateETAText(e.Elapsed);

            // Update Info
            UpdateCompressInfo(e.AllCompressedList);

            // Enable FileDrop
            klbFileDrop.BeginInvoke(new Action(() =>
            {
                klbFileDrop.AllowDrop = true;
            }));

            // Update Stats
            Program.TinyJPG.Statistics.Update();

            // Console Debug
            Console.WriteLine($"All {e.APIKeys.Count} API Keys done optimizing {e.AllFilesList.Count} files in {TimeUtils.GetFormattedTime(e.Elapsed)}");
        }
    }
}