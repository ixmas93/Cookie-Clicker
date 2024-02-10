using Modelo;

namespace Controlador {
	public class SaveGame {
		private readonly GameRepository _repositry;
		private readonly Score _score;
		
		public SaveGame(GameRepository repositry, Score score) {
			_repositry = repositry;
			_score = score;
		}

		public void Run() {
			_repositry.Save(_score);
		}
	}

	public interface GameRepository {
		void Save(Score score);
	}
}