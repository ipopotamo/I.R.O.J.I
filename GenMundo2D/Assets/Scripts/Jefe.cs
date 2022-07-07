using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jefe : MonoBehaviour
{
    //parte de la vida 
    [SerializeField] private float vida;
    [SerializeField] public float daño;
    [SerializeField] private Transform VistadeGoyo;
    [SerializeField] private float RadiodeVista;
    [SerializeField] private GameObject Barravidaj;
    public Slider vidaSlider;

    //Movimiento en la habitacion
    private Rigidbody2D jEFE;
    public int rutina;
    public float cronometro;
    public Animator ani;
    public int direccion;
    public float velocidad_corrida;
    public float velocidad_caminada;
    public GameObject objetivo;
    public bool atacando;

    //Ataque y detectar jugador
    public float rango_vision;
    public float rango_ataque;
    public GameObject rango;
    public GameObject Hit;

    private void Start()
    {
        jEFE = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        objetivo = GameObject.Find("Juan");
    }
    public void Update()
    {
        Comportamiento();
    }

    public void Comportamiento()
    {
        if (Mathf.Abs(transform.position.x - objetivo.transform.position.x) > rango_vision && !atacando)
        {
            ani.SetBool("correr", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }

            switch (rutina)
            {
                case 0:
                    ani.SetBool("caminar", false);
                    break;

                case 1:
                    direccion = Random.Range(0, 2);
                    rutina++;
                    break;

                case 2:
                    switch (direccion)
                    {
                        case 0:
                            transform.rotation = Quaternion.Euler(0, 0, 0);
                            transform.Translate(Vector3.right * velocidad_caminada * Time.deltaTime);
                            break;
                        case 1:
                            transform.rotation = Quaternion.Euler(0, 180, 0);
                            transform.Translate(Vector3.right * velocidad_caminada * Time.deltaTime);
                            break;
                    }
                    ani.SetBool("caminar", true);
                    break;
            }
        }
        else
        {
            if (Mathf.Abs(transform.position.x - objetivo.transform.position.x) > rango_ataque && !atacando)
            {
                if (transform.position.x < objetivo.transform.position.x)
                {
                    ani.SetBool("caminar", false);
                    ani.SetBool("correr", true);
                    transform.Translate(Vector3.right * velocidad_corrida * Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    ani.SetBool("ataque 1", false);
                }
                else
                {
                    ani.SetBool("caminar", false);
                    ani.SetBool("correr", true);
                    transform.Translate(Vector3.right * velocidad_corrida * Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                    ani.SetBool("ataque 1", false);
                }
            }
            else 
            {
                if (!atacando)
                {
                    if (transform.position.x < objetivo.transform.position.x)
                    {
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(0, 180, 0);
                    }
                    ani.SetBool("caminar", false);
                    ani.SetBool("correr", false); //4'18"
                }
            }
        }
    }

    public void Final_ani()
    {
        ani.SetBool("ataque 1", false);
        atacando = false;
        rango.GetComponent<BoxCollider2D>().enabled = true;

    }

    public void ColliderWeaponTrue()
    {
        Hit.GetComponent<BoxCollider2D>().enabled = true;    
    }

    public void ColliderWeaponFalse()
    {
        Hit.GetComponent<BoxCollider2D>().enabled = false;
    }

    //Cuando juan le pega pierde vida y lo refleja en la barra 
    public void TomarDaño(float daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            Destroy(gameObject);
            Barravidaj.SetActive(false);
        }
        vidaSlider.value = vida;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(VistadeGoyo.position, RadiodeVista);
    }
}
