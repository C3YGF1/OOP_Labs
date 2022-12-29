namespace Lab_2_OOP.Accounts
{
    public class VipAccount : BaseAccount
    {
        public VipAccount(string UserName) : base(UserName)
        {
            Accountstatus = "Vip account";
            ID = idVip++;
        }
    }
}
