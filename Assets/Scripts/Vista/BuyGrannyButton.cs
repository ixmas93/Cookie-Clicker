using UnityEngine;
using Controlador;
using UnityEngine.UI;

namespace Vista
{
    public class BuyGrannyButton : MonoBehaviour
    {
        private BuyGrannyPowerup buyGrannyPowerup;


        private void Start()
        {
            buyGrannyPowerup = FindObjectOfType<Dependencies>().BuyGrannyPowerup;
            GetComponent<Button>().onClick.AddListener(Buy);
        }


        private void Buy()
        {
            buyGrannyPowerup.Execute();
        }

    }
}
