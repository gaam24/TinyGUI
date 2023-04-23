using TinyGUI.UI.Windows.Data;

namespace TinyGUI.UI.Windows.Events
{
    public class MenuButtonClickEventArgs : EventArgs
    {
        public MenuButton MenuButton { get; }

        public MenuButtonClickEventArgs(MenuButton menuButton)
        {
            MenuButton = menuButton;
        }
    }
}