using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoMientrasRota : MonoBehaviour
{
    [SerializeField] private float danoXfuego;
    [SerializeField] private float TiempoEntreDano;
    private float TiempoSiguienteDano;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Juan"))
        {
            TiempoSiguienteDano -= Time.deltaTime;
            if (TiempoSiguienteDano<=0)
            { 
                collision.GetComponent<Vida>().TomarDaño(danoXfuego);
                TiempoSiguienteDano = TiempoEntreDano;
            }
        }
    }
}
