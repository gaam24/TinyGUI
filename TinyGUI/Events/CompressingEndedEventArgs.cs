using TinyGUI.Data;

namespace TinyGUI.Events
{
    public class CompressingEndedEventArgs : EventArgs
    {
        public List<APIKey> APIKeys { get; }

        public List<string> AllFilesList { get; }
        public List<string> AllCompressedList { get; }

        public TimeSpan Elapsed { get; }

        public CompressingEndedEventArgs(List<APIKey> apiKeys,
            List<string> allFilesList, List<string> allOptimizedList,
            TimeSpan elapsed)
        {
            APIKeys = apiKeys;

            AllFilesList = allFilesList;
            AllCompressedList = allOptimizedList;

            Elapsed = elapsed;
        }
    }
}