using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    GameObject juan;
    public float veloBala;
    Rigidbody2D balaBR;

    private float TiempoEntreDano = 1f;
    private float TiempoSiguienteDano;

    void Start()
    {
        balaBR = GetComponent<Rigidbody2D>();
        juan = GameObject.FindWithTag("Juan");
        Vector2 moveDir = (juan.transform.position - transform.position).normalized * veloBala;
        balaBR.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(this.gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Muro"))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Juan"))
        {
            TiempoSiguienteDano -= Time.deltaTime;
            if (TiempoSiguienteDano <= 0)
            {
                collision.GetComponent<Vida>().TomarDaño(10);
                TiempoSiguienteDano = TiempoEntreDano;
                Destroy(this.gameObject);
            }
        }
    }
}
