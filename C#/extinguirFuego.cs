using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extinguirFuego : MonoBehaviour
{
	public float tiempoApagado = 3f;
	public GameObject fuego;
	float elapsed;
    
    void Start(){
    	fuego.gameObject.GetComponent<Animator>().enabled = false;
    }

    void OnTriggerStay (Collider other){
        
        if(other.gameObject.tag == "gasExtintor")
        {
        	elapsed += Time.fixedDeltaTime;
        	if(elapsed > tiempoApagado){
        	fuego.gameObject.GetComponent<Animator>().enabled = true;
            Destroy(fuego, 6);
        }

        }
    }


    void OnTriggerExit (Collider other){
        
        if(other.gameObject.tag == "gasExtintor")
        {
        	elapsed = 0;
        }

        }
}

