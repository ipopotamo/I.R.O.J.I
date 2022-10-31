using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    private int rand;
    private RoomTemplates templates;
    public GameObject[] items;
    // Start is called before the first frame update
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("SpawnItem2", 2f);
    }

    private void SpawnItem2()//Establece que el jefe saldra en la ultima sala generada, osea la sala mas lejana
    {
        rand = Random.Range(0, items.Length);
        Instantiate(items[rand], this.transform.position, Quaternion.Euler(5, -1, 0));
    }
}
