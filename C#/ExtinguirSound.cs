using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguirSound : MonoBehaviour
{
   
    public AudioSource triggerSound;
    public AudioClip myClip;    
    
    private void Start()
    {
        AudioSource triggerSound = GetComponent<AudioSource>();
    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider score)
    {
        if (score.gameObject.tag == "gasExtintor")
        {
            triggerSound.PlayOneShot(myClip);    
            
        }
        
        
        

    }
}
