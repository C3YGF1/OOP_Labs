using System.Runtime.Serialization.Formatters.Binary;

namespace Tic_tac_toe_game
{
    public partial class MainMenu : Form
    {
        Accounts accounts = new Accounts();
        Account account1;
        Account account2;
        bool isSelected1;
        bool isSelected2;
        public MainMenu()
        {
            InitializeComponent();
            ClearInput();
        }
        private void ClearInput()
        {
            tbUsername.Text = string.Empty;
        }

        private void Add(Account account)
        {
            ListViewItem LVI = new ListViewItem(account.UserName);
            LVI.Tag = account;

            lvUsers.Items.Add(LVI);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != string.Empty)
            {
                Account account = new Account(tbUsername.Text);

                Add(account);

                ClearInput();
            }
            else MessageBox.Show("Please, write Username");
        }

        private void SetAccountInList()
        {
            foreach (ListViewItem item in lvUsers.Items)
            {
                if (item.Tag != null)
                {
                    accounts.AccountsList.Add((Account)item.Tag);
                }
            }
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 1)
            {
                Account account = (Account)lvUsers.SelectedItems[0].Tag;

                if (account != null)
                {
                    tbUsername.Text = account.UserName;
                    lbRating.Text = "Rating: " + account.CurrentRating;
                    lbGames.Text = "Games: " + account.Games;
                    lbWins.Text = "Wins: " + account.Wins;
                    lbLoses.Text = "Loses: " + account.Loses;
                    if (isSelected1 == false)
                    {
                        account1 = account;
                        isSelected1 = true;
                    }
                    else if (isSelected2 == false)
                    {
                        account2 = account;
                        isSelected2 = true;
                    }
                }
            }
            else if (lvUsers.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastpoint;

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Serializebin(Accounts accounts)
        {
            BinaryFormatter bin = new BinaryFormatter();

            using (FileStream fs = new FileStream("Accounts.bin", FileMode.OpenOrCreate))
            {
                bin.Serialize(fs, accounts);
            }
        }

        private Accounts Deserializebin()
        {
            BinaryFormatter bin = new BinaryFormatter();

            using (FileStream fs = new FileStream("Accounts.bin", FileMode.OpenOrCreate))
            {
                return (Accounts)bin.Deserialize(fs);
            }
        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            Accounts accounts = Deserializebin();

            foreach (Account account in accounts.AccountsList)
            {
                ListViewItem LVI = new ListViewItem(account.UserName);
                LVI.Tag = account;

                lvUsers.Items.Add(LVI);
            }
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            SetAccountInList();
            Serializebin(accounts);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (isSelected1 == true && isSelected2 == true)
            {
                if (account1 == account2)
                {
                    MessageBox.Show("Choose the different accounts");
                    account1 = null;
                    account2 = null;
                }
                else
                {
                    this.Hide();
                    TicTacToe ticTacToe = new TicTacToe(account1, account2, accounts);
                    ticTacToe.Show();
                }
            }
            else if (isSelected1 == false) MessageBox.Show("You need to choose 2 accounts");
            else if (isSelected2 == false) MessageBox.Show("You don't choose 1 account");
        }
    }
}
