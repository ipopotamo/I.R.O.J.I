using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    [SerializeField]public float velo = 2f;

    private Rigidbody2D jugador;
    private Vector2 movi;
    private Animator PlayerAnimator;
    
    private float activeMoveSpeed;
    public  float dashSpeed;

    public float dashLength  = .5f;
    public float recargaDash = 1f;

    private float dasCounter;
    private float dashCoolCounter;

    private RoomTemplates templates;

    void Start()
    {
        jugador = GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animator>();
        activeMoveSpeed = velo;
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
            activeMoveSpeed = dashSpeed;
            dasCounter = dashLength;
        }
        if(dasCounter > 0)
        {
            dasCounter -= Time.deltaTime;

            if(dasCounter <= 0){
                activeMoveSpeed = velo;
                dasCounter = recargaDash;
            }            
        }
        if(dashCoolCounter > 0){
           dashCoolCounter -= Time.deltaTime;
        }
        
    }

    private void FixedUpdate()
    {
        jugador.MovePosition(jugador.position + movi * velo * Time.fixedDeltaTime);
    }

}
