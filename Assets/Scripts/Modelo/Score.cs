
using System;

namespace Modelo
{
    public class Score {

        public int playerTotalCookies { get; private set; }
        public int clickedCookiesIncrementAmmount { get; private set; }
        public int timedCookiesIncrementAmount { get; private set; }
        public float timeBetweenAdditions { get; private set; }


        public Score() : this(0, 1, 0){}
        
        public Score(int playerTotalCookies, int cookiesIncrementAmmount, int timedCookiesIncrementAmount)
        {
            this.playerTotalCookies = playerTotalCookies;
            this.clickedCookiesIncrementAmmount = cookiesIncrementAmmount;
            this.timedCookiesIncrementAmount = timedCookiesIncrementAmount;
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
            if(amount > playerTotalCookies)
            {
                throw new Exception("No me pueden quitar mas galletas de las que tengo");
            }
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
            timedCookiesIncrementAmount = score.timedCookiesIncrementAmount;
        }
        public void AddCookiesSinceDate(DateTime lastDate,DateTime currentDate)
        {
            TimeSpan timeDifference=currentDate - lastDate;
            float incrementsPending=(float)timeDifference.TotalSeconds/timeBetweenAdditions;
            playerTotalCookies += (int)incrementsPending * timedCookiesIncrementAmount;
        }
    }
}
