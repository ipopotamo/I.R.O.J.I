using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] SalidaBAja;
    public GameObject[] SalidaAlta;
    public GameObject[] SalidaDerecha;
    public GameObject[] SalidaIzquierda;

    public GameObject closedRoom;

    public List<GameObject> rooms;

    public GameObject boss;

    private void Start()
    {
        Invoke("SpawnBoss", 3f);
    }
    void SpawnBoss()
    {
        Instantiate(boss, rooms[rooms.Count - 1].transform.position);
    }

}
