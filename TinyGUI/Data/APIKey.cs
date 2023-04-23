namespace TinyGUI.Data
{
    public class APIKey
    {
        public string Key { get; }

        public bool IsValid { get; set; }

        public int CompressionsCount { get; set; }

        public APIKey(string key)
        {
            Key = key;
        }
    }
}