using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EfectosCercanosAlJEFE : MonoBehaviour
{
    [SerializeField]private GameObject BarraVida;
    public int UnidadesAbajarParaQueAparezcaLaBarra = 20;

    private float tiempoEntreVeneno = 3f;
    private float TiempoSiguienteDano;
    // Start is called before the first frame update
    void Start()
    {
        BarraVida = GameObject.FindGameObjectWithTag("BarraVidaJEFE");
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
         if (collision.CompareTag("Juan"))
        {
            TiempoSiguienteDano -= Time.deltaTime;
            if (TiempoSiguienteDano <= 0)
            {
                collision.GetComponent<Vida>().TomarDaño(1); //Dano del veneno
                TiempoSiguienteDano = tiempoEntreVeneno;
            }
        }
    }
}
