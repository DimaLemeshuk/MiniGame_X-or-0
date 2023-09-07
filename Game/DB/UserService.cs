using Game.GameAccount;
using System;
using System.Collections.Generic;

namespace Game.DB
{
    class UserService : IUserService
    {

        public DBContext DBContext_ { get; set; }   
        public UserService(DBContext dBContext_)
        {
            DBContext_ = dBContext_;
        }
    
        public void Add(BaseAccount User)
        {
            DBContext.GameAccounts.Add(User);
        }

        public List<BaseAccount> Get()
        {
            return DBContext.GameAccounts;
        }

        public String GetAllStatistics()
        {
            string res = "";
            foreach (var info in DBContext.GameAccounts)
            {
                res += ("Гравець: " + info.UserName + "   Рейтинг: " + info.CurrentRating + "   Кількість зіграних ігр: " + info.GameCount + "\n");
            }
            return res;
        }

        public void SaveAllStatistics(Info info, BaseAccount account)
        {
            string res = "Гравець1: " + info.opponent.UserName + "  Гравець2: " + account.UserName +  "   Статус: Переміг  " + info.opponent.UserName + "\n";
            DBContext.HistoryAllGame += res;
        }
    }
}
