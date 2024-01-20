
namespace Modelo
{
    public class Score
    {
        public int playerTotalCookies { get; private set; }
        public int cookiesIncrementAmmount { get; private set; } = 1;


        public void AddCookies(int newCookiesAmmount)
        {
            playerTotalCookies += newCookiesAmmount;
        }
    }
}
