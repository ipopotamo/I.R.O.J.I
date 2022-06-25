using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateCuerpoaCuerpo : MonoBehaviour
{
    [SerializeField] private Transform controladorGolpe;
    [SerializeField] private float RadioDeGolpe;
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
    }
    private void Golpe() 
    {
        animator.SetTrigger("Golpe");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, RadioDeGolpe);
        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Enemigo"))
            {
                colisionador.transform.GetComponent<Enemigo>().TomarDaño(DañoBarrido);
            }
        }

    }

    //Se crea el radio del atque
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorGolpe.position, RadioDeGolpe);
    }
}
