namespace TinyGUI.UI.Windows.Utils
{
    internal static class TimeUtils
    {
        internal static string GetFormattedETA(TimeSpan elapsed)
        {
            return $"{elapsed:hh\\:mm\\:ss}";
        }

        internal static TimeSpan GetETA(TimeSpan elapsed, int processed, int left)
        {
            return TimeSpan.FromMilliseconds((elapsed.TotalMilliseconds / processed) * left);
        }

        internal static string GetFormattedTime(TimeSpan elapsed)
        {
            string format;

            // Hours
            if (elapsed.TotalHours >= 1)
            {
                format = $"{elapsed:hh\\:mm\\:ss\\.fff} h.";
            }
            // Minutes
            else if (elapsed.TotalMinutes >= 1)
            {
                format = $"{elapsed:mm\\:ss\\.fff} min.";
            }
            // Default
            else
            {
                format = $"{elapsed:ss\\.fff} sec.";
            }

            return format;
        }
    }
}
