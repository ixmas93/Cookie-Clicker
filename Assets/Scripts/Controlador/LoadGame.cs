using Modelo;

namespace Controlador
{
    public class LoadGame
    {
        private GameRepository gameRepository;
        private readonly Score _score;
        private readonly EarnCookies earnCookies;

        private readonly CookiesDisplay _display;

        public LoadGame(GameRepository gameRepository, Score score, CookiesDisplay display, EarnCookies earnCookies)
        {
            this.gameRepository = gameRepository;
            this._score = score;
            this.earnCookies = earnCookies;
            _display = display;
        }

        public void Run()
        {
            Score newScore = gameRepository.LoadGame();
            _score.SetFromOtherScore(newScore);
            EnableTimedCookiesIfNeeded();
            _display.DisplayCookies(_score.playerTotalCookies);
        }

        private void EnableTimedCookiesIfNeeded()
        {
            if (_score.timedCookiesIncrementAmount > 0)
                earnCookies.AutomaticAdd();
        }

    }
}
