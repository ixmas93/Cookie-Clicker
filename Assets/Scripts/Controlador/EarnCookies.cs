using Modelo;

namespace Controlador
{
    public class EarnCookies
    {
        private readonly Score _score;
        private readonly CookiesDisplay cookieDisplay;

        public EarnCookies(Score score, CookiesDisplay cookieDisplay)
        {
            _score = score;
            this.cookieDisplay = cookieDisplay;
        }

        public void CookieClick()
        {
            _score.AddCookies();
            cookieDisplay.DisplayCookies(_score.playerTotalCookies);
        }
            
    }


    public interface CookiesDisplay
    {
        public void DisplayCookies(int amount);
    }
}
