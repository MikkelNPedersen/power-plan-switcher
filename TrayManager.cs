using System.Windows.Forms;

namespace PowerPlanSwitcher
{
    public class TrayManager
    {
        private readonly NotifyIcon tray;

        public TrayManager(Form form)
        {
            tray = new NotifyIcon
            {
                Text = "Power Plan Switcher",
                Icon = System.Drawing.SystemIcons.Application,
                Visible = true,
                ContextMenuStrip = new ContextMenuStrip()
            };

            tray.ContextMenuStrip.Items.Add("Open", null, (_, _) => form.Show());
            tray.ContextMenuStrip.Items.Add("Exit", null, (_, _) => Application.Exit());
            tray.DoubleClick += (_, _) => form.Show();
        }
    }
}
