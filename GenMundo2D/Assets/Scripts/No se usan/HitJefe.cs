using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitJefe : MonoBehaviour
{

    private Jefe Jefe;
    [SerializeField] public float daño;
    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.CompareTag("Juan"))
        {
            print("Daño");
            coll.transform.GetComponent<Vida>().TomarDaño(daño);
        }
        
    }

    
    
}