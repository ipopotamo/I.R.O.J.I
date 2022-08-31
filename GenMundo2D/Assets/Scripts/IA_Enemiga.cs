using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Enemiga : MonoBehaviour
{
    public float velocidad;
    public float checkradius; // Determina cuando empieza a perseguir al jugador
    public float RadioAtaque; // Determina cuando ataca al jugador

    public bool ShouldRotate; //Should Rotate significa "Debe rotar"

    public LayerMask WhatIsPlayer;

    private Transform objetivo;
    private Rigidbody2D rb;
    private Animator animacion;
    private Vector2 movimiento;
    public Vector3 Direccion;

    private bool isInChaseRange;
    private bool isInAttackRange;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();

        objetivo = GameObject.FindWithTag("Juan").transform;
    }

    private void Update()
    {
        //anime.SetBool("Corriendo", IsinChaseRange);

        isInChaseRange = Physics2D.OverlapCircle(transform.position, checkradius, WhatIsPlayer); // Crea un circulo en representacion al radio de la vista    
        isInAttackRange = Physics2D.OverlapCircle(transform.position, RadioAtaque, WhatIsPlayer);// Crea un circulo en representacion al radio de ataque    

        Direccion = objetivo.position - transform.position;
        float amgulo = Mathf.Atan2(Direccion.y, Direccion.x) * Mathf.Rad2Deg; // En el tutorial usan "Atan", NO Atan2, pero con el 1 hay un error

        Direccion.Normalize();
        movimiento = Direccion;

        if (ShouldRotate)
        {
            animacion.SetFloat("X", Direccion.x);
            animacion.SetFloat("Y", Direccion.y);
        }
    }

    private void FixedUpdate()
    {
        if (isInChaseRange && !isInAttackRange) 
        {
            MoveCharacter(movimiento); // El error es porque aun no creo el metodo 24'58" https://www.youtube.com/watch?v=2xaQYZW6LLA&list=LL&index=12&t=818s
        }
        if (isInAttackRange)
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void MoveCharacter(Vector2 Direccion)
    {
        rb.MovePosition((Vector2)transform.position + (Direccion * velocidad * Time.deltaTime));
    }

    // El tutorial acaba aca solo falta que nos ataque y baje vida, quiza con agregarle el arma, hacer que esta nos siga y hacer la animacion ya estamos
}
