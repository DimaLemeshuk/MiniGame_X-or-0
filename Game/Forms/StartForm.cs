using Game.DB;
using Game.Forms;
using Game.GameAccount;
using System;
using System.Windows.Forms;

namespace Game
{
    public partial class StartForm : Form
    {
        static BaseAccount account { get; set; }
        static DBContext DB = new DBContext();

        public StartForm( BaseAccount baseAccount)
        {
            account = baseAccount;
            InitializeComponent();
            PlayerName.Text = account.UserName;
            PlayerRating.Text = "Рейтинг: " +  account.CurrentRating;
        }
        public StartForm()
        {
            InitializeComponent();
            PlayerName.Text = account.UserName;
            PlayerRating.Text = "Рейтинг: " + account.CurrentRating;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new LoginForm();
            MessageBox.Show("Гравець2 має авторизуватись ");
            form.ShowDialog();
        }

        private void Form_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Statistic(account.GetHistory());
            form.ShowDialog();
        }

        private void PlayerstableButton_Click(object sender, EventArgs e)
        {
            DBContext DB = new DBContext();
            UserService IUser = new UserService(DB);
            this.Hide();
            Form form = new Statistic(IUser.GetAllStatistics());
            form.ShowDialog();
        }

        private void AllHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Statistic(DBContext.HistoryAllGame);
            form.ShowDialog();
        }
    }
}
