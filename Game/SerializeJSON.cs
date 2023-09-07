using Game.DB;
using Game.GameAccount;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Game
{
    class SerializeJSON
    {
        public static void Serialize()
        {
            string AllHistory = DBContext.HistoryAllGame;

            DataContractJsonSerializer dCJS = new DataContractJsonSerializer(typeof(string));

            using (FileStream fs = new FileStream("Data.json",FileMode.OpenOrCreate )) 
            {
                dCJS.WriteObject(fs, AllHistory);
            }
        }

        public static void Deserialize()
        {
            
            DataContractJsonSerializer dCJS = new DataContractJsonSerializer(typeof(string));
            using (FileStream fs = new FileStream("Data.json", FileMode.OpenOrCreate))
            {
                DBContext.HistoryAllGame = (string)dCJS.ReadObject(fs);
            }
        }
    }
}
