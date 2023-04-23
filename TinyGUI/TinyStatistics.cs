using TinyGUI.Data;
using TinyGUI.Handlers;

namespace TinyGUI
{
    public class TinyStatistics
    {
        private List<APIKey> apiKeys = new();

        private int _compressedImages;
        public int CompressedImages
        {
            get => _compressedImages; 
            set => _compressedImages = value;
        }

        public event StatisticsUpdateHandler? StatisticsUpdate;

        internal void UpdateAPIKeys(List<APIKey> apiKeys)
        {
            this.apiKeys = apiKeys;
            StatisticsUpdate?.Invoke(this, EventArgs.Empty);
        }

        public void Update()
        {
            StatisticsUpdate?.Invoke(this, EventArgs.Empty);
        }

        public Dictionary<string, int> GetAPICompressionCount()
        {
            return apiKeys.ToDictionary(apiKey => apiKey.Key, apiKey => apiKey.CompressionsCount);
        }
    }
}
