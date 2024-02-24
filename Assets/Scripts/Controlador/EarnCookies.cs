using Modelo;
using System.Threading.Tasks;

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

    public class EarnCookiesOvertime
    {
        private Score score;
        private CookiesDisplay cookiesDisplay;
        private bool automaticAddEnabled;

        public EarnCookiesOvertime(Score score, CookiesDisplay cookiesDisplay)
        {
            this.score = score;
            this.cookiesDisplay = cookiesDisplay;
        }


        public async void AutomaticAdd()
        {
            if (automaticAddEnabled)
                return;

            automaticAddEnabled = true;

            while (automaticAddEnabled)
            {
                await Task.Delay((int)(score.timeBetweenAdditions * 1000));
                score.AddTimedCookies();
                cookiesDisplay.DisplayCookies(score.playerTotalCookies);
            }
        }

        public void DisableAutomaticAdd() => automaticAddEnabled = false;
    }


    public interface CookiesDisplay
    {
        public void DisplayCookies(int amount);
    }
}
