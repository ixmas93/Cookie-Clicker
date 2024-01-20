
namespace Modelo
{
    public class Score
    {
        public int playerTotalCookies { get; private set; }


        public void AddCookies(int newCookiesAmmount)
        {
            playerTotalCookies += newCookiesAmmount;
        }
    }
}
