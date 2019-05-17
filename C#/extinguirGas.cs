using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extinguirGas : MonoBehaviour
{
	
    void OnTriggerEnter (Collider other)
    {
        //Debug.Log (other);
        if(other.gameObject.tag == "gasExtintor")
        {
            Destroy(other.gameObject);

        }
    }
}
