using Modelo;
using System.Threading.Tasks;

namespace Controlador
{
    public class EarnCookies
    {
        private readonly Score _score;
        private readonly CookiesDisplay cookieDisplay;
        private bool automaticAddEnabled;

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

        public async void AutomaticAdd()
        {
            if (automaticAddEnabled)
                return;
            
            automaticAddEnabled = true;

            while (true)
            {
                await Task.Delay((int)(_score.timeBetweenAdditions * 1000));
                _score.AddTimedCookies();
                cookieDisplay.DisplayCookies(_score.playerTotalCookies);
            }
        }
            
    }


    public interface CookiesDisplay
    {
        public void DisplayCookies(int amount);
    }
}
