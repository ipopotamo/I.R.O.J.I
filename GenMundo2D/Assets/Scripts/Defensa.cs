using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defensa : MonoBehaviour
{
    public int defensa;
    public float reduccionDa�oXDefensa;
    private float MaxDefensa = 90f;
    [SerializeField]private int AumentoPorTermo;

    private void Update()
    {
       /* Debug.Log("Red" + reduccionDa�oXDefensa);
        Debug.Log("Defensa " + defensa);*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Termo" && defensa<MaxDefensa)
        {
            defensa += AumentoPorTermo;
            Destroy(collision.gameObject);
            reduccionDa�oXDefensa = defensa / 10;
            

        }
    }
}