using Modelo;

namespace Controlador
{
    public class LoadGame
    {
        private GameRepository gameRepository;
        private readonly Score _score;

        public LoadGame(Score score, GameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
            this._score = score;
        }

        public void Run()
        {
            //Score newScore = gameRepository.LoadGame();
        }

    }
}
