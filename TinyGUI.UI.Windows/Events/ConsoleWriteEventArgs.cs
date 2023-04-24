namespace TinyGUI.UI.Windows.Events
{
    public class ConsoleWriteEventArgs : EventArgs
    {
        public string Text { get; }

        public ConsoleWriteEventArgs(string text)
        {
            Text = text;
        }
    }
}
