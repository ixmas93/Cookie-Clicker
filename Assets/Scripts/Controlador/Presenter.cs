using System;
using Modelo;
using UnityEngine;

namespace Controlador
{
    public class Presenter : MonoBehaviour
    {
        public Score Score { private set; get; }
        
        public EarnCookies EarnCookies { private set; get; }

        private void Awake()
        {
            Score = new Score();
            EarnCookies = new EarnCookies(Score);
        }
    }
}