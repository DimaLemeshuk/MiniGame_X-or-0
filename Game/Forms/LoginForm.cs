using Game.DB;
using Game.Forms;
using Game.GameAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class LoginForm : Form
    {
        static DBContext DB = new DBContext();
        UserService IUser = new UserService(DB);

        static BaseAccount account1 = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = this.login.Text;
            byte[] password = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(this.password.Text));

            List<BaseAccount> GameAccounts = IUser.Get(); 

            if (String.IsNullOrEmpty(login) || password.Length == 0)
            {
                this.InfoLabel.Text = "Заповніть всі поля";
                return;
            }
            else
            {
                BaseAccount account;
                if (!GameAccounts.Any(x => x.UserName == login))
                {
                    this.InfoLabel.Text = "Такого логіна не існує\nБудь ласка перевірте введені дані";
                }
                else if ( !Enumerable.SequenceEqual(GameAccounts.First(x => x.UserName == login).Password, password))
                {
                    this.InfoLabel.Text = "Пароль невірний\nБудь ласка перевірте введені дані";
                }
                else
                {
                    account = GameAccounts.First(x => x.UserName == login);
                    if (account1 == null)
                    {
                        account1 = account;
                        this.Hide();
                        Form form = new StartForm(account);
                        form.ShowDialog();
                    }
                    else
                    {
                        if (account1.UserName == account.UserName)
                        {
                            this.InfoLabel.Text = "Увійдіть в інший акаунт\nВи не можете грати самі з собою ";
                        }
                        else 
                        {
                            this.Hide();
                            BaseAccount[] Players = { account1, account };
                            Form GameForm = new GameForm(Players);
                            GameForm.ShowDialog();
                        }
                    }                   
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new RegistrationForm();
            form.ShowDialog();
        }
    }
}
