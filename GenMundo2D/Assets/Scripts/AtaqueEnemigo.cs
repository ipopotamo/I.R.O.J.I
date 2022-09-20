using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigo : MonoBehaviour
{
    [SerializeField] private GameObject ControlEnemigo;
    [SerializeField] private float daño;
    public float rango;
    private IA_Enemiga Enemigo;

    private void Update()
    {
        //Enemigo.RadioAtaque = rango;
       Ataque();
    }
     
     
     private void Ataque() 
    {
        Collider2D[] objetos = Physics2D.OverlapCircleAll(ControlEnemigo.transform.position,rango);
        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Juan"))
            {
                colisionador.transform.GetComponent<Vida>().TomarDaño(daño);
            }
        }
    }
     private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(ControlEnemigo.transform.position, rango);
    }
}
