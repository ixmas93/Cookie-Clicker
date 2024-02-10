using Modelo;
using System;


namespace Controlador
{
    public class BuyPowerup
    {
        private Score score;
        private CookiesDisplay cookieDisplay;
        const int POWERUP_PRICE = 20;

        private readonly IWrongPurchaseNotification _wrongPurchaseNotification;

        public BuyPowerup(Score score, CookiesDisplay cookieDisplay, IWrongPurchaseNotification wrongPurchaseNotification)
        {
            this.score = score;
            this.cookieDisplay = cookieDisplay;
            _wrongPurchaseNotification = wrongPurchaseNotification;
        }        

        public void Execute() {
            if (score.HasEnoughCookies(POWERUP_PRICE))
                Buy();
            else
                WrongCallback();
        }

        private void WrongCallback() {
            _wrongPurchaseNotification.OnWrongPurchase();
        }

        private void Buy()
        {
            score.DoubleCookiesIncrement();
            score.SubstractCookies(POWERUP_PRICE);
            cookieDisplay.DisplayCookies(score.playerTotalCookies);
        }

    }

    public interface IWrongPurchaseNotification {
        void OnWrongPurchase();
    }
}