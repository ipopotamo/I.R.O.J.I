using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcade_Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] Enemigos;
    [SerializeField] private GameObject M_Enemy;

    private int rand;

    [SerializeField] private float tiempoEntreSpawn = 5f;
    [SerializeField] private float tiempoSiguienteSpawn;
    void Start()
    {
        Invoke("Spawn", 0.1f);
    }

    private void Update()
    {
        if(tiempoSiguienteSpawn > 0)
        {
            tiempoSiguienteSpawn -= Time.deltaTime;
        }
        Invoke("Spawn", 0.1f);
    }
    void Spawn()
    {
        if (tiempoSiguienteSpawn <= 0)
        {
            rand = Random.Range(0, Enemigos.Length);
            Instantiate(Enemigos[rand], M_Enemy.transform);
            tiempoSiguienteSpawn = tiempoEntreSpawn;

        }
    }

}
