using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    [SerializeField] private GameObject Barravida;
    [SerializeField] private GameObject BarravidaJefe;
    [SerializeField] private GameObject moriste;
    private RoomTemplates templates;
    //public float vida;
    public Slider vidaSlider;
    private Jefe Jefe;


    private void Start()
    {
       // vida = vidaSlider.value;
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
    }
    private void Update()
    {
        if (vidaSlider.value == 0)
        {
            Destroy(gameObject);
            Barravida.SetActive(false);
            moriste.SetActive(true);
            BarravidaJefe.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fuego")
        {
            vidaSlider.value -= templates.Dañofuego;
             
        }
        if (collision.gameObject.tag == "VistaJefe")
        {
            BarravidaJefe.SetActive(true);
        }
        if (collision.gameObject.tag == "Mas_Vida")
        {
            vidaSlider.value += templates.RecuperaHP;
            Destroy(collision.gameObject);
        }     
    }
    public void TomarDaño()
    {
        vidaSlider.value -= Jefe.daño;
        if (vidaSlider.value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
