using Newtonsoft.Json;

namespace TinyGUI.Utils
{
    internal static class JsonUtils
    {
        internal static T LoadJsonFile<T>(string filePath, T defaultObject) where T : class, new()
        {
            if (filePath == null) return defaultObject;
            if (!File.Exists(filePath))
            {
                SaveJsonFile(filePath, defaultObject);
                return defaultObject;
            }

            var json = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<T>(json);

            if (result == null)
            {
                result = defaultObject;
                SaveJsonFile(filePath, result);
            }

            return result;
        }

        internal static void SaveJsonFile<T>(string filePath, T objectToSave) where T : class
        {
            if (filePath == null) return;

            var json = JsonConvert.SerializeObject(objectToSave, Formatting.Indented);
            try
            {
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); // TODO: Add Exceptions
            }
        }
    }
}
