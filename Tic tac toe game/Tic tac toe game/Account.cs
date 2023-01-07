using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe_game
{
    [Serializable]
    public class Accounts
    {
        public Accounts() { }
        public List<Account> AccountsList { get; set; } = new List<Account>();
    }

    [Serializable]
    public class Account
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
        public uint Games;
        public uint Wins;
        public uint Loses;
        public List<List> allStatistics;
        public Account(string userName)
        {
            UserName = userName;
            CurrentRating = 1000;
            allStatistics = new List<List>();
            Games = 0;
            Wins = 0;
            Loses = 0;
        }
    }
}
