using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public bool PuertaEstado;
    public GameObject puerta;

    public float rango = 10f;
    public Transform CentroSala;
    public Transform[] Enemigos;

    //public List<GameObject> puertas;

    private void Update()
    {
        EncontrarEnemigos();
        if (PuertaEstado == true)
        {
            puerta.SetActive(true);

        }
        else if (PuertaEstado == false)
        {
            puerta.SetActive(false);
        }
    }

    void EncontrarEnemigos() {
        foreach (Transform t in Enemigos) 
        {
            float distancia = Vector3.Distance(CentroSala.position, t.position);
            if (distancia < rango)
            {
                //Si hay enemigos en la sala
                puerta.SetActive(true);
                //Debug.Log("Hay " + Enemigos.Length + " en la sala");
            }
            else 
            {
                //Si no hay enemigos en la sala
                puerta.SetActive(false);
                //Debug.Log("No hay nadie en la sala");
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Juan"))
        {
            PuertaEstado = true;
            Debug.Log("Entro");

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Juan"))
        {
            Destroy(puerta.gameObject);
        }
    }
    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo") && collision.CompareTag("Juan"))
        {
            PuertaEstado = true;
        }
        else
        {
            PuertaEstado = false;
            Destroy(puerta.gameObject);
        }
    }*/

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(CentroSala.position, rango);
    }
}
