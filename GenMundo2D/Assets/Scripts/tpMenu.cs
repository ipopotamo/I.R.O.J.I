using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tpMenu : MonoBehaviour
{
    [SerializeField] private GameObject portal;
    

    
    public void Start()
    {
        //DontDestroyOnLoad(gameObject);
    }
    public void Update(){
       if(!GameObject.FindWithTag("EnemigoDistancia")){
            
              portal.SetActive(true); 
       }

    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(!GameObject.FindWithTag("EnemigoDistancia")){
              
              portal.SetActive(true); 
        
           if(collision.gameObject.CompareTag("Juan") )
           {
            SceneManager.LoadScene("MainMenu");
           }
       
        }
        
    }

}
