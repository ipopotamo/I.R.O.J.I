using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARCADEPausaControl : MonoBehaviour
{
    [SerializeField] private GameObject menuPausa;
    private bool juegopausado = false;


    private EstadisticasJuanGuardadas EstadisticasLevelAnterior;
    private void Start()
    {
        EstadisticasLevelAnterior = GameObject.FindGameObjectWithTag("STATS").GetComponent<EstadisticasJuanGuardadas>();
    }
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
        //  botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void Reanudar()
    {
        juegopausado = false;
        Time.timeScale = 1f;
        //botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Reiniciar()
    {
        juegopausado = false;
        Destroy(EstadisticasLevelAnterior.gameObject);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Arcade");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        menuPausa.SetActive(false);
    }
}
