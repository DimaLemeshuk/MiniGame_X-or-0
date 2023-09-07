using Game.DB;
using Game.GameAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Game.Forms
{
    public partial class RegistrationForm : Form
    {
        DBContext DB;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string login = this.login.Text;
            byte[] password = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(this.password.Text));
            byte[] repeat = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(this.RepeatPassword.Text));

            UserService IUser = new UserService(DB);
            List<BaseAccount> GameAccounts = IUser.Get();

            if (String.IsNullOrEmpty(login) || password.Length==0 || repeat.Length==0)
            {
                this.InfoLabel.Text = "Заповніть всі поля";
                return;
            }
            else
            {
                if (GameAccounts.Any(x => x.UserName == login))
                {
                    this.InfoLabel.Text = "Такий логін вже існує\nБудь ласка введіть інший логін";
                }
                else if (login.Length < 2)
                {
                    this.InfoLabel.Text = "Логін занадто короткий\nБудь ласка введіть інший логін";
                }
                else if ( !Enumerable.SequenceEqual(password, repeat))
                {
                    this.InfoLabel.Text = "Паролі не співпадають";
                }
                else
                {
                    BaseAccount User = new Account(login, repeat);
                    IUser.Add(User);
                    this.InfoLabel.Text = "Користувача зареєстровано\nУвійдіть в акаунт";
                }
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new LoginForm();
            form.ShowDialog();
        }
    }
}
