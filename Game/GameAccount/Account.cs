using Game.DB;

namespace Game.GameAccount
{
    public class Account : BaseAccount
    {
        public Account(string UserName, byte[] password)
            : base(UserName, password)
        {
        }
        public override void LoseGame(BaseAccount opponent, int GameID)
        {
            CurrentRating -= 1;

            Info info = new Info(GameID, opponent, GameStatus.Lose);
            History.Add(info);
            UserService US = new UserService(new DBContext());
            US.SaveAllStatistics(info, this);

        }
        public override void WinGame(BaseAccount opponent, int GameID)
        {
            CurrentRating += 2;

            Info info = new Info(GameID, opponent, GameStatus.Victory);
            History.Add(info);
        }
    }
}
