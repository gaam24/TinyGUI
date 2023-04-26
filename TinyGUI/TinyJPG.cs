using TinyGUI.Data;
using TinyGUI.Events;
using TinyGUI.Handlers;
using TinyGUI.Systems;
using TinyGUI.Utils;

namespace TinyGUI
{
    public class TinyJPG
    {
        public static readonly string[] SupportedExtensions = new[]
        {
            ".jpg",
            ".png",
            ".webp"
        };

        private readonly TinySave tinySave = new();

        // APIKeys
        private List<APIKey> _apiKeys = new();
        public List<APIKey> APIKeys { get => _apiKeys; }

        // TinySettings
        private TinySettings _settings;
        public TinySettings Settings { get => _settings; }

        // TinyStatistics
        private readonly TinyStatistics _statistics;
        public TinyStatistics Statistics { get => _statistics; }

        public event VersionCheckedHandler? OnVersionChecked;

        public TinyJPG()
        {
            _settings = tinySave.LoadSettings();
            _statistics = tinySave.LoadStatistics();
        }

        public async void CheckVersionAsync(string versionType, string currentVersion)
        {
            try
            {
                var version = await NetworkUtils.GetVersionAsync(versionType).ConfigureAwait(true);
                OnVersionChecked?.Invoke(this, new VersionCheckedEventArgs(version, currentVersion));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); //TODO: Change?
            }
        }
        public async Task ParseApiKeysAsync(TinyAPIParser parser)
        {
            _apiKeys = await parser.ParseAPIKeysAsync(_settings.Clone()).ConfigureAwait(false);
            _statistics.UpdateAPIKeys(_apiKeys);
        }

        public async Task CompressAsync(TinyCompression compression)
        {
            await compression.CompressListAsync(_settings.Clone(), _statistics, _apiKeys).ConfigureAwait(false);
        }

        public void ResetSettings()
        {
            _settings = new TinySettings
            {
                APIKeys = _settings.APIKeys
            };
        }

        public void Save()
        {
            tinySave.SaveSettings(_settings);
            tinySave.SaveStatistics(_statistics);
        }
    }
}