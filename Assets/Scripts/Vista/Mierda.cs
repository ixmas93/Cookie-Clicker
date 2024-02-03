using Controlador;
using UnityEngine;

public class Mierda : MonoBehaviour, CookiesDisplay
{
    public void DisplayCookies(int amount)
    {
        Debug.Log(amount);
    }

}

public class Cosa : CookiesDisplay
{
    private readonly CookiesDisplay[] allDisplays;

    public Cosa(CookiesDisplay[] allDisplay)
    {
        this.allDisplays = allDisplay;
    }

    public void DisplayCookies(int amount)
    {
        foreach (var item in allDisplays)
        {
            item.DisplayCookies(amount);
        }
    }

}