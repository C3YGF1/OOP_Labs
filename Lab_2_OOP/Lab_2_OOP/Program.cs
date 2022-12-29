using Lab_2_OOP.Accounts;

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

            QWE.WinGame(QWE, "QWE", ASD, "ASD", 2000);

            ASD.WinTrainGame(ASD, "ASD", ZXC, "ZXC");

            ZXC.WinGambleGame(ZXC, "ZXC", RTY, "RTY");

            RTY.WinGame(RTY, "RTY", ZXC, "ZXC", 40);
            RTY.WinTrainGame(RTY, "RTY", ASD, "ASD");
            RTY.WinGambleGame(RTY, "RTY", QWE, "QWE");


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