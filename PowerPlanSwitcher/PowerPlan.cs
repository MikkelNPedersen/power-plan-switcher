using System.Diagnostics;

namespace PowerPlanSwitcher
{
    public static class PowerPlan
    {
        private static string? current;

        public static void Set(string guid)
        {
            if (string.IsNullOrWhiteSpace(guid) || guid == current)
                return;

            Process.Start(new ProcessStartInfo
            {
                FileName = "powercfg",
                Arguments = "/setactive " + guid,
                CreateNoWindow = true,
                UseShellExecute = false
            });

            current = guid;
        }
    }
}
