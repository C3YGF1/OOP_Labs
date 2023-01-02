using Lab_2_OOP.Accounts;
using Lab_2_OOP.Games;

namespace Lab_2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var QWE = new Account("QWE");
            var ASD = new Account("ASD");
            var ZXC = new VipAccount("ZXC");
            var RTY = new SuperVipAccount("RTY");

            var StandartGame = new StandartGame();
            var TrainGame = new TrainGame();
            var GambleGame = new GambleGame();

            StandartGame.WinGame(QWE, ASD, 2000);

            TrainGame.WinGame(ASD, ZXC, 0);

            GambleGame.WinGame(ZXC, RTY, 20);

            StandartGame.WinGame(RTY, ZXC, 40);
            TrainGame.WinGame(RTY, ASD, 0);
            GambleGame.WinGame(RTY, QWE, 60);


            Console.WriteLine(QWE.GetAccountHistory());
            Console.WriteLine();
            Console.WriteLine(ASD.GetAccountHistory());
            Console.WriteLine();
            Console.WriteLine(ZXC.GetAccountHistory());
            Console.WriteLine();
            Console.WriteLine(RTY.GetAccountHistory());
        }
    }
}