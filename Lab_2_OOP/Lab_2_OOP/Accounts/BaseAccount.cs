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
        public static uint idBase = 1001;
        public static uint idVip = 101;
        public static uint idSuperVip = 1;
        public uint ID { get; set; }
        public List<List> allStatistics;
        public BaseAccount(string userName)
        {
            UserName = userName;
            CurrentRating = 1000;
            allStatistics = new List<List>();
            Accountstatus = "Base account";
            ID = idBase++;
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
                report.AppendLine($"{item.LoserName}\t\t{item.Status}\t{item.GameType}\t\t{item.currentRating}\t{item.GameIndex}");
            }
            Console.WriteLine("-----------------------------------------------------------");
            return report.ToString();
        }
    }
}
