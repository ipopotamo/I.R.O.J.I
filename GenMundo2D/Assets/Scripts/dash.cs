using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{
 
    private Rigidbody2D rb;
    private movimiento mov; 
    private float grav;

    [Header("dash")]
    [SerializeField] private float T_dash = 0.2f;
    [SerializeField] private float F_dash = 20f;
    [SerializeField] private float C_dash = 1;
    private bool if_dash;
    private bool P_dash = true;


    private void Aweke()    
    {
        rb = GetComponent<Rigidbody2D>();
        mov = GetComponent<movimiento>();
        grav = rb.gravityScale;
    }

    void Update()
    {
        
    }

    private void Dash()
    {
        if_dash = true;
        P_dash = false;
        grav = 0f;
       // rb.Velocity = new Vector2();
    }
}
