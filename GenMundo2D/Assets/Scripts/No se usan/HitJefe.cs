using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitJefe : MonoBehaviour
{

    private Jefe Jefe;
    [SerializeField] public float da�o;
    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.CompareTag("Juan"))
        {
            print("Da�o");
            coll.transform.GetComponent<Vida>().TomarDa�o(da�o);
        }
        
    }

    
    
}