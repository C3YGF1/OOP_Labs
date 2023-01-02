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

    public class List
    {
        public BaseAccount Loser { get; set; }
        public string LoserName { get; set; }
        public int currentRating { get; set; }
        public uint GameIndex { get; set; }
        protected Status status;
        public Status Status { get { return status; } }
        protected GameType gameType;
        public GameType GameType { get { return gameType; } }

        public List(BaseAccount loser, string loserName, int currentRating, uint gameIndex, Status status, GameType gameType)
        {
            this.Loser = loser;
            LoserName =  loserName;
            this.currentRating = currentRating;
            GameIndex = gameIndex;
            this.status = status;
            this.gameType = gameType;
        }
    }
}
