using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public float VeloBala = 3f;

    public float TiempoDeVida = 5;

    public bool disparado;

    private Transform objetivo;

    private void Start()
    {
        objetivo = GameObject.FindWithTag("Juan").transform;
        Destroy(gameObject,TiempoDeVida);
    }

    private void Update()
    {
        if (disparado)
        {
            transform.Translate(Vector2.left*VeloBala*Time.deltaTime);
        }
        
    }
}
