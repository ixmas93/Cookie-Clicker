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
        public SaveGame saveGame { get; set; }
        public LoadGame loadGame { get; set; }

        public BuyPowerup BuyPowerup;
        public BuyGrannyPowerup BuyGrannyPowerup;
        [SerializeField] private bool log;

        private void Awake()
        {
            Score = new Score();
            CookiesDisplay view = log ? FindAnyObjectByType<Mierda>() : FindAnyObjectByType<Counter>();
            CookiesDisplay allViews = new Cosa(new CookiesDisplay[] { FindAnyObjectByType<Mierda>(), FindAnyObjectByType<Counter>() });
            EarnCookies = new EarnCookies(Score, allViews);
            
            IPurchaseCorrect correct = FindAnyObjectByType<CorrectParticles>();
            IWrongPurchaseNotification wrong = FindAnyObjectByType<WrongSound>();
            
            BuyPowerup = new BuyPowerup(Score, allViews, wrong, correct);
            BuyGrannyPowerup = new BuyGrannyPowerup(Score, allViews, wrong, correct, EarnCookies);

            PlayerPrefsRepository repository = new();
            saveGame = new SaveGame(repository, Score);
            loadGame = new LoadGame(repository, Score, allViews, EarnCookies);
        }

        private void OnApplicationQuit()
        {
            EarnCookies.DisableAutomaticAdd();
        }

    }
}