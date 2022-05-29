using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{

    public void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");
        //SceneManager.GetActiveScene().buildIndex + 1
    }
    public void Salir()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
