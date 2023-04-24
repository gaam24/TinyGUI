using System.Diagnostics;
using Tinify;
using TinyGUI.Data;
using TinyGUI.Events;
using TinyGUI.Handlers;

namespace TinyGUI.Systems
{
    public class TinyAPIParser
    {
        private List<string> rawKeys = new();

        public event ParserAPIUpdateHandler? APIUpdate;
        public event ParserAPIEndedHandler? LoadingEnded;

        public void SetKeys(List<string> apiKeys)
        {
            rawKeys = apiKeys;
        }

        internal async Task<List<APIKey>> ParseApiKeysAsync(TinySettings settings)
        {
            var semaphore = new SemaphoreSlim(settings.APIParserThreads);

            // Remove all empty values.
            rawKeys.RemoveAll(string.IsNullOrEmpty);

            Stopwatch watch = Stopwatch.StartNew();
            var validKeys = await Task.WhenAll(rawKeys.Select(async key =>
            {
                await semaphore.WaitAsync().ConfigureAwait(false);

                // Check API.
                Stopwatch apiWatch = Stopwatch.StartNew();

                APIKey apiKey = new(key);
                using (TinifyClient client = new(key))
                {
                    // Set values
                    try
                    {
                        apiKey.IsValid = await client.ValidateAsync().ConfigureAwait(false);
                        apiKey.CompressionsCount = client.CompressionCount;
                    }
                    catch { }

                }
                semaphore.Release();
                apiWatch.Stop();

                APIUpdate?.Invoke(this, new ParserAPIUpdateEventArgs(key, apiKey.IsValid, apiWatch.Elapsed));
                return new { ApiKey = apiKey };
            })).ConfigureAwait(false);
            watch.Stop();

            // Save rawKeys to settings.
            settings.APIKeys = rawKeys;

            // CreateAsync list of valid API keys.
            var list = validKeys.Where(vk => vk.ApiKey.IsValid).Select(vk => vk.ApiKey).ToList();

            LoadingEnded?.Invoke(this, new ParserAPIEndedEventArgs(rawKeys, list.Select(apiKey => apiKey.Key).ToList(), watch.Elapsed));
            return list;
        }
    }
}