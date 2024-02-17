using Modelo;
using System;


namespace Controlador
{
    public class BuyGrannyPowerup
    {
        private Score score;
        private CookiesDisplay cookieDisplay;
        private readonly EarnCookies _earnCookies;
        const int POWERUP_PRICE = 20;

        private readonly IWrongPurchaseNotification _wrongPurchaseNotification;
        private readonly IPurchaseCorrect _purchaseCorrect;

        public BuyGrannyPowerup(Score score, CookiesDisplay cookieDisplay, IWrongPurchaseNotification wrongPurchaseNotification, IPurchaseCorrect purchaseCorrect, EarnCookies earnCookies)
        {
            this.score = score;
            this.cookieDisplay = cookieDisplay;
            _wrongPurchaseNotification = wrongPurchaseNotification;
            _purchaseCorrect = purchaseCorrect;
            _earnCookies = earnCookies;
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
            score.IncrementTimedCookiesAmount();
            _earnCookies.AutomaticAdd();
            score.SubstractCookies(POWERUP_PRICE);
            cookieDisplay.DisplayCookies(score.playerTotalCookies);
            _purchaseCorrect.CorrectPurchase();
        }

    }
}
