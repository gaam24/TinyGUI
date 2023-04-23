using TinyGUI.UI.Windows.Events;
using TinyGUI.UI.Windows.Utils;

//TODO: Description on hover
namespace TinyGUI.UI.Windows.Forms
{
    public partial class ConsoleForm : UserControl
    {
        private readonly ConsoleWriter consoleWriter;

        public ConsoleForm()
        {
            InitializeComponent();

            consoleBox.Items.Clear();
            consoleBox.KeyDown += Console_KeyDown;

            consoleWriter = new ConsoleWriter(consoleBox);
            consoleWriter.OnConsoleWrite += OnConsoleWriteEvent;
        }

        private void ConsoleForm_Load(object sender, EventArgs e)
        {
            Console.SetOut(consoleWriter);
            Console.WriteLine("Console loaded.");
        }

        /*
         * Console Events
         */
        private void Console_KeyDown(object? sender, KeyEventArgs e)
        {
            // Clear selected
            if (e.KeyCode == Keys.Escape)
            {
                consoleBox.SelectedItems.Clear();
            }
            // Copy
            else if (e.Control && e.KeyCode == Keys.C)
            {
                e.SuppressKeyPress = true;

                List<string> items = new();
                foreach (var selectedItem in consoleBox.SelectedItems)
                {
                    if (selectedItem.ToString() is not string text) continue;
                    items.Add(text);
                }

                Clipboard.SetText(StringUtils.ListToString(items));
            }
        }

        private void OnConsoleWriteEvent(object sender, ConsoleWriteEventArgs e)
        {
            // Autoscroll
            consoleBox.TopIndex = consoleBox.Items.Count - 1;
        }
    }
}