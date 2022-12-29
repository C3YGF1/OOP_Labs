namespace Lab_2_OOP.Accounts
{
    public class SuperVipAccount : BaseAccount
    {
        public SuperVipAccount(string UserName) : base(UserName)
        {
            CurrentRating = 2000;
            Accountstatus = "Super Vip account";
            ID = idSuperVip++;
        }
    }
}
