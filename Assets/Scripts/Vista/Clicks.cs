using Controlador;
using UnityEngine;

namespace Vista
{
    public class Clicks : MonoBehaviour
    {
        private EarnCookies _earnCookies;

        private void Start()
        {
            _earnCookies = FindObjectOfType<Presenter>().EarnCookies;
        }

        public void CookieClick()
        {
            _earnCookies.CookieClick();
        }
    }
}
