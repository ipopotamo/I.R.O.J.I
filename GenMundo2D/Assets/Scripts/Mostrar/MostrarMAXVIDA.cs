using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MostrarMAXVIDA : MonoBehaviour
{
    public TextMeshProUGUI MaxVida;
    public Slider Vida;
    // Start is called before the first frame update
    void Start()
    {
        MaxVida = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        MaxVida.text = Vida.maxValue.ToString();
    }
}
