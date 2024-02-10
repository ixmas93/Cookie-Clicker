using Modelo;

namespace Controlador
{
    public class LoadGame
    {
        private GameRepository gameRepository;
        private readonly Score _score;

        private readonly CookiesDisplay _display;

        public LoadGame(GameRepository gameRepository, Score score, CookiesDisplay display)
        {
            this.gameRepository = gameRepository;
            this._score = score;
            _display = display;
        }

        public void Run()
        {
            Score newScore = gameRepository.LoadGame();
            _score.SetFromOtherScore(newScore);
            _display.DisplayCookies(_score.playerTotalCookies);
        }

    }
}
