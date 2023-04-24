using TinyGUI.Data;

namespace TinyGUI.Events
{
    public class CompressingAPIDoneEventArgs : EventArgs
    {
        public APIKey APIKey { get; }

        public List<string> AllFilesList { get; }
        public List<string> AllCompressedList { get; }

        public TimeSpan Elapsed { get; }
        public TimeSpan TotalElapsed { get; }

        public CompressingAPIDoneEventArgs(APIKey apiKey,
            List<string> allFilesList, List<string> allCompressedList,
            TimeSpan elapsed, TimeSpan totalElapsed)
        {
            APIKey = apiKey;

            AllFilesList = allFilesList;
            AllCompressedList = allCompressedList;

            Elapsed = elapsed;
            TotalElapsed = totalElapsed;
        }
    }
}