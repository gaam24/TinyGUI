using Krypton.Toolkit;

namespace TinyGUI.UI.Windows.Data
{
    public class MenuButton
    {
        public string Title { get; private set; }

        public KryptonButton Button { get; private set; }

        public UserControl UserControl { get; private set; }

        public MenuButton(string title, KryptonButton button, UserControl control)
        {
            Title = title;
            Button = button;
            UserControl = control;
        }
    }
}