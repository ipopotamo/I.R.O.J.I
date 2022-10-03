using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MostrarDashes : MonoBehaviour
{
    public TextMeshProUGUI textoMesh;
    public movimiento mov;
    public Vida vida;


    [SerializeField] private GameObject imagendash;
    [SerializeField] private GameObject textoDash;

    // Start is called before the first frame update
    void Start()
    {
        textoMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textoMesh.text = mov.cantDash.ToString("0");
        if (vida.vidaSlider.value==0) {
            imagendash.SetActive(false);
            textoDash.SetActive(false);
        }
    }
}
