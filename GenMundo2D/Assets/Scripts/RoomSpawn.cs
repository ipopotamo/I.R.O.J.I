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

    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);
    }
    void Spawn()
    {
        if (spawned == false)
        {
            if (openSide == 1)
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

            spawned = true;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            Destroy(gameObject);
        }

    }
}

