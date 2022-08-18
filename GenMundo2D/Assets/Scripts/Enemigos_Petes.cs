using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos_Petes : MonoBehaviour
{
    public float speed;

    public float stoppingDistance;



    private Transform target;


    void Start(){

        target = GameObject.FindGameObjectWithTag("Juan").GetComponent<Transform>();
    }


    void Update(){

        if (Vector2.Distance(transform.position, target.position) > 3 )
        {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);            
        }


    }


}
