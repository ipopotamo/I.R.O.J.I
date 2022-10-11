using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoaDISTANCIA : MonoBehaviour
{

    [SerializeField] public float RadioAtaque;

    [SerializeField] GameObject RangoAtaque;

    private float TiempoEspera; // Cuanto tiempo hay entre disparos
    public float TiempoEsperaEntreAtaque; // cada x segundos dispara

    [SerializeField] public GameObject bolaDeFuego;
    [SerializeField] public Transform puntoDeLanzamiento;

    //public Animator animator;

    private void Start()
    {
        TiempoEspera = TiempoEsperaEntreAtaque;
    }

    private void Update()
    {
        if (TiempoEspera<=0) 
        {
            TiempoEspera = TiempoEsperaEntreAtaque;
            //Animator.Play("Ataque");
            Invoke("Lanzar", 0.5f);
        }
        else 
        {
            TiempoEspera -= Time.deltaTime;  
        }
    }


    public void Lanzar()
    {
        GameObject newBala;

        newBala = Instantiate(bolaDeFuego, puntoDeLanzamiento.position, puntoDeLanzamiento.rotation);

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(RangoAtaque.transform.position, RadioAtaque);
    }
}
