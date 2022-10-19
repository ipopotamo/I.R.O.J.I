using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    [SerializeField] private GameObject Barravida; //Estas 3 variables se asignan un objeto dentro del juego
    [SerializeField] private GameObject BarravidaJefe;
    [SerializeField] private GameObject moriste;
    [SerializeField] private GameObject jUAN;
    private RoomTemplates templates;
    public Defensa defensa;
    public float vida; // Valor de la vida de JUAN  
    public Slider vidaSlider; //vida de juan pero en barra
    


    private void Start()
    {
        vida = vidaSlider.value; // refleja el valor de la vida en su respectiva barra 
        Time.timeScale = 1f; //reanuda el tiempo despues de muertos o al aparecer
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
    }
    private void Update() 
    {
        if (vidaSlider.value == 0) //Pregunta si la vida de juan es == 0
        {
            Time.timeScale = 0f; //se frena el tiempo
            jUAN.SetActive(false);// se destruye el cuerpo de Juan
            Barravida.SetActive(false); //Desactiva la barra para que no sea visible 
            moriste.SetActive(true); //Activa el cartel de Moriste con los botones para de volver, revivir, etc
            BarravidaJefe.SetActive(false); // se borra la barra del Jefe
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fuego")
        {
            vidaSlider.value -= templates.Dañofuego; // El fuego hace da�o
             
        }

        if (collision.gameObject.tag == "Yerba")
        {
            vidaSlider.maxValue += templates.AumentoYerba;
            Destroy(collision.gameObject);
            if (vidaSlider.value < vidaSlider.maxValue) {
                vidaSlider.value = vidaSlider.maxValue;
            }
        }

        if (collision.gameObject.tag == "VistaJefe")
        {
            BarravidaJefe.SetActive(true); //Esto aun no funciona pero deberia activar la barra de vida del Jefe al entrar en la sala
        }
        if (collision.gameObject.tag == "Mas_Vida")
        {
            vidaSlider.value += templates.RecuperaHP; // Recupera vida con la milanga, 
            Destroy(collision.gameObject);
        }     
    }
    public void TomarDaño(float daño) //Cuando le pegan a Juan El recibe da�o
    {
        float loquebajan = (daño - defensa.reduccionDañoXDefensa);
        vidaSlider.value -= loquebajan;
        if (vidaSlider.value <= 0)
        {
            Time.timeScale = 0f;
            jUAN.SetActive(false);
            Barravida.SetActive(false);
            moriste.SetActive(true);
            BarravidaJefe.SetActive(false);
        }
    }
}
