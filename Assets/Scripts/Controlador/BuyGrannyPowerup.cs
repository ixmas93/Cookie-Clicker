using Modelo;
using System;


namespace Controlador
{
    public class BuyGrannyPowerup
    {
        private Score score;
        private CookiesDisplay cookieDisplay;
        private readonly EarnCookiesOvertime _earnCookiesOvertime;
        const int POWERUP_PRICE = 20;

        private readonly IWrongPurchaseNotification _wrongPurchaseNotification;
        private readonly IPurchaseCorrect _purchaseCorrect;

        public BuyGrannyPowerup(Score score, CookiesDisplay cookieDisplay, IWrongPurchaseNotification wrongPurchaseNotification, IPurchaseCorrect purchaseCorrect, EarnCookiesOvertime earnCookies)
        {
            this.score = score;
            this.cookieDisplay = cookieDisplay;
            _wrongPurchaseNotification = wrongPurchaseNotification;
            _purchaseCorrect = purchaseCorrect;
            _earnCookiesOvertime = earnCookies;
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
            _earnCookiesOvertime.AutomaticAdd();
            score.SubstractCookies(POWERUP_PRICE);
            cookieDisplay.DisplayCookies(score.playerTotalCookies);
            _purchaseCorrect.CorrectPurchase();
        }

    }
}
