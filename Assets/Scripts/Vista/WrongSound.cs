using Controlador;
using UnityEngine;

namespace Vista {
	public class WrongSound : MonoBehaviour, IWrongPurchaseNotification {
		[SerializeField] private AudioSource sound;
		[SerializeField] private AudioClip clip;

		private void PlaySound() {
			sound.PlayOneShot(clip);
		}

		public void OnWrongPurchase() {
			PlaySound();
		}
	}
}