using System.Runtime.Serialization.Formatters.Binary;

namespace Tic_tac_toe_game
{
    public partial class TicTacToe : Form
    {
        public enum Player
        {
            X, O
        }

        public enum result
        {
            win, lose
        }
        Player currentPlayer;
        List<Button> buttons;
        Account account1;
        Account account2;
        int rating = 20;

        public TicTacToe(Account account1, Account account2, Accounts list)
        {
            InitializeComponent();
            RestartGame();
            this.account1 = account1;
            this.account2 = account2;
            RefreshStatistics();
            currentPlayer = Player.X;
            lbUsername.ForeColor = Color.FromArgb(53, 121, 240);
            lbUsername2.ForeColor = Color.Black;
        }

        private void RefreshStatistics()
        {
            lbUsername.Text = account1.UserName;
            lbRating.Text = "Rating: " + account1.CurrentRating;
            lbGames.Text = "Games: " + account1.Games;
            lbWins.Text = "Wins: " + account1.Wins;
            lbLoses.Text = "Loses: " + account1.Loses;
            lbUsername2.Text = account2.UserName;
            lbRating2.Text = "Rating: " + account2.CurrentRating;
            lbGames2.Text = "Games: " + account2.Games;
            lbWins2.Text = "Wins: " + account2.Wins;
            lbLoses2.Text = "Loses: " + account2.Loses;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (currentPlayer)
            {
                case Player.X:
                    currentPlayer = Player.O;
                    button.Text = currentPlayer.ToString();
                    button.BackColor = Color.FromArgb(53, 121, 240);
                    lbUsername.ForeColor = Color.Black;
                    lbUsername2.ForeColor = Color.FromArgb(255, 153, 0);
                    CheckGame();
                    break;
                case Player.O:
                    currentPlayer = Player.X;
                    button.Text = currentPlayer.ToString();
                    button.BackColor = Color.FromArgb(255, 153, 0);
                    lbUsername.ForeColor = Color.FromArgb(53, 121, 240);
                    lbUsername2.ForeColor = Color.Black;
                    CheckGame();
                    break;
            }
            button.Enabled = false;
        }

        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                )
            {
                MessageBox.Show(account2.UserName + " wins");
                WinGame(account2, account1);
                RefreshStatistics();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
            {
                MessageBox.Show(account1.UserName + " wins");
                WinGame(account1, account2);
                RefreshStatistics();
            }
        }

        private void WinGame(Account Winner, Account Loser)
        {
            RestartGame();
            RestartGame();
            Winner.Games++;
            Winner.Wins++;
            RatingCalculation(Winner, rating, result.win);
            var win = new List(Winner, Winner.UserName, Winner.CurrentRating, Winner.Games, Winner.Wins, Winner.Loses, Result.Win, GameType.Rating);
            Winner.allStatistics.Add(win);
            LoseGame(Loser);
        }

        private void LoseGame(Account Loser)
        {
            Loser.Games++;
            Loser.Loses++;
            RatingCalculation(Loser, rating, result.lose);
            var lose = new List(Loser, Loser.UserName, Loser.CurrentRating, Loser.Games, Loser.Wins, Loser.Loses, Result.Lose, GameType.Rating);
            Loser.allStatistics.Add(lose);
        }

        public int RatingCalculation(Account user, int rating, result status)
        {
            if (status == 0)
                user.CurrentRating += rating;
            else
                user.CurrentRating -= rating;
            return user.CurrentRating;
        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor;
            }
            currentPlayer = Player.X;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Serializebin();
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

        private void lbBack_Click(object sender, EventArgs e)
        {
            Serializebin();
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void Serializebin()
        {
            Accounts accounts = new Accounts();

            accounts.AccountsList.Add(account1);
            accounts.AccountsList.Add(account2);

            BinaryFormatter bin = new BinaryFormatter();

            using (FileStream fs = new FileStream("Accounts.bin", FileMode.Append))
            {
                bin.Serialize(fs, accounts);
            }
        }
    }
}
