using Lab_2_OOP.Accounts;

namespace Lab_2_OOP.Games
{
    public enum result
    {
        win, lose
    }
    public abstract class BaseGame
    {
        protected static uint GameIndex;
        protected int Vipcoef = 2;
        protected int SuperVipcoef = 4;
        public virtual void WinGame(BaseAccount Winner, BaseAccount Loser, int rating)
        {
            GameIndex++;
            RatingCalculation(Winner, rating, result.win);
            LoseGame(Loser, rating);
        }

        public virtual void LoseGame(BaseAccount Loser, int rating)
        {
            RatingCalculation(Loser, rating, result.lose);
        }

        public int RatingCalculation (BaseAccount user, int rating, result status)
        {
            if (0 <= user.ID && user.ID < 100)
            {
                if (status == 0)
                    user.CurrentRating += rating * SuperVipcoef;
                else
                    user.CurrentRating -= rating / SuperVipcoef;
                return user.CurrentRating;
            }
            else if (100 <= user.ID && user.ID <= 1000)
            {
                if (status == 0)
                    user.CurrentRating += rating * Vipcoef;
                else
                    user.CurrentRating -= rating / Vipcoef;
                return user.CurrentRating;
            }
            else
            {
                if (status == 0)
                    user.CurrentRating += rating;
                else
                    user.CurrentRating -= rating;
                return user.CurrentRating;
            }
        }
    }
}