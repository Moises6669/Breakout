using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic : MonoBehaviour
{


    // Start is called before the first frame update
    //El metodo start es un metodo que se ejecuta autmaticamente 
    /*cuando inicia nuestro juego 
      asi que cualquier codigo que metamos dentro del metodo se iniciara 
      cuando el juego inicie.
    */
    void Start()
    {   
        // transform.position += new Vector3(3, 0, 0);  
    }

    // Update is called once per frame
    /* Este metodo se ejecuta por cada frame del juego
      este se ejecuta despues de start haya compilado todo el juego
    */
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position  += Vector3.right * Time.deltaTime;
        }
    }
}
