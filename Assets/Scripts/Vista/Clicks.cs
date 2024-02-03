using Controlador;
using UnityEngine;

namespace Vista
{
    public class Clicks : MonoBehaviour
    {
        private EarnCookies _earnCookies;

        private void Start()
        {
            _earnCookies = FindObjectOfType<Dependencies>().EarnCookies;
        }

        public void CookieClick()
        {
            _earnCookies.CookieClick();
        }
    }
}
