using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ControlOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private GameObject MenuPrincipal;
    [SerializeField] private GameObject MenuOpciones;

    public void PantallaCompleta (bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }
    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }
    public void volverAlMenu()
    {
        MenuPrincipal.SetActive(true);
        MenuOpciones.SetActive(false);

    }
    public void IrOpciones()
    {
        MenuPrincipal.SetActive(false);
        MenuOpciones.SetActive(true);

    }
}
