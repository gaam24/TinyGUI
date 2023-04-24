namespace TinyGUI.Events
{
    public class VersionCheckedEventArgs : EventArgs
    {
        public string Version { get; }
        public string CurrentVersion { get; }

        public bool NewestVersion { get; }

        public VersionCheckedEventArgs(string? version, string currentVersion)
        {
            version ??= currentVersion;

            Version = version;
            CurrentVersion = currentVersion;

            NewestVersion = !version.Equals(currentVersion, StringComparison.Ordinal);
        }
    }
}
