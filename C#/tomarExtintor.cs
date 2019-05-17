using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomarExtintor : MonoBehaviour
{
    public GameObject extintorPared;
    public GameObject extintorMano;

  void Start(){
  	extintorPared.SetActive(true);
  }

       private void OnTriggerStay(Collider other){		    
		    if (other.gameObject.tag == "Player"){
		    	if (Input.GetKeyDown(KeyCode.Space)){

          extintorPared.SetActive(false);
          extintorMano.SetActive(true);

}
		    	}}
}
