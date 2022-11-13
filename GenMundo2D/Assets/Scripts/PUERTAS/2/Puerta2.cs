using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta2 : MonoBehaviour
{
    public GameObject puerta;
    public GameObject puerta2;
    public GameObject boton;
    public float TiempoParaAbrirlaPuerta = 15f;


    private void Start()
    {
        puerta.SetActive(false);//SE DESACRTIVA LA PUERTA AL EMPEZAR
        puerta2.SetActive(false);//SE DESACRTIVA LA PUERTA AL EMPEZAR
    }
    private void Update()
    {
        ABRE();
    }
    public void ABRE() //Tiempo para que aparezca el boton para abrir la sala
    {
        if (TiempoParaAbrirlaPuerta < 0)
        {
            boton.SetActive(true);
            TiempoParaAbrirlaPuerta = 10;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //Cuando Juan entra a la sala se cierra
    {
        if (collision.CompareTag("Juan"))
        {
            puerta.SetActive(true);
            puerta2.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision) 
    {
        if (collision.CompareTag("Juan"))
        {
            TiempoParaAbrirlaPuerta -= Time.deltaTime;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) //al salir se desactiva la puerta
    {
        if (collision.CompareTag("Juan"))
        {
            puerta.SetActive(false);
            puerta2.SetActive(false);
        }
    }
}

