using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstadisticasJuanGuardadas : MonoBehaviour
{
    public float defensa;
    public float Ataque;
    public float VidaMax;


    public Slider vidaSlider; //vida de juan pero en barra
    public Vida Juan;
    // Start is called before the first frame update
    void Start()
    {
        Juan = GameObject.FindGameObjectWithTag("Juan").GetComponent<Vida>();
        Juan.vida = VidaMax;
        vidaSlider = GameObject.FindGameObjectWithTag("vidaSlider").GetComponent<Slider>();
        Juan.vida = vidaSlider.value; // refleja el valor de la vida en su respectiva barra 
        vidaSlider.maxValue = VidaMax;




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
