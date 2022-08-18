using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarALista : MonoBehaviour
{
    private RoomTemplates templates; // Esto agrega las salas a la lista generada en "RoomTemplates", si sacamos esto no funca el jefe, agregar a futuras salas.
    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        templates.rooms.Add(this.gameObject); //cabe destacar que las salas que ponemos manualmente no cuentan o se agregan automaticamente a la lista
    }
}
