using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Controlador;

namespace Vista
{
    public class Counter : MonoBehaviour, CookiesDisplay
    {
        TMP_Text counterUI;

        private void Awake()
        {
            counterUI = GetComponent<TMP_Text>();
        }


        public void DisplayCookies(int amount)
        {
            counterUI.SetText(amount.ToString());
        }
    }
}
