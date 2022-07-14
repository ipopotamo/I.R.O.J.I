using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemigo : MonoBehaviour
{
    public Animator ani;
    public Jefe jefe;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Juan"))
        {
            ani.SetBool("caminar", false);
            ani.SetBool("correr", false);
            ani.SetBool("ataque 1", true);
            jefe.atacando = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}