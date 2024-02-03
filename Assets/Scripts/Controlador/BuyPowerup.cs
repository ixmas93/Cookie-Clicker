using Modelo;
using System;


namespace Controlador
{
    public class BuyPowerup
    {
        private Score score;
        private CookiesDisplay cookieDisplay;
        const int POWERUP_PRICE = 20;

        public BuyPowerup(Score score, CookiesDisplay cookieDisplay)
        {
            this.score = score;
            this.cookieDisplay = cookieDisplay;
        }        

        public void Execute()
        {
            if (score.HasEnoughCookies(POWERUP_PRICE))
                Buy();
        }

        private void Buy()
        {
            score.DoubleCookiesIncrement();
            score.SubstractCookies(POWERUP_PRICE);
            cookieDisplay.DisplayCookies(score.playerTotalCookies);
        }

    }
}
