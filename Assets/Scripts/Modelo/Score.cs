
namespace Modelo
{
    public class Score
    {
        
        public int playerTotalCookies { get; private set; }
        public int cookiesIncrementAmmount { get; private set; } = 1;


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

    }
}
