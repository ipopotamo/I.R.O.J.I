using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{


    private Rigidbody2D jugador;
    private Vector2 movi;
    private Animator PlayerAnimator;
    
    private float veloDash = 5f;
    [SerializeField]public float velo = 5f;
    [SerializeField]private float cantDash = 3f;
    [SerializeField]private float limitDash;
    [SerializeField]private float sigDash;
    

    private RoomTemplates templates;

    void Start()
    {
        jugador = GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animator>();
    }

    
    void Update()
    {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");
        movi = new Vector2(movX, movY).normalized;
   
        PlayerAnimator.SetFloat("Horizontal", movX);
        PlayerAnimator.SetFloat("Vertical", movY);
        PlayerAnimator.SetFloat("Velocidad", movi.magnitude);

           if(sigDash > 0){
            sigDash -= Time.deltaTime;           
        }
        if(Input.GetKeyDown(KeyCode.Space) && sigDash <= 0 && cantDash > 0)
        {
           sigDash = limitDash;
           PlayerAnimator.SetTrigger("dash");
           velo = velo * veloDash;
           cantDash--;
        }
         
    } 
    

    private void FixedUpdate()
    {
        jugador.MovePosition(jugador.position + movi * velo * Time.fixedDeltaTime);     
             
            if(sigDash <= 0 && velo >= 25f){
              velo = 5f;
              jugador.MovePosition(jugador.position + movi * velo * Time.fixedDeltaTime);      
            }              

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mate")
        {
            velo += 5;
            Debug.Log("cebando");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Mate_do_dash")
        {
            cantDash ++;
            Debug.Log("Cabado");
            Destroy(collision.gameObject);
        }
    }
    
    

}