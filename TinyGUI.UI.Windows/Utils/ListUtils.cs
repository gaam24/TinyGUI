namespace TinyGUI.UI.Windows.Utils
{
    internal static class ListUtils
    {
        internal static bool IsDifferent(List<string> list1, List<string> list2)
        {
            int count1 = list1.Except(list2).Count();
            int count2 = list2.Except(list1).Count();

            return !(count1 == 0 && count2 == 0);
        }

        internal static List<string> StringToList(string text)
        {
            return text.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}
