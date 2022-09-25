using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    [SerializeField] private float VeloDisparo;
    private Rigidbody2D DisparoPez;
    private float destroyDelay = 4f;

    private void Awake()
    {
        DisparoPez = GetComponent<Rigidbody2D>(); 
    }

    public void DispararDisparo(Vector2 direccion)
    {
        DisparoPez.velocity = direccion * VeloDisparo;
        Destroy(gameObject, destroyDelay);
    }
    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }
}
