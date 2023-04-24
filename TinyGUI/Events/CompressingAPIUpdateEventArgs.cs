using TinyGUI.Data;

namespace TinyGUI.Events
{
    public class CompressingAPIUpdateEventArgs : EventArgs
    {
        public APIKey APIKey { get; }

        public string CurrentFilePath { get; }
        public string CurrentCompressedPath { get; }

        public List<string> AllFilesList { get; }
        public List<string> AllCompressedList { get; }

        public TimeSpan Elapsed { get; }
        public TimeSpan TotalElapsed { get; }

        public CompressingAPIUpdateEventArgs(APIKey apiKey,
            string currentFilePath, string currentCompressedPath,
            List<string> allFilesList, List<string> allCompressedList,
            TimeSpan elapsed, TimeSpan totalElapsed)
        {
            APIKey = apiKey;

            CurrentFilePath = currentFilePath;
            CurrentCompressedPath = currentCompressedPath;

            AllFilesList = allFilesList;
            AllCompressedList = allCompressedList;

            Elapsed = elapsed;
            TotalElapsed = totalElapsed;
        }
    }
}