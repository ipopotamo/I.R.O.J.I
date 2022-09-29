using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoDeStats : MonoBehaviour
{
    [SerializeField] public movimiento movimiento;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Juan")
        {
            movimiento.velonormal += 5;
            Debug.Log("cebando");
            Destroy(gameObject);
        }
    }
}
