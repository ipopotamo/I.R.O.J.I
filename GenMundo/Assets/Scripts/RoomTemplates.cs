using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    private int rand;
    public GameObject[] SalidaBAja;
    public GameObject[] SalidaAlta;
    public GameObject[] SalidaDerecha;
    public GameObject[] SalidaIzquierda;

    public GameObject closedRoom;

    public List<GameObject> rooms;

    public GameObject[] boss;

    private void Start()
    {
        Invoke("SpawnBoss", 3f);
    }
    void SpawnBoss()
    {
        rand = Random.Range(0,boss.Length);
        Instantiate(boss[rand], rooms[rooms.Count - 1]. transform.position, Quaternion.Euler(90, 0, 0));
        //Instantiate(boss, rooms[rooms.Count - 1].transform.position, Quaternion.Euler(90,0,0));
    }

}
