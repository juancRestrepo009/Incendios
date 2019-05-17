using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzOn : MonoBehaviour
{
  
	public Light luzEscenario; 

    
    void Start(){    	
    	luzEscenario = luzEscenario.GetComponent<Light>();  	
    	luzEscenario.enabled = true;
}

   
 }
       
 