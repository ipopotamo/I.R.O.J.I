using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemy : MonoBehaviour
{
    [SerializeField]  private GameObject[] Enemigos;
    [SerializeField]  private  GameObject M_Enemy;

    private int rand;
    void Start()
    {
         Invoke("Spawn", 0.1f);
    }
    void Spawn()
    {
        rand = Random.Range(0, Enemigos.Length);
        Instantiate(Enemigos[rand], M_Enemy.transform );        
    }



}
