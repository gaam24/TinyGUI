namespace TinyGUI.Events
{
    public class ParserAPIUpdateEventArgs : EventArgs
    {
        public string LoadedAPI { get; }
        public bool IsValid { get; }
        public TimeSpan Elapsed { get; }

        public ParserAPIUpdateEventArgs(string loadedApi, bool isValid, TimeSpan elapsed)
        {
            LoadedAPI = loadedApi;
            IsValid = isValid;
            Elapsed = elapsed;
        }
    }
}