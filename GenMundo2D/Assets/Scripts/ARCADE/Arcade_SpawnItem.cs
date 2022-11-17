using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcade_SpawnItem : MonoBehaviour
{
    [SerializeField] private GameObject[] iTEMS;


    private int rand;

    [SerializeField] private float tiempoEntreSpawn = 5f;
    [SerializeField] private float tiempoSiguienteSpawn;
    void Start()
    {
        Invoke("Spawn", 0.1f);
    }

    private void Update()
    {
        if (tiempoSiguienteSpawn > 0)
        {
            tiempoSiguienteSpawn -= Time.deltaTime;
        }
        Invoke("Spawn", 0.1f);
    }
    void Spawn()
    {
        if (tiempoSiguienteSpawn <= 0)
        {
            rand = Random.Range(0, iTEMS.Length);
            Instantiate(iTEMS[rand], this.transform.position, Quaternion.Euler(5, -1, 0));
            tiempoSiguienteSpawn = tiempoEntreSpawn;
        }
    }
}
