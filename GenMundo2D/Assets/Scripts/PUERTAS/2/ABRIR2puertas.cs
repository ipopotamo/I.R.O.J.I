using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABRIR2puertas : MonoBehaviour
{
    public GameObject puerta;
    public GameObject puerta2;

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
            puerta2.SetActive(false);
        }
    }
}
