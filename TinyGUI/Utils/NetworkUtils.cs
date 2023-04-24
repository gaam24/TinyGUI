using Newtonsoft.Json;

namespace TinyGUI.Utils
{
    internal static class NetworkUtils
    {
        private static readonly string link = "https://raw.githubusercontent.com/gaam24/TinyGUI/main/versions.json";

        internal static async Task<string?> GetVersion(string type)
        {
            using var httpClient = new HttpClient();
            try
            {
                var jsonString = await httpClient.GetStringAsync(link).ConfigureAwait(false);
                dynamic? json = JsonConvert.DeserializeObject(jsonString);

                return json?[type];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }
    }
}
