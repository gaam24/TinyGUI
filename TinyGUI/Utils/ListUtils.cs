using TinyGUI.Data;

namespace TinyGUI.Utils
{
    internal static class ListUtils
    {
        internal static Dictionary<APIKey, List<string>> SplitFiles(List<string> filesPaths, List<APIKey> apiKeys, TinySettings settings)
        {
            var results = new Dictionary<APIKey, List<string>>();
            var remainingApiKeys = new List<APIKey>(apiKeys);
            int apiIndex = 0;

            foreach (var file in filesPaths)
            {
                var apiKey = remainingApiKeys[apiIndex];
                var remaining = settings.MaxRequestsPerAPI == 0 ? int.MaxValue : settings.MaxRequestsPerAPI - apiKey.CompressionsCount;

                // Create list if not exist
                if (!results.ContainsKey(apiKey)) results[apiKey] = new List<string>();

                results[apiKey].Add(file);
                if (results[apiKey].Count >= remaining)
                {
                    remainingApiKeys.Remove(apiKey);
                    apiIndex--;
                }

                if (remainingApiKeys.Count == 0) break;
                apiIndex = apiIndex < remainingApiKeys.Count - 1 ? apiIndex + 1 : 0;
            }

            return results;
        }
    }
}
