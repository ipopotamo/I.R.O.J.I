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
    public float vida;
    public Slider vidaSlider;
    private Jefe Jefe;


    private void Start()
    {
        vida = vidaSlider.value;
        Time.timeScale = 1f;
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
    }
    private void Update()
    {
        if (vidaSlider.value == 0)
        {
            Time.timeScale = 0f;
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
            vidaSlider.value -= templates.Da�ofuego;
             
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
    public void TomarDa�o(float da�o)
    {
        vidaSlider.value -= da�o;
        if (vidaSlider.value <= 0)
        {
            Time.timeScale = 0f;
            Destroy(gameObject);
            Barravida.SetActive(false);
            moriste.SetActive(true);
            BarravidaJefe.SetActive(false);
        }
    }
}
