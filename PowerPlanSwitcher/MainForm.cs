using System;
using System.Windows.Forms;

namespace PowerPlanSwitcher
{
    public partial class MainForm : Form
    {
        private readonly ProcessMonitor monitor;
        private readonly TrayManager tray;

        public MainForm()
        {
            InitializeComponent();
            Config.Load();
            ReloadPrograms();

            monitor = new ProcessMonitor();
            monitor.Start();

            tray = new TrayManager(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProgram.Text))
            {
                Config.Data.Programs.Add(txtProgram.Text.ToLower());
                Config.Save();
                ReloadPrograms();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listPrograms.SelectedItem != null)
            {
                Config.Data.Programs.Remove(listPrograms.SelectedItem.ToString()!);
                Config.Save();
                ReloadPrograms();
            }
        }

        private void btnSavePlans_Click(object sender, EventArgs e)
        {
            Config.Data.NormalPlan = txtNormal.Text;
            Config.Data.HighPlan = txtHigh.Text;
            Config.Save();
        }

        private void ReloadPrograms()
        {
            listPrograms.Items.Clear();
            listPrograms.Items.AddRange(Config.Data.Programs.ToArray());
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
