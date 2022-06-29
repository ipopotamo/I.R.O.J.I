using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(1,1,0));
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(1, 0, 0));
            //print("Adelante");
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(-1, 0, 0));
            //print("Atras");
        }
    }
}