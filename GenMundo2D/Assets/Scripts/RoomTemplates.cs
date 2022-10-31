using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    //eSTE ES UN objeto que se encuentra en el juego con el mismo nombre se establecen todas y cada una de las salas segun las sa�lidas de las mismas
    public GameObject[] SalidaBAja;
    public GameObject[] SalidaAlta;
    public GameObject[] SalidaDerecha;
    public GameObject[] SalidaIzquierda;

    private int rand;


    // Muestra Los da�os recibidos por entornos y recuperacion
    public float Da�ofuego = 0;
    public float AumentoYerba = 50;
    public float RecuperaHP = 50;
    public int id = 0;

    public GameObject closedRoom; // sala cerrada que nunca se usa 

    public List<GameObject> rooms; // lista de salas generadas para saber donde spawnea goyo

    public GameObject boss; //Establecemo el jefe del piso, pueden ser varios si lo hacemos igual que las SALIDAS
    public GameObject[] items;
    private void Start() //Invoca el metodo para aparecer al jefe del piso
    {
        Invoke("SpawnBoss", 3f);
        //Invoke("SpawnItem", 2f);
    }
    void SpawnBoss()//Establece que el jefe saldra en la ultima sala generada, osea la sala mas lejana
    {
        Instantiate(boss, rooms[rooms.Count - 1].transform.position, Quaternion.Euler(5,-1,0));
    }

    void SpawnItem()//Establece que el jefe saldra en la ultima sala generada, osea la sala mas lejana
    {
        rand = Random.Range(0, items.Length);
        Instantiate(items[rand], rooms[rand].transform.position, Quaternion.Euler(5, -1, 0));
    }
}
