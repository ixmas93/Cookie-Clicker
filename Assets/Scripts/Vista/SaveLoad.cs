using System;
using UnityEngine;
using UnityEngine.UI;

namespace Vista {
	public class SaveLoad : MonoBehaviour {
		private void Start() {
			GetComponent<Button>().onClick.AddListener(SaveGame);

			LoadGame();
		}

		private void LoadGame() => FindObjectOfType<Dependencies>().loadGame.Run();

		private void SaveGame() => FindObjectOfType<Dependencies>().saveGame.Run();

		private void OnApplicationQuit() => SaveGame();

    }
}