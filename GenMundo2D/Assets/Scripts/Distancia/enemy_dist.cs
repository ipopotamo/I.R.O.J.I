using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_dist : MonoBehaviour
{
    [SerializeField] private float RangoDeTiro;
    [SerializeField] private float LineaDeVision;
    public GameObject municionMadre;
    public GameObject municion;

    public float TiempoEntreDisparo = 1f;
    private float SiguienteDisparo;


    public float velo;
    private Transform juan;

    void Start()
    {
        juan = GameObject.FindWithTag("Juan").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanciaAlJugador = Vector2.Distance(juan.position, transform.position);
        if (distanciaAlJugador < LineaDeVision && distanciaAlJugador > RangoDeTiro)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, juan.position, velo * Time.deltaTime);
        }
        else if (distanciaAlJugador <= RangoDeTiro && SiguienteDisparo < Time.time)
        {
            Instantiate(municion, municionMadre.transform.position, Quaternion.identity);

            SiguienteDisparo = Time.time + TiempoEntreDisparo;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.transform.position, RangoDeTiro);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, LineaDeVision);
    }
}
