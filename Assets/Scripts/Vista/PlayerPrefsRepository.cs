using Controlador;
using Modelo;
using UnityEngine;

namespace Vista {
	public class PlayerPrefsRepository : GameRepository {

		public void Save(Score score) {
			PlayerPrefs.SetInt("Cookies", score.playerTotalCookies);
			PlayerPrefs.SetInt("CookiesIncrement", score.cookiesIncrementAmmount);
		}

	}
}