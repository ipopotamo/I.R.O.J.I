using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    [SerializeField]public float veloMov; //a que velocidad rota
    //[SerializeField] public float danoXfuego;

    private void Update()
    {
        transform.Rotate(new Vector3(0f,0f,veloMov)* Time.deltaTime);
    }

   

}
