using UnityEngine;
using System.Collections;

public class movPlayer : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    
    
    void Update ()
    {
    	//Arriba
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        //Abajo
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        //Izquierda
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        //Derecha
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}