using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateCuerpoaCuerpo : MonoBehaviour
{
    [SerializeField] private Transform controladorGolpe;
    [SerializeField] private float RadioDeGolpe;
    [SerializeField] private float RadioDeBarrido;
    [SerializeField] private float DañoGolpe;
    [SerializeField] private float DañoBarrido;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Golpe();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Barrido();
        }
    }
    private void Golpe() 
    {
        animator.SetTrigger("Golpe");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, RadioDeGolpe);
        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Enemigo"))
            {
                colisionador.transform.GetComponent<Enemigo>().TomarDaño(DañoGolpe);
            }
        }
        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Jefe"))
            {
                colisionador.transform.GetComponent<Jefe>().TomarDaño(DañoGolpe);
            }
        }

    }

    //Se crea el radio del atque
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorGolpe.position, RadioDeGolpe);
        //Se crea el radio del atque, para un nuevo tipo de ataque  
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(controladorGolpe.position, RadioDeBarrido);
    }
    private void Barrido()
    {
        animator.SetTrigger("Barrido");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, RadioDeBarrido);
        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Enemigo"))
            {
                colisionador.transform.GetComponent<Enemigo>().TomarDaño(DañoBarrido);
            }
            if (colisionador.CompareTag("Jefe"))
            {
                colisionador.transform.GetComponent<Jefe>().TomarDaño(DañoBarrido);
            }
        }
    }
}
