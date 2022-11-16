using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JefeVida : MonoBehaviour
{
    [SerializeField] public float vida;
    [SerializeField] public float EntraenSegundaFase; 
    [SerializeField] GameObject fuego;
    public Slider BarraVida;
    [SerializeField] private GameObject Portal;

    private void Start()
    {
         BarraVida = GameObject.FindGameObjectWithTag("BarraVidaJEFE").GetComponent<Slider>();
         BarraVida.maxValue = vida;
    }
    private void Update()
    {
       
        BarraVida.value = vida;
        SegundaFase();
    }
    public void SegundaFase() {
        if (vida < EntraenSegundaFase) {
            fuego.SetActive(true);
        }
    }
    public void TomarDaño(float daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            Destroy(BarraVida.gameObject);
            Destroy(gameObject);
            Instantiate(Portal,this.transform.position, Quaternion.Euler(0, 0, 0));
        }
    }
}