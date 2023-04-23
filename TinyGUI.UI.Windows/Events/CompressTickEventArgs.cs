namespace TinyGUI.UI.Windows.Events
{
    public class CompressTickEventArgs : EventArgs
    {
        public TimeSpan Elapsed { get; }

        public CompressTickEventArgs(TimeSpan elapsed)
        {
            Elapsed = elapsed;
        }
    }
}
