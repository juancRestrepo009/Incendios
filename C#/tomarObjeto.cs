		using System.Collections;
		using System.Collections.Generic;
		using UnityEngine;

		public class tomarObjeto : MonoBehaviour
		{
		    
		    public Rigidbody combustible;
		    public Transform objeto;
		    public Transform[] target;
		    public float speed;
		    public Transform padreObjetoTomado;	
		    public Transform padreObjetoDejado;		    
		    public bool tomadoDejado = false;

		    private int current;

		    void Start(){
		     tomadoDejado = false;
		    }   


		    void Update()
		    {
            if (Input.GetKeyDown(KeyCode.D)){
		        combustible.useGravity = true;	
		        tomadoDejado = false;	
		        tomarDejar(); 
		      }}

		    private void OnTriggerStay(Collider comb){
		    if(transform.position != target[current].position){
		    if (comb.gameObject.tag == "Player"){	

		    	if (Input.GetKeyDown(KeyCode.Space)){

		    
		         Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
		         combustible.GetComponent<Rigidbody>().MovePosition(pos);  
		          combustible.constraints = RigidbodyConstraints.FreezePosition;
		          combustible.constraints = RigidbodyConstraints.FreezeRotation;  
		          tomadoDejado = true;
		          tomarDejar();  

		                  
		         combustible.useGravity = false;	


		        }
                 }

		    }	    	
		          
		       
		     
		}

		    

		    public void tomarDejar(){
		    if(tomadoDejado == true){
		    objeto.SetParent(padreObjetoTomado);
		    }else {
		    objeto.SetParent(padreObjetoDejado);
		    		    } 

		   }

		  
		}
