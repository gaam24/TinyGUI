using Krypton.Toolkit;
using System.Globalization;
using TinyGUI.Events;
using TinyGUI.Systems;
using TinyGUI.UI.Windows.Utils;

// TODO: Block settings changes when run action (e.g Compressing)
namespace TinyGUI.UI.Windows.Forms
{
    public partial class SettingsForm : UserControl
    {
        readonly TinyAPIParser parser = new();

        private bool isHidden;
        private string realApiKeys = string.Empty;

        public SettingsForm()
        {
            InitializeComponent();

            // API Keys Events
            ktbAPIKeys.Enter += APIKeys_Enter;
            ktbAPIKeys.Leave += APIKeys_LeaveAsync;

            // API Parser Threads Events
            FormsUtils.OnlyNumbers(ktbAPIParserThreads);
            FormsUtils.Range(ktbAPIParserThreads, 0, 1000);
            ktbAPIParserThreads.TextChanged += APIParserThreads_TextChanged;

            // API Max Requests
            FormsUtils.OnlyNumbers(ktbMaxRequestsPerAPI);
            FormsUtils.Range(ktbMaxRequestsPerAPI, 0, int.MaxValue);
            ktbMaxRequestsPerAPI.TextChanged += MaxRequestsPerAPI_TextChanged;

            // Compress Path Events
            ktbCompressPath.TextChanged += CompressedPath_TextChanged;
            kbCompressPathSearch.Click += CompressedPathSearch_Click;

            // Compress Name Events
            ktbCompressName.TextChanged += CompressedName_TextChanged;

            // Compress Threads
            FormsUtils.OnlyNumbers(ktbCompressingThreads);
            FormsUtils.Range(ktbCompressingThreads, 0, 1000);
            ktbCompressingThreads.TextChanged += CompressingThreads_TextChanged;

            // Reset Button Event
            kbReset.Click += ResetButton_Click;

            // API Parser Events
            parser.APIUpdate += ParserAPIUpdateHandler;
            parser.LoadingEnded += ParserAPIEndedHandler;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Disable backgrounds
            kpAPI.StateCommon.Draw = InheritBool.False;
            kpCompress.StateCommon.Draw = InheritBool.False;

            LoadSettings();
        }

        private void LoadSettings()
        {
            TinySettings settings = Program.TinyJPG.Settings;

            ktbAPIParserThreads.Text = settings.APIParserThreads.ToString(CultureInfo.InvariantCulture);
            realApiKeys = string.Join(Environment.NewLine, settings.APIKeys);
            ktbAPIKeys.Text = realApiKeys;

            ktbMaxRequestsPerAPI.Text = settings.MaxRequestsPerAPI.ToString(CultureInfo.InvariantCulture);

            ktbCompressPath.Text = settings.CompressedPath;
            ktbCompressName.Text = settings.CompressedName;

            ktbCompressingThreads.Text = settings.CompressingThreads.ToString(CultureInfo.InvariantCulture);

            // Parse API
            parser.SetKeys(settings.APIKeys);
            Program.TinyJPG.ParseApiKeysAsync(parser).ConfigureAwait(false);
            HideAPIKeys();
        }

        /*
         * API Keys Events
         */
        private void APIKeys_Enter(object? sender, EventArgs e)
        {
            ShowAPIKeys();
        }

        private async void APIKeys_LeaveAsync(object? sender, EventArgs e)
        {
            HideAPIKeys();

            var list = ListUtils.StringToList(realApiKeys);
            if (ListUtils.IsDifferent(Program.TinyJPG.Settings.APIKeys, list))
            {
                parser.SetKeys(list);
                try
                {
                    await Program.TinyJPG.ParseApiKeysAsync(parser).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /*
         * API Max Requests
         */
        private void MaxRequestsPerAPI_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(ktbMaxRequestsPerAPI.Text, CultureInfo.InvariantCulture);
                Program.TinyJPG.Settings.MaxRequestsPerAPI = num;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MaxRequestsPerAPI] {ex.Message}");
            }
        }

        /*
         * API Threads Events
         */
        private void APIParserThreads_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(ktbAPIParserThreads.Text, CultureInfo.InvariantCulture);
                Program.TinyJPG.Settings.APIParserThreads = num;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[APIParserThreads] {ex.Message}");
            }
        }

        /*
         * Compressed Path Events
         */
        private void CompressedPath_TextChanged(object? sender, EventArgs e)
        {
            if (!cbCompressPathDontSave.Checked)
            {
                Program.TinyJPG.Settings.CompressedPath = ktbCompressPath.Text;
            }
        }

        private void CompressedPathSearch_Click(object? sender, EventArgs e)
        {
            using FolderBrowserDialog fileDialog = new();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ktbCompressPath.Text = fileDialog.SelectedPath;
            }
        }

        /*
         * Compressed Name Events
         */
        private void CompressedName_TextChanged(object? sender, EventArgs e)
        {
            Program.TinyJPG.Settings.CompressedName = ktbCompressName.Text;
        }

        /*
         * Compressing Threads Events
         */
        private void CompressingThreads_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(ktbCompressingThreads.Text, CultureInfo.InvariantCulture);
                Program.TinyJPG.Settings.CompressingThreads = num;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CompressingThreads] {ex.Message}");
            }
        }

        /*
         * Reset Button Event
         */
        private void ResetButton_Click(object? sender, EventArgs e)
        {
            ShowAPIKeys();
            Program.TinyJPG.ResetSettings();
            LoadSettings();
        }

        /*
         * Others
         */
        private void ShowAPIKeys()
        {
            if (isHidden)
            {
                ktbAPIKeys.Text = realApiKeys;
                isHidden = false;
            }
        }

        private void HideAPIKeys()
        {
            if (!isHidden)
            {
                realApiKeys = ktbAPIKeys.Text;

                string final = string.Empty;
                foreach (var key in ListUtils.StringToList(ktbAPIKeys.Text))
                {
                    final += $"{StringUtils.GetCoveredText(key, showMax: 5)}{Environment.NewLine}";
                }
                ktbAPIKeys.Text = final;
                isHidden = true;
            }
        }

        /*
         * Handlers
         */
        private void ParserAPIUpdateHandler(object sender, ParserAPIUpdateEventArgs e)
        {
            Console.WriteLine($"API: {StringUtils.GetCoveredText(e.LoadedAPI, showMax: 8)} is {(e.IsValid ? "valid" : "not valid")}. Loaded in {TimeUtils.GetFormattedTime(e.Elapsed)}");
        }

        private void ParserAPIEndedHandler(object sender, ParserAPIEndedEventArgs e)
        {
            Console.WriteLine($"Parsed {e.ValidList.Count} of {e.APIKeys.Count} API keys in {TimeUtils.GetFormattedTime(e.Elapsed)}");
        }
    }
}