using Modelo;
using System;


namespace Controlador
{
    public class BuyGrannyPowerup
    {
        private Score score;
        private CookiesDisplay cookieDisplay;
        const int POWERUP_PRICE = 20;

        private readonly IWrongPurchaseNotification _wrongPurchaseNotification;
        private readonly IPurchaseCorrect _purchaseCorrect;

        public BuyGrannyPowerup(Score score, CookiesDisplay cookieDisplay, IWrongPurchaseNotification wrongPurchaseNotification, IPurchaseCorrect purchaseCorrect)
        {
            this.score = score;
            this.cookieDisplay = cookieDisplay;
            _wrongPurchaseNotification = wrongPurchaseNotification;
            _purchaseCorrect = purchaseCorrect;
        }

        public void Execute()
        {
            if (score.HasEnoughCookies(POWERUP_PRICE))
                Buy();
            else
                WrongCallback();
        }

        private void WrongCallback()
        {
            _wrongPurchaseNotification.OnWrongPurchase();
        }

        private void Buy()
        {
            score.DoubleCookiesIncrement();
            score.SubstractCookies(POWERUP_PRICE);
            cookieDisplay.DisplayCookies(score.playerTotalCookies);
            _purchaseCorrect.CorrectPurchase();
        }

    }
}
