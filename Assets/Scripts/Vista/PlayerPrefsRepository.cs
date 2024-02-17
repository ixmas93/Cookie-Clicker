using Controlador;
using Modelo;
using UnityEngine;

namespace Vista {
	public class PlayerPrefsRepository : GameRepository {
        public Score LoadGame() {
	        int totalCookies = PlayerPrefs.GetInt("Cookies", new Score().playerTotalCookies);
	        int cookiesIncrement = PlayerPrefs.GetInt("CookiesIncrement", new Score().clickedCookiesIncrementAmmount);
            return new Score(totalCookies,cookiesIncrement);
        }

        public void Save(Score score) {
			PlayerPrefs.SetInt("Cookies", score.playerTotalCookies);
			PlayerPrefs.SetInt("CookiesIncrement", score.clickedCookiesIncrementAmmount);
		}

		
	}
}