using Krypton.Toolkit;
using System.Globalization;
using System.Text;
using TinyGUI.UI.Windows.Events;
using TinyGUI.UI.Windows.Handlers;

namespace TinyGUI.UI.Windows
{
    internal sealed class ConsoleWriter : TextWriter
    {
        public override Encoding Encoding => Encoding.ASCII;

        public event ConsoleWriteHandler? OnConsoleWrite;

        private readonly KryptonListBox console;

        public ConsoleWriter(KryptonListBox console)
        {
            this.console = console;
        }

        public override void WriteLine(char value)
        {
            AppendText($"{value}{Environment.NewLine}");
        }

        public override void WriteLine(string? value)
        {
            AppendText($"{value}{Environment.NewLine}");
        }

        public override void WriteLine(object? value)
        {
            AppendText($"{value}{Environment.NewLine}");
        }

        public override void Write(char value)
        {
            AppendText(value.ToString());
        }

        public override void Write(string? value)
        {
            AppendText(value);
        }

        private void AppendText(string? text)
        {
            if (string.IsNullOrWhiteSpace(text)) return;
            
            console.BeginInvoke(new Action(() =>
            {
                var time = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss", CultureInfo.InvariantCulture);
                if (text.Contains(Environment.NewLine) || text.Contains('\n')) 
                {
                    console.Items.Add($"[{time}] {text}");
                }
                else
                {
                    var index = console.Items.Count - 1;
                    if (index < 0)
                    {
                        console.Items.Add($"[{time}] {text}");
                    }    
                    else
                    {
                        console.Items[index] += text;
                    }
                }
                OnConsoleWrite?.Invoke(this, new ConsoleWriteEventArgs(text));
            }));
        }
    }
}