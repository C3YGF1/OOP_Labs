using Lab_2_OOP.Accounts;

namespace Lab_2_OOP.Games
{
    class TrainGame : BaseGame
    {
        public override void WinGame(BaseAccount Winner, BaseAccount Loser, int rating)
        {
            base.WinGame(Winner, Loser, rating);
            var win = new List(Loser, Loser.UserName, Winner.CurrentRating, GameIndex, Status.Win, GameType.Trnng);
            Winner.allStatistics.Add(win);
        }

        public override void LoseGame(BaseAccount Loser, int rating)
        {
            base.LoseGame(Loser, rating);
            var lose = new List(Loser, Loser.UserName, Loser.CurrentRating, GameIndex, Status.Lose, GameType.Trnng);
            Loser.allStatistics.Add(lose);
        }
    }
}
