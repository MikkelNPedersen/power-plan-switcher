namespace PowerPlanSwitcher
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null!;
        private ListBox listPrograms;
        private TextBox txtProgram;
        private Button btnAdd;
        private Button btnRemove;
        private TextBox txtNormal;
        private TextBox txtHigh;
        private Button btnSavePlans;

        private void InitializeComponent()
        {
            listPrograms = new ListBox();
            txtProgram = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            txtNormal = new TextBox();
            txtHigh = new TextBox();
            btnSavePlans = new Button();

            Text = "Power Plan Switcher";
            Size = new System.Drawing.Size(400, 400);

            listPrograms.SetBounds(10, 10, 360, 150);
            txtProgram.SetBounds(10, 170, 260, 25);
            btnAdd.SetBounds(280, 170, 90, 25);
            btnRemove.SetBounds(10, 200, 360, 25);

            txtNormal.SetBounds(10, 240, 360, 25);
            txtHigh.SetBounds(10, 270, 360, 25);
            btnSavePlans.SetBounds(10, 310, 360, 30);

            btnAdd.Text = "Add Program";
            btnRemove.Text = "Remove Selected";
            btnSavePlans.Text = "Save Power Plans";

            btnAdd.Click += btnAdd_Click;
            btnRemove.Click += btnRemove_Click;
            btnSavePlans.Click += btnSavePlans_Click;

            Controls.AddRange(new Control[]
            {
                listPrograms, txtProgram, btnAdd, btnRemove,
                txtNormal, txtHigh, btnSavePlans
            });
        }
    }
}
