using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    public Transform jugador;
    private float Tama�oDeLaCamara;
    private float AltoPantalla;
    // Start is called before the first frame update
    void Start()
    {
        Tama�oDeLaCamara = Camera.main.orthographicSize;
        AltoPantalla = Tama�oDeLaCamara * 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
