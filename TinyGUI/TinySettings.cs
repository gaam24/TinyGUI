namespace TinyGUI
{
    public class TinySettings
    {
        private string _compressedPath = "Optimized";
        public string CompressedPath
        {
            get => _compressedPath;
            set => _compressedPath = value;
        }

        private string _compressedName = "{name}-optimized";
        public string CompressedName
        {
            get => _compressedName;
            set => _compressedName = value;
        }

        private int _compressingThreads;
        public int CompressingThreads
        {
            get => _compressingThreads;
            set => _compressingThreads = value;
        }

        private List<string> _apiKeys = new();
        public List<string> APIKeys
        {
            get => _apiKeys;
            set => _apiKeys = value;
        }

        private int _apiParserThreads = 10;
        public int APIParserThreads
        {
            get => _apiParserThreads;
            set => _apiParserThreads = value;
        }

        private int _maxRequestsPerAPI = 500;
        public int MaxRequestsPerAPI
        {
            get => _maxRequestsPerAPI;
            set => _maxRequestsPerAPI = value;
        }
    }
}