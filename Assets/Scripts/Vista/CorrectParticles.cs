using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Controlador;
public class CorrectParticles : MonoBehaviour, INotifyCorrectPurchase
{
    [SerializeField] ParticleSystem particles;

    public void CorrectPurchase()
    {
        Correct();
    }

    void Correct() {
        particles.Play();
    }

}
