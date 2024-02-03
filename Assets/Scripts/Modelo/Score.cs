
namespace Modelo
{
    public class Score
    {
        
        public int playerTotalCookies { get; private set; }
        private int cookiesIncrementAmmount { get; } = 1;


        public void AddCookies()
        {
            playerTotalCookies += cookiesIncrementAmmount;
        }
    }
}
