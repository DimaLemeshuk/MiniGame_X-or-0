using Game.GameAccount;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    public partial class GameForm : Form
    {
        private static int GameCount = 0;
        private Button[,] ButtonsArray = new Button[3, 3];
        public BaseAccount[] Players = new BaseAccount[2];
        private static int CurrentPlayer = 0;

        private static string XO = "O";

        public GameForm(BaseAccount[] baseAccount)
        {
            Players = baseAccount;
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ButtonsArray[i, j] = new Button();
                    Button current = ButtonsArray[i, j];
                    current.Location = new Point(12 + 140 * i, 63 + 140 * j);
                    current.Size = new Size(140, 140);
                    current.Font = new Font((new FontFamily("Comic Sans MS")), 75);
                    current.Click += Button_Click;
                    current.TextAlign = ContentAlignment.MiddleCenter;

                    this.Controls.Add(current);
                }
            }
            
            NamePlayer.Text = "Хід гравця: " + Players[CurrentPlayer].UserName;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            XO = XO.Equals("X") ? "O" : "X";
            current.Text = XO;
            current.Click -= Button_Click; 
            CheckWin();
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            NamePlayer.Text = "Хід гравця: " + Players[CurrentPlayer].UserName;
        }

        void CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((ButtonsArray[i, 0].Text == ButtonsArray[i, 1].Text && ButtonsArray[i, 1].Text == ButtonsArray[i, 2].Text) && ButtonsArray[i, 2].Text != "")
                {
                    IfTrue();
                    return;
                }
                if ((ButtonsArray[i, 0].Text == ButtonsArray[i, 1].Text && ButtonsArray[i, 1].Text == ButtonsArray[i, 2].Text) && ButtonsArray[i, 2].Text != "")
                {
                    IfTrue();
                    return;
                }
            }
            if (ButtonsArray[0, 0].Text == ButtonsArray[1, 1].Text && ButtonsArray[1, 1].Text == ButtonsArray[2, 2].Text && ButtonsArray[2, 2].Text != "")
            {
                IfTrue();
                return;
            }
            if (ButtonsArray[0, 2].Text == ButtonsArray[1, 1].Text && ButtonsArray[1, 1].Text == ButtonsArray[2, 0].Text && ButtonsArray[2, 0].Text != "")
            {
                IfTrue();
                return;
            }
        }

        private void IfTrue()
        {
            BaseAccount Player1 = Players[CurrentPlayer];
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            BaseAccount Player2 = Players[CurrentPlayer];
            MessageBox.Show("Переміг гравець:" + Player1.UserName);
            Player1.WinGame(Player2,GameCount);
            Player2.LoseGame(Player1, GameCount++);
            foreach (var button in ButtonsArray)
            { 
                button.Click -= Button_Click;
            };
        }

        private void clearCells() 
        {
            foreach (var button in ButtonsArray)
            {
                button.Text = "";
                button.Click += Button_Click;
                CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            };
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new StartForm();
            form.ShowDialog();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            clearCells();
        }

    }
}
