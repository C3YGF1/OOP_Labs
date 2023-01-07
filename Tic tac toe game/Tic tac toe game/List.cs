namespace Tic_tac_toe_game
{
    public enum Result
    {
        Lose, Win
    }

    public enum GameType
    {
        Rating, Trnng, Gamble
    }
    [Serializable]
    public class List
    {
        public Account User { get; set; }
        public string UserName { get; set; }
        public int currentRating { get; set; }
        public uint Games { get; set; }
        public uint Wins { get; set; }
        public uint Loses { get; set; }
        protected Result result;
        public Result Result { get { return result; } }
        protected GameType gameType;
        public GameType GameType { get { return gameType; } }

        public List(Account user, string userName, int currentRating, uint games, uint wins, uint loses, Result status, GameType gameType)
        {
            this.User = user;
            UserName = userName;
            this.currentRating = currentRating;
            Games = games;
            Wins = wins;
            Loses = loses;
            this.result = status;
            this.gameType = gameType;
        }
    }
}