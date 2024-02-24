using System;
using Controlador;
using Modelo;
using UnityEngine;

namespace Vista {
	public class PlayerPrefsRepository : GameRepository {

        public Score LoadScore() {
	        int totalCookies = PlayerPrefs.GetInt("Cookies", new Score().playerTotalCookies);
	        int cookiesIncrement = PlayerPrefs.GetInt("CookiesIncrement", new Score().clickedCookiesIncrementAmmount);
			int timedCookiesIncrement = PlayerPrefs.GetInt("TimedCookiesIncrement", new Score().timedCookiesIncrementAmount);
            return new Score(totalCookies,cookiesIncrement, timedCookiesIncrement);
        }

        public void SaveScore(Score score) {
			PlayerPrefs.SetInt("Cookies", score.playerTotalCookies);
			PlayerPrefs.SetInt("CookiesIncrement", score.clickedCookiesIncrementAmmount);
			PlayerPrefs.SetInt("TimedCookiesIncrement", score.timedCookiesIncrementAmount);
		}

		public DateTime LoadLastDate() {
			string date=PlayerPrefs.GetString("LastDate",DateTime.Now.ToString());
            return DateTime.Parse(date);
			
		}
        
		public void SaveLastDate() {
			PlayerPrefs.SetString("LastDate", DateTime.Now.ToString());
		}
	}
}