
namespace Modelo
{
    public class Score {

        public int playerTotalCookies { get; private set; }
        public int cookiesIncrementAmmount { get; private set; }

        public Score() : this(0, 1){}
        
        public Score(int playerTotalCookies, int cookiesIncrementAmmount)
        {
            this.playerTotalCookies = playerTotalCookies;
            this.cookiesIncrementAmmount = cookiesIncrementAmmount;
        }

        public void AddCookies()
        {
            playerTotalCookies += cookiesIncrementAmmount;
        }

        public void SubstractCookies(int amount)
        {
            playerTotalCookies -= amount;
        }

        public void DoubleCookiesIncrement()
        {
            cookiesIncrementAmmount *= 2;
        }

        public bool HasEnoughCookies(int price) => playerTotalCookies >= price;

        public void SetFromOtherScore(Score score)
        {
            playerTotalCookies = score.playerTotalCookies;
            cookiesIncrementAmmount = score.cookiesIncrementAmmount;
        }

    }
}
