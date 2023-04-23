namespace TinyGUI.UI.Windows.Data
{
    public class MenuButton
    {
        public string Title { get; private set; }

        public Button Button { get; private set; }

        public UserControl UserControl { get; private set; }

        public MenuButton(string title, Button button, UserControl control)
        {
            Title = title;
            Button = button;
            UserControl = control;
        }
    }
}