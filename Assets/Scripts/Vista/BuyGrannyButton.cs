using UnityEngine;
using Controlador;
using UnityEngine.UI;

namespace Vista
{
    public class BuyGrannyButton : MonoBehaviour
    {
        private BuyPowerup buyPowerup;


        private void Start()
        {
            buyPowerup = FindObjectOfType<Dependencies>().BuyPowerup;
            GetComponent<Button>().onClick.AddListener(Buy);
        }


        private void Buy()
        {
            buyPowerup.Execute();
        }

    }
}
