using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class MostrarVidaActual : MonoBehaviour
{
    public TextMeshProUGUI VidaActual;
    public Slider BarraVida;
    // Start is called before the first frame update
    void Start()
    {
        VidaActual = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        VidaActual.text = BarraVida.value.ToString();
    }
}
