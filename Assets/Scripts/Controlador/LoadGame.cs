using Modelo;
using System;

namespace Controlador
{
    public class LoadGame
    {
        private GameRepository gameRepository;
        private readonly Score _score;
        private readonly EarnCookiesOvertime earnCookiesOvertime;

        private readonly CookiesDisplay _display;

        public LoadGame(GameRepository gameRepository, Score score, CookiesDisplay display, EarnCookiesOvertime earnCookies)
        {
            this.gameRepository = gameRepository;
            this._score = score;
            this.earnCookiesOvertime = earnCookies;
            _display = display;
        }

        public void Run()
        {
            DateTime lastDate = gameRepository.LoadLastDate();
            Score newScore = gameRepository.LoadScore();
            _score.SetFromOtherScore(newScore);
            _score.AddCookiesSinceDate(lastDate, DateTime.Now);
            EnableTimedCookiesIfNeeded();
            _display.DisplayCookies(_score.playerTotalCookies);
        }

        private void EnableTimedCookiesIfNeeded()
        {
            if (_score.timedCookiesIncrementAmount > 0)
                earnCookiesOvertime.AutomaticAdd();
        }

    }
}
