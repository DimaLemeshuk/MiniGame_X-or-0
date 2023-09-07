
namespace Game.GameAccount
{
    public class Info
    {
        public BaseAccount opponent { get; private set; }
        public int ID { get; private set; }
        public GameStatus status { get; private set; }
        public Info(int ID, BaseAccount opponent, GameStatus status)
        {
            this.ID = ID;
            this.opponent = opponent;
            this.status = status;
        }
    }
}
