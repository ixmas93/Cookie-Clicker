using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Controlador;

public class Counter : MonoBehaviour
{
    TMP_Text counterUI;
    Presenter presenter;

    private void Awake()
    {
        counterUI = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        presenter = FindObjectOfType<Presenter>();
    }

    private void Update()
    {
        counterUI.SetText(presenter.Score.playerTotalCookies.ToString());
    }
}
