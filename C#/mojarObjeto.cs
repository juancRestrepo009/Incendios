using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mojarObjeto : MonoBehaviour
{
	public float tiempoMojado = 2f;
	public Material objetoMojado;
	public Material objetoSeco;
	public GameObject objeto;
	float elapsed;


	 void Start(){
    	objeto.GetComponent<MeshRenderer>().material = objetoSeco;   
    }
 
    void OnTriggerStay (Collider other){
        if(other.gameObject.tag == "gasExtintor")
        {

        elapsed += Time.fixedDeltaTime;
        	if(elapsed > tiempoMojado){        		
        	objeto.GetComponent<MeshRenderer>().material = objetoMojado;            
        }
         
       }
    }


}
