using Modelo;
using System;

namespace Controlador {
	public class SaveGame {
		private readonly GameRepository _repositry;
		private readonly Score _score;
		
		public SaveGame(GameRepository repositry, Score score) {
			_repositry = repositry;
			_score = score;
		}

		public void Run() {
			_repositry.SaveScore(_score);
			_repositry.SaveLastDate();
		}
	}

	public interface GameRepository {
		void SaveScore(Score score);
		void SaveLastDate();
        Score LoadScore();
		DateTime LoadLastDate();
    }
}