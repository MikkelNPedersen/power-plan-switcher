using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PowerPlanSwitcher
{
    public static class Config
    {
        public static AppConfig Data { get; private set; } = new();

        private static readonly string Path =
            System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData)
            + "\\PowerPlanSwitcher\\config.json";

        public static void Load()
        {
            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Path)!);
            if (File.Exists(Path))
                Data = JsonSerializer.Deserialize<AppConfig>(File.ReadAllText(Path))!;
            Save();
        }

        public static void Save()
        {
            File.WriteAllText(Path, JsonSerializer.Serialize(Data, new JsonSerializerOptions { WriteIndented = true }));
        }
    }

    public class AppConfig
    {
        public List<string> Programs { get; set; } = new();
        public string NormalPlan { get; set; } = "";
        public string HighPlan { get; set; } = "";
    }
}
