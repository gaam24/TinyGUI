using System.Globalization;

namespace TinyGUI.UI.Windows.Utils
{
    internal static class FormsUtils
    {
        internal static void Range(Control control, int min, int max)
        {
            control.KeyPress += (sender, e) =>
            {
                if (IsNumber(e.KeyChar))
                {
                    try
                    {
                        string newText = $"{control.Text}{e.KeyChar}";
                        int num = int.Parse(newText, CultureInfo.InvariantCulture);

                        if (newText.Length > max.ToString(CultureInfo.InvariantCulture).Length) e.Handled = true;
                        if (num > max || num < min) e.Handled = true;
                    }
                    catch { }
                }
            };
        }

        internal static void OnlyNumbers(Control control)
        {
            control.KeyPress += (sender, e) =>
            {
                e.Handled = !IsNumber(e.KeyChar);
            };
        }

        private static bool IsNumber(char key)
        {
            return char.IsDigit(key) || char.IsControl(key);
        }
    }
}
