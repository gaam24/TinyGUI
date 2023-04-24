using System.Globalization;
using System.Text;

namespace TinyGUI.UI.Windows.Utils
{
    internal static class StringUtils
    {
        internal static string ListToString(List<string> list)
        {
            StringBuilder sb = new();
            for (int i = 0; i < list.Count; i++)
            {
                string item = list[i];

                sb.Append(item);
                if (!item.EndsWith(Environment.NewLine, StringComparison.Ordinal) && i != list.Count - 1)
                {
                    sb.Append(Environment.NewLine);
                }
            }
            return sb.ToString();
        }

        internal static string GetCoveredText(string text, char replaced = '#', int showChars = 3, int showMax = 0)
        {
            if (string.IsNullOrEmpty(text)) return text;

            int length = showMax <= text.Length && showMax != 0 ? showMax : text.Length;

            StringBuilder final = new(text.Length);
            for (int i = 0; i < length; i++) final.Append(i < showChars ? text[i] : replaced);

            return final.ToString();
        }

        internal static string FormatBytes(long bytes, int decimalPlaces = 2)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            double size = bytes;

            while (size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                size /= 1024;
            }
            return $"{Math.Round(size, decimalPlaces)} {sizes[order]}";
        }

        internal static string GetPercentage(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0) return "0.00%";
            //return $"{string.Format("{0:0.00}", Math.Round((double)num1 / num2 * 100, 2))}%";
            return $"{Math.Round((double)num1 / num2 * 100, 2).ToString("0.00", CultureInfo.InvariantCulture)}%";
        }

        internal static string GetRatio(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0) return "0.00";
            //return string.Format("{0:0.00}", Math.Round(100 - ((double)num1 / num2 * 100), 2));
            return Math.Round(100 - ((double)num1 / num2 * 100)).ToString("0.00", CultureInfo.InvariantCulture);
        }
    }
}