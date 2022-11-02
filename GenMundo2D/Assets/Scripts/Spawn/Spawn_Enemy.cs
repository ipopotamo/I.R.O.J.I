using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Enemy : MonoBehaviour
{
    [SerializeField]  private GameObject Tronkito;
    [SerializeField]  private  GameObject M_Enemy;


    void Start()
    {
         Invoke("Spawn", 0.1f);
    }
    void Spawn()
    {
        Instantiate(Tronkito, M_Enemy.transform );        
    }



}
