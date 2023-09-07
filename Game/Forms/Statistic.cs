using System;
using System.Windows.Forms;

namespace Game.Forms
{
    public partial class Statistic : Form
    {
        public Statistic(string information)
        {
            InitializeComponent();
            StatLabel.Text = information;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new StartForm();
            form.ShowDialog();
        }
    }
}
