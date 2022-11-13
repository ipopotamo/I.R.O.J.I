using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABRIRPuerta : MonoBehaviour
{
    public GameObject puerta;


    // Start is called before the first frame update
    private void Start()
    {
        this.gameObject.SetActive(false);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Juan")) 
        {
            //Debug.Log("abro");
            puerta.SetActive(false);

        }
    }
}
