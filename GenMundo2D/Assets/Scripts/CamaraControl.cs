using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    public Transform jugador;
    private float TamaņoDeLaCamara;
    private float AltoPantalla;
    // Start is called before the first frame update
    void Start()
    {
        TamaņoDeLaCamara = Camera.main.orthographicSize;
        AltoPantalla = TamaņoDeLaCamara * 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
