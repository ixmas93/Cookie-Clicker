using Controlador;
using Modelo;
using UnityEngine;

namespace Vista {
	public class PlayerPrefsRepository : GameRepository {
        public Score LoadGame()
        {
            return new Score(51,10);
        }

        public void Save(Score score) {
			PlayerPrefs.SetInt("Cookies", score.playerTotalCookies);
			PlayerPrefs.SetInt("CookiesIncrement", score.cookiesIncrementAmmount);
		}

		
	}
}