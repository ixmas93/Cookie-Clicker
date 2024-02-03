using System;
using Controlador;
using Modelo;
using UnityEngine;

namespace Vista
{
    public class Dependencies : MonoBehaviour
    {
        public Score Score { private set; get; }
        
        public EarnCookies EarnCookies { private set; get; }
        [SerializeField] private bool log;

        private void Awake()
        {
            Score = new Score();
            CookiesDisplay view = log ? FindAnyObjectByType<Mierda>() : FindAnyObjectByType<Counter>();
            CookiesDisplay allViews = new Cosa(new CookiesDisplay[] { FindAnyObjectByType<Mierda>(), FindAnyObjectByType<Counter>() });
            EarnCookies = new EarnCookies(Score, allViews);
        }
    }
}