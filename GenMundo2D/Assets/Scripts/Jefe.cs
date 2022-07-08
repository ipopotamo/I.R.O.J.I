using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jefe : MonoBehaviour
{
    //parte de la vida 
    [SerializeField] private float vida;
    [SerializeField] public float da�o;
    [SerializeField] private Transform VistadeGoyo;
    [SerializeField] private float RadiodeVista;
    [SerializeField] private GameObject Barravidaj;
    public Slider vidaSlider;

    //Cuando juan le pega pierde vida y lo refleja en la barra 
    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
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
