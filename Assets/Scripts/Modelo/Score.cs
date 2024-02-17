
namespace Modelo
{
    public class Score {

        public int playerTotalCookies { get; private set; }
        public int clickedCookiesIncrementAmmount { get; private set; }
        public int timedCookiesIncrementAmount { get; private set; }
        public float timeBetweenAdditions { get; private set; }


        public Score() : this(0, 1){}
        
        public Score(int playerTotalCookies, int cookiesIncrementAmmount)
        {
            this.playerTotalCookies = playerTotalCookies;
            this.clickedCookiesIncrementAmmount = cookiesIncrementAmmount;
            timeBetweenAdditions = 1;
        }

        public void AddCookies()
        {
            playerTotalCookies += clickedCookiesIncrementAmmount;
        }

        public void AddTimedCookies()
        {
            playerTotalCookies += timedCookiesIncrementAmount;
        }

        public void SubstractCookies(int amount)
        {
            playerTotalCookies -= amount;
        }

        public void DoubleCookiesIncrement()
        {
            clickedCookiesIncrementAmmount *= 2;
        }

        public void IncrementTimedCookiesAmount() {
            timedCookiesIncrementAmount++;
        }

        public bool HasEnoughCookies(int price) => playerTotalCookies >= price;

        public void SetFromOtherScore(Score score)
        {
            playerTotalCookies = score.playerTotalCookies;
            clickedCookiesIncrementAmmount = score.clickedCookiesIncrementAmmount;
        }

    }
}
