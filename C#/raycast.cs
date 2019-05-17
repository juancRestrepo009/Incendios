using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
	public float range= 100f;
	public Camera fpsCam;    
		
    void Update(){
    Halo();   
    
    }

    void Halo(){
    	RaycastHit hit;
     
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {
            //Debug.Log(hit.transform.tag);
            
            tomarObjeto target = hit.transform.GetComponent<tomarObjeto>();           
        

            if (target.tag != null){
            	target.GetComponent<Light>().enabled = false; 
             
            }
            if (target.tag == "Objeto"){

             target.GetComponent<Light>().enabled = true; 

            }
            
    }
}
}


