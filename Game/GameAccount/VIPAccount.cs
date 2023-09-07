
namespace Game.GameAccount
{
    public class VIPAccount : BaseAccount
    {
        public static byte[] a = null;
        public VIPAccount(string UserName, byte[] password)
            : base(UserName, password)
        {
        }
        public override void LoseGame( BaseAccount opponent, int GameID )
        {
            Info info = new Info(GameID, opponent, GameStatus.Lose);
            History.Add(info);
        }
        public override void WinGame(BaseAccount opponent, int GameID)
        {
            CurrentRating += 3;

            Info info = new Info(GameID, opponent, GameStatus.Victory);
            History.Add(info);
        }
    }
}
