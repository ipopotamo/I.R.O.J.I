using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Enemiga : MonoBehaviour
{
    public float velocidad;
    public float checkradius; // Determina cuando empieza a perseguir al jugador
    public float RadioAtaque; // Determina cuando ataca al jugador

    public LayerMask WhatIsPlayer;

    private Transform objetivo;
    private Rigidbody2D rb;
    private Animator anime;
    private Vector2 movimiento;
    public Vector3 Direccion;

    private bool IsinChaseRange;
    private bool IsinAttackRange;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();

        objetivo = GameObject.FindWithTag("Juan").transform;
    }

    private void Update()
    {
        //anime.SetBool
    }
}
