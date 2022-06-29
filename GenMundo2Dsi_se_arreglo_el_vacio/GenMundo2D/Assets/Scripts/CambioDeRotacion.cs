using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeRotacion : MonoBehaviour
{
    private Vector3 objetivo;


    //[SerializeField] private Disparar ProyectilPrefab;
    //[SerializeField] private Transform PosiciondeDisparo;
    [SerializeField] private Camera Camera;

    private void Update()
    {
        objetivo = Camera.ScreenToWorldPoint(Input.mousePosition);

        float anguloRadianes = Mathf.Atan2(objetivo.y - transform.position.y, objetivo.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);

        //if (Input.GetMouseButtonDown(0))
        //{
         //  Disparar dispararpez= Instantiate(ProyectilPrefab, PosiciondeDisparo.position, transform.rotation);
           // dispararpez.DispararDisparo(transform.up);
        //}
    }
}
