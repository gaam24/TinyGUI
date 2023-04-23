﻿using TinyGUI.Data;
using TinyGUI.Systems;

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

        public TinyJPG()
        {
            _settings = tinySave.LoadSettings();
            _statistics = tinySave.LoadStatistics();
        }

        public async Task CompressAsync(TinyCompression compression)
        {
            await compression.CompressAsync(_settings, _statistics, _apiKeys).ConfigureAwait(false);
        }

        public async Task ParseApiKeysAsync(TinyAPIParser parser)
        {
            _apiKeys = await parser.ParseApiKeysAsync(_settings).ConfigureAwait(false);
            _statistics.UpdateAPIKeys(_apiKeys);
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