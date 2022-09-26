using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{
 
    private Rigidbody2D rb;
    private CambioDeRotacion mov; 
    private float grav;

    [SerializeField] GameObject Juan;

    [SerializeField] private float T_dash = 0.2f;
    [SerializeField] private float F_dash = 20f;
    [SerializeField] private float C_dash = 1;
    private bool if_dash;
    private bool P_dash = true;


    private void Aweke()    
    {
        rb = GetComponent<Rigidbody2D>();
        mov = GetComponent<CambioDeRotacion>();
        grav = rb.gravityScale;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
           StartCoroutine(Dash());     
        }
    }

    private IEnumerator Dash()
    {
        if_dash = true;
        P_dash = false;
        rb.velocity = new Vector2(Juan.transform.position.x * F_dash, Juan.transform.position.y*F_dash);
        yield return new WaitForSeconds(T_dash);
        if_dash = false;
        //rb.gravityScale = grav;
        yield return new WaitForSeconds(T_dash);
        P_dash = true;

    }
}
