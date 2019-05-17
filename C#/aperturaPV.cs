using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aperturaPV : MonoBehaviour
{
    public float tiempoApertura = 1f;
	public GameObject venPue;
	public Light HalovenPue; 
	float elapsed;
    
    void Start(){
    	venPue.gameObject.GetComponent<Animator>().enabled = false;
    	HalovenPue = HalovenPue.GetComponent<Light>();
    	HalovenPue.enabled = false;
    	
    }

    void OnTriggerStay (Collider other){        
       
        	if(other.gameObject.tag == "Player"){
            HalovenPue.enabled = true;
        	elapsed += Time.fixedDeltaTime;
        	if(elapsed > tiempoApertura){
        		if (Input.GetKeyDown(KeyCode.Space)){
        	venPue.gameObject.GetComponent<Animator>().enabled = true;
        	HalovenPue.enabled = false;
            }
        }

        }

        
    
    }


    void OnTriggerExit (Collider other){
        
        if(other.gameObject.tag == "Player")
        {
        	elapsed = 0;
        	HalovenPue.enabled = false;
        }

        }
}