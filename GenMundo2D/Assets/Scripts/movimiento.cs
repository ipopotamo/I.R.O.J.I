using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    [SerializeField]public float velonormal = 5f;
    [SerializeField]public float velo = 5f;
    private Rigidbody2D jugador;
    private Vector2 movi;
    private Animator PlayerAnimator;
    
    private float veloDash = 5f;
    [SerializeField]private float limitDash;
    [SerializeField]private float sigDash;
    

    private RoomTemplates templates;

    void Start()
    {
        jugador = GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");
        movi = new Vector2(movX, movY).normalized;

        PlayerAnimator.SetFloat("Horizontal", movX);
        PlayerAnimator.SetFloat("Vertical", movY);
        PlayerAnimator.SetFloat("Velocidad", movi.magnitude);

        

        if(Input.GetKeyDown(KeyCode.Space))
        {
           if(sigDash > 0){
                sigDash -= Time.deltaTime;
                velo = velonormal;
           }         
         if(sigDash <= 0){
            sigDash = limitDash;
            velo = velo * veloDash;
         }        
           
        }
       
    
    }

    private void FixedUpdate()
    {
        
            jugador.MovePosition(jugador.position + movi * velonormal * Time.fixedDeltaTime);
              
        

    }

}
