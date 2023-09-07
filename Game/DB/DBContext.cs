using System;
using System.Collections.Generic;
using Game.GameAccount;

namespace Game.DB
{
    public class DBContext
    {
        public static List<BaseAccount> GameAccounts = new List<BaseAccount>
        {
            /*(BaseAccount) new Account("Vasyl", (MD5.Create().ComputeHash(Encoding.UTF8.GetBytes("1234"))) ),
            (BaseAccount) new Account("Ivan", (MD5.Create().ComputeHash(Encoding.UTF8.GetBytes("12345"))) ),
            (BaseAccount) new Account("Stas",(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes("123456"))) ),
            (BaseAccount) new Account("Vlad", (MD5.Create().ComputeHash(Encoding.UTF8.GetBytes("1234567"))) ),
            (BaseAccount) new ConfinedAccount("Peter", (MD5.Create().ComputeHash(Encoding.UTF8.GetBytes("qwerty"))) )*/
        };

        public static string HistoryAllGame ;
    }

}

