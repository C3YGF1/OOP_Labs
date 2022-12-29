using System.Text;

namespace Lab_2_OOP.Accounts
{
    public abstract class BaseAccount
    {
        public string UserName { get; set; }
        private int currentRating;

        public int CurrentRating
        {
            get { return currentRating; }
            set
            {
                if (value < 1)
                {
                    currentRating = 1;
                    return;
                }
                currentRating = value;
            }
        }
        public string Accountstatus { get; set; }
        protected static uint GameIndex;
        protected static uint idBase = 1001;
        protected static uint idVip = 101;
        protected int Vipcoef = 2;
        protected static uint idSuperVip = 1;
        protected int SuperVipcoef = 4;
        protected uint ID { get; set; }
        protected List<Game> allStatistics;
        Random rand = new Random();
        public BaseAccount(string userName)
        {
            UserName = userName;
            CurrentRating = 1000;
            allStatistics = new List<Game>();
            Accountstatus = "Base account";
            ID = idBase++;
        }

        public void WinGame(BaseAccount User, string userName, BaseAccount Opponent, string opponentName, int rating)
        {
            GameIndex++;
            if (0 <= User.ID && User.ID < 100)
            {
                User.CurrentRating += rating * SuperVipcoef;
                var win = new Game(Opponent, opponentName, User.CurrentRating, GameIndex, Status.Win, GameType.Rating);
                User.allStatistics.Add(win);
                LoseGame(Opponent, userName, rating);
            }
            else if (100 <= User.ID && User.ID <= 1000)
            {
                User.CurrentRating += rating * Vipcoef;
                var win = new Game(Opponent, opponentName, User.CurrentRating, GameIndex, Status.Win, GameType.Rating);
                User.allStatistics.Add(win);
                LoseGame(Opponent, userName, rating);
            }
            else
            {
                User.CurrentRating += rating;
                var win = new Game(Opponent, opponentName, User.CurrentRating, GameIndex, Status.Win, GameType.Rating);
                User.allStatistics.Add(win);
                LoseGame(Opponent, userName, rating);
            }
        }

        public virtual void LoseGame(BaseAccount Opponent, string userName, int rating)
        {
            if (0 <= Opponent.ID && Opponent.ID < 100)
            {
                Opponent.CurrentRating -= rating / SuperVipcoef;
                var lose = new Game(Opponent, userName, Opponent.CurrentRating, GameIndex, Status.Lose, GameType.Rating);
                Opponent.allStatistics.Add(lose);
            }
            else if (100 <= Opponent.ID && Opponent.ID <= 1000)
            {
                Opponent.CurrentRating -= rating / Vipcoef;
                var lose = new Game(Opponent, userName, Opponent.CurrentRating, GameIndex, Status.Lose, GameType.Rating);
                Opponent.allStatistics.Add(lose);
            }
            else
            {
                Opponent.CurrentRating -= rating;
                var lose = new Game(Opponent, userName, Opponent.CurrentRating, GameIndex, Status.Lose, GameType.Rating);
                Opponent.allStatistics.Add(lose);
            }
        }

        public virtual void WinTrainGame(BaseAccount User, string userName, BaseAccount Opponent, string opponentName)
        {
            GameIndex++;
            var win = new Game(Opponent, opponentName, User.CurrentRating, GameIndex, Status.Win, GameType.Trnng);
            User.allStatistics.Add(win);
            LoseTrainGame(Opponent, userName);
        }

        public virtual void LoseTrainGame(BaseAccount Opponent, string userName)
        {
            var lose = new Game(Opponent, userName, Opponent.CurrentRating, GameIndex, Status.Lose, GameType.Trnng);
            Opponent.allStatistics.Add(lose);
        }

        public virtual void WinGambleGame(BaseAccount User, string userName, BaseAccount Opponent, string opponentName)
        {
            GameIndex++;
            var win = new Game(Opponent, opponentName, User.CurrentRating, GameIndex, Status.Win, GameType.Gamble);
            User.allStatistics.Add(win);
            LoseGambleGame(Opponent, userName);
        }

        public virtual void LoseGambleGame(BaseAccount Opponent, string userName)
        {
            int rating = (int)rand.Next(0, 200);
            if (0 <= Opponent.ID && Opponent.ID < 100)
            {
                Opponent.CurrentRating -= rating / SuperVipcoef;
                var lose = new Game(Opponent, userName, Opponent.CurrentRating, GameIndex, Status.Lose, GameType.Gamble);
                Opponent.allStatistics.Add(lose);
            }
            else if (100 <= Opponent.ID && Opponent.ID <= 1000)
            {
                Opponent.CurrentRating -= rating / Vipcoef;
                var lose = new Game(Opponent, userName, Opponent.CurrentRating, GameIndex, Status.Lose, GameType.Gamble);
                Opponent.allStatistics.Add(lose);
            }
            else
            {
                Opponent.CurrentRating -= rating;
                var lose = new Game(Opponent, userName, Opponent.CurrentRating, GameIndex, Status.Lose, GameType.Gamble);
                Opponent.allStatistics.Add(lose);
            }
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            Console.WriteLine("-----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(UserName + " (" + Accountstatus + ")" + " statisstics:");
            Console.ResetColor();
            report.AppendLine("Opponent Name\tResult\tGame type\tRating\tGame index");
            foreach (var item in allStatistics)
            {
                report.AppendLine($"{item.OpponentName}\t\t{item.Status}\t{item.GameType}\t\t{item.currentRating}\t{item.GameIndex}");
            }
            Console.WriteLine("-----------------------------------------------------------");
            return report.ToString();
        }
    }
}
