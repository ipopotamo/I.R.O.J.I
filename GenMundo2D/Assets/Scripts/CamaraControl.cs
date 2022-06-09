using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    public Transform jugador;
    private float TamañoDeLaCamara;
    private float AltoPantalla;
    // Start is called before the first frame update
    void Start()
    {
        TamañoDeLaCamara = Camera.main.orthographicSize;
        AltoPantalla = TamañoDeLaCamara * 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
