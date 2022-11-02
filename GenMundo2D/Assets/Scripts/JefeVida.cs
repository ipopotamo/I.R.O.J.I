using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefeVida : MonoBehaviour
{
    [SerializeField] public float vida;
    [SerializeField] public float EntraenSegundaFase; 
    [SerializeField] GameObject fuego;

    private void Update()
    {
        SegundaFase();
    }
    public void SegundaFase() {
        if (vida < EntraenSegundaFase) {
            fuego.SetActive(true);
        }
    }
    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}