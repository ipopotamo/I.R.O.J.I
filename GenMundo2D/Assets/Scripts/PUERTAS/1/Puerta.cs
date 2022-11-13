using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public GameObject puerta;
    public GameObject boton;
    public float TiempoParaAbrirlaPuerta = 15f;

    //public Transform CentroSala;
    //public Transform[] Enemigos;
    //public float rango = 10f;
    //public List<GameObject> puertas;
    private void Start()
    {
        puerta.SetActive(false);
    }
    private void Update()
    {  
        ABRE();
    }
    public void ABRE()
    {
        if (TiempoParaAbrirlaPuerta < 0)
        {
            boton.SetActive(true);
            TiempoParaAbrirlaPuerta = 10;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.CompareTag("Juan"))
       {
          puerta.SetActive(true);
          //Debug.Log("Entro");
       }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Juan")) 
        {
            TiempoParaAbrirlaPuerta -= Time.deltaTime;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
            {
                if (collision.CompareTag("Juan"))
                {
                    puerta.SetActive(false);
                }
            }
/*    void EncontrarEnemigos() {
        foreach (Transform t in Enemigos) 
        {
            float distancia = Vector3.Distance(CentroSala.position, t.position);
            if (distancia < rango)
            {
                //Si hay enemigos en la sala
                contador += 1;
                //Debug.Log("Hay " + Enemigos.Length + " en la sala");
            }
            else 
            {
                //Si no hay enemigos en la sala
                contador -= 1;
                //Debug.Log("No hay nadie en la sala");
            }
        }
        
    }*/

    
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
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(CentroSala.position, rango);
    }*/
}
