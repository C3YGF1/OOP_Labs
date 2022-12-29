using Lab_2_OOP.Accounts;

namespace Lab_2_OOP
{
    public enum Status
    {
        Lose, Win
    }

    public enum GameType
    {
        Rating, Trnng, Gamble
    }

    public class Game
    {
        public BaseAccount Opponent { get; set; }
        public string OpponentName { get; set; }
        public int currentRating { get; set; }
        public uint GameIndex { get; set; }
        protected Status status;
        public Status Status { get { return status; } }
        protected GameType gameType;
        public GameType GameType { get { return gameType; } }

        public Game(BaseAccount Opponent, string opponentName, int currentRating, uint gameIndex, Status status, GameType gameType)
        {
            this.Opponent = Opponent;
            OpponentName = opponentName;
            this.currentRating = currentRating;
            GameIndex = gameIndex;
            this.status = status;
            this.gameType = gameType;
        }
    }
}
