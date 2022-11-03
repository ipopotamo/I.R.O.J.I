using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    [SerializeField] private GameObject Mdialogo;
    [SerializeField] private GameObject Pdialogo;
    [SerializeField] public  TMP_Text   Tdialogo;
    [SerializeField, TextArea(4,6)] private string[] lineaD; 

    private float TiempD = 0.05f;
    private bool rang;
    private bool iniDialog;
    private int  lineadiag;


    void Update()
    {
        if(rang && Input.GetButtonDown("Fire1")){
          if(!iniDialog)
          {
            StarDialogue();
          }
          else if(Tdialogo.text == lineaD[lineadiag]){
            nuevoDialog();
          }
            
        }
    }


    private void StarDialogue(){
        iniDialog = true;
        Pdialogo.SetActive(true);
        Mdialogo.SetActive(false);
        lineadiag = 0;
        StartCoroutine(ShowLine());
    }

    private void nuevoDialog(){
        lineadiag++;
        if(lineadiag < lineaD.Length){
            StartCoroutine(ShowLine());
        }
        else{
            iniDialog = false;
            Pdialogo.SetActive(false);
            Mdialogo.SetActive(true);
        }
    }

    private IEnumerator ShowLine(){
        Tdialogo.text = string.Empty;

        foreach(char ch in lineaD[lineadiag]){
            Tdialogo.text += ch;
            yield return new WaitForSeconds(TiempD);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.gameObject.CompareTag("Juan"))
        {
            Mdialogo.SetActive(true);
            rang = true;
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
         if(collision.gameObject.CompareTag("Juan"))
        {
            Mdialogo.SetActive(false);
            rang = false;
        }
    }
}
