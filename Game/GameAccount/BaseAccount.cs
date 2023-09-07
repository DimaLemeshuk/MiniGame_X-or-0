using System.Collections.Generic;

namespace Game.GameAccount
{
    public abstract class BaseAccount
    {
        public string UserName { get; set; }
        private int _CurrentRating;
        public int CurrentRating 
        {
            get
            {
                return _CurrentRating;
            }
            protected set
            {
                if (value < 1)
                {
                    _CurrentRating = 1;
                }
                else
                {
                    _CurrentRating = value;
                }         
            } 
        }
        public byte[] Password { get; private set; }

        public int GameCount
        {
            get { return History.Count; }
        }

        public List<Info> History = new List<Info>();

        public BaseAccount(string UserName, byte[] password)
        {
            this.UserName = UserName;
            CurrentRating = 1;
            Password = password;
        }

        public abstract void WinGame(BaseAccount opponent, int GameID);

        public abstract void LoseGame(BaseAccount opponent, int GameID);

        public string GetHistory()
        {
            string res = "";
            foreach (var info in History)
            {
                res += ("Iндекс гри: " + info.ID + "   Противник: " + info.opponent.UserName + "   Статус: " + info.status + "\n");
            }
            return res;
        }
    }
}
