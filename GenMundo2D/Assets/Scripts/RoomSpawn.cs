using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawn : MonoBehaviour
{
    public int openSide;
    //1 = abajo
    //2 = arriba
    //3 = izquierda
    //4 = derecha


    // Se llama al script que contiene listas donde se depositan las salas segun las salidas que tenga
    private RoomTemplates templates;
    private int rand; // una variable para que hacer una seleccion aleatoria.
    private bool spawned = false;
    public int id;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>(); //hago que busque y encuentre al objeto dentro del juego 
        Invoke("Spawn", 0.1f); // invoca las salas
    }
    void Spawn()
    {
        if (spawned == false)
        {
            if (openSide == 1) // si la abertura es de id 1 invoca salas abajo
            {
                //Necesita una sala abajo
                rand = Random.Range(0, templates.SalidaBAja.Length);
                Instantiate(templates.SalidaBAja[rand], transform.position, templates.SalidaBAja[rand].transform.rotation);
            }
            else if (openSide == 2)
            {
                //Necesita una sala arriba
                rand = Random.Range(0, templates.SalidaAlta.Length);
                Instantiate(templates.SalidaAlta[rand], transform.position, templates.SalidaAlta[rand].transform.rotation);
            }
            else if (openSide == 3)
            {
                //Necesita una sala izquierda
                rand = Random.Range(0, templates.SalidaIzquierda.Length);
                Instantiate(templates.SalidaIzquierda[rand], transform.position, templates.SalidaIzquierda[rand].transform.rotation);
            }
            else if (openSide == 4)
            {
                //Necesita una sala derecha
                rand = Random.Range(0, templates.SalidaDerecha.Length);
                Instantiate(templates.SalidaDerecha[rand], transform.position, templates.SalidaDerecha[rand].transform.rotation);
            }
            id = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>().id; // me da miedo borrar lo que hizo brumer
            GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>().id++;
            //Debug.Log(id);
            spawned = true;
        }

    }
    private void OnTriggerEnter(Collider other) // evita el bug del vacio
    {
        if (!CompareTag("LB") || !CompareTag("TL") || !CompareTag("RB") || !CompareTag("RT"))
        {
            if (other.CompareTag("SpawnPoint")) { Destroy(gameObject); }
                 
        } 
    }
}

