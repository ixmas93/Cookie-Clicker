using System;
using UnityEngine;
using UnityEngine.UI;

namespace Vista {
	public class SaveInput : MonoBehaviour {
		private void Start() {
			GetComponent<Button>().onClick.AddListener(SaveGame);
		}

		private void SaveGame() {
			FindObjectOfType<Dependencies>().saveGame.Run();
		}
	}
}