using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaControlador : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    private bool juegopausado = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegopausado)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }
    }
    //Menu de Pausa
    public void Pausa()
    {
        juegopausado = true;
        Debug.Log("Pausado");
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void Reanudar()
    {
        juegopausado = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Reiniciar()
    {
        juegopausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        menuPausa.SetActive(false);
    }
    public void Salir_al_Menu()
    {
        SceneManager.LoadScene("MainMenu");
        menuPausa.SetActive(false);
    }
    public void Cerrar_juego()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
