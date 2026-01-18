using System.Diagnostics;
using System.Linq;
using System.Timers;

namespace PowerPlanSwitcher
{
    public class ProcessMonitor
    {
        private readonly Timer timer = new(3000);

        public void Start()
        {
            timer.Elapsed += Check;
            timer.Start();
        }

        private void Check(object? sender, ElapsedEventArgs e)
        {
            bool active = Process.GetProcesses()
                .Any(p => Config.Data.Programs.Contains(p.ProcessName.ToLower() + ".exe"));

            PowerPlan.Set(active ? Config.Data.HighPlan : Config.Data.NormalPlan);
        }
    }
}
