using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitJefe : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Juan"))
        {
            print ("Daño");
        }
    }
}
