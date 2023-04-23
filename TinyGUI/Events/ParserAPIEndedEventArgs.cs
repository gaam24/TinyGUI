namespace TinyGUI.Events
{
    public class ParserAPIEndedEventArgs : EventArgs
    {
        public List<string> APIKeys { get; }
        public List<string> ValidList { get; }
        public TimeSpan Elapsed { get; }

        public ParserAPIEndedEventArgs(List<string> apiKeys, List<string> validList, TimeSpan elapsed)
        {
            APIKeys = apiKeys;
            ValidList = validList;
            Elapsed = elapsed;
        }
    }
}