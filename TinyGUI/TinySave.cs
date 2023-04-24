using TinyGUI.Utils;

// TODO: Add Exceptions
namespace TinyGUI
{
    internal sealed class TinySave
    {
        private readonly string configName = "config.json";
        private readonly string? configPath;

        private readonly string statsName = "statistics.json";
        private readonly string? statsPath;

        private readonly string folderName = "Data";
        private readonly string? folderPath;

        public TinySave()
        {
            try
            {
                folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);
                configPath = Path.Combine(folderPath, configName);
                statsPath = Path.Combine(folderPath, statsName);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); // TODO: Add Exceptions
            }
        }

        public TinySettings LoadSettings()
        {
            if (configPath == null) return new TinySettings();
            return JsonUtils.LoadJsonFile(configPath, new TinySettings());
        }

        public TinyStatistics LoadStatistics()
        {
            if (statsPath == null) return new TinyStatistics();
            return JsonUtils.LoadJsonFile(statsPath, new TinyStatistics());
        }

        public void SaveSettings(TinySettings settings)
        {
            if (configPath == null) return;
            JsonUtils.SaveJsonFile(configPath, settings);
        }

        public void SaveStatistics(TinyStatistics statistics)
        {
            if (statsPath == null) return;
            JsonUtils.SaveJsonFile(statsPath, statistics);
        }
    }
}