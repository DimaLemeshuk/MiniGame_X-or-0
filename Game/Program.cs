using System;
using System.Windows.Forms;

namespace Game
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            SerializeJSON.Deserialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            SerializeJSON.Serialize();
        }
    }
}
