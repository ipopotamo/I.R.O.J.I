using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jefe : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private Transform VistadeGoyo;
    [SerializeField] private float RadiodeVista;
    [SerializeField] private GameObject Barravidaj;
    public Slider vidaSlider;
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
