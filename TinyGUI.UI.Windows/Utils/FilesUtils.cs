namespace TinyGUI.UI.Windows.Utils
{
    internal static class FilesUtils
    {
        internal static long GetFilesSize(List<string>? list)
        {
            if (list == null || list.Count == 0) return 0;

            long size = 0;
            foreach (string path in list)
            {
                FileInfo info = new(path);
                size += info.Length;
            }
            return size;
        }
    }
}
