using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    [SerializeField]private float velo = 2f;

    private Rigidbody2D jugador;
    private Vector2 movi;
    private Animator PlayerAnimator;

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

    }

    private void FixedUpdate()
    {
        jugador.MovePosition(jugador.position + movi * velo * Time.fixedDeltaTime);
    }
}
