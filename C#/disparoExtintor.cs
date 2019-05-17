using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class disparoExtintor : MonoBehaviour
{
    
 //    public Rigidbody combustible;
	// public Transform objeto;
	// public Transform[] target;
	// public float speed;
	// public Transform padreObjetoTomado;	
	// public Transform padreObjetoDejado;		    
	// public bool tomadoDejado = false;

	// private int current;    

    public float velMovUD = 50f;
    public float velMovRL = 50f;
    public float velAnguloUD = 50f;
    public float velAnguloRL = 50f;  
      
    public Rigidbody bala;
    public Transform lanzador;
    public float VelDisparo;
    public float tiempoDisparo;
    private float inicioDisparar;
    public AudioSource sonidoExtintor;
    public AudioClip myClip;    
        
    public string portName;
    //SerialPort puerto = new SerialPort("/dev/cu.usbmodem1411", 9600);
    SerialPort puerto = new SerialPort("COM4", 9600);
    // Start is called before the first frame update

    

    void Start()
    {    
        puerto.Open();
        puerto.ReadTimeout = 2000;
        AudioSource sonidoExtintor = GetComponent<AudioSource>();
        sonidoExtintor.Stop();
        //tomadoDejado = false;

       }

    // Update is called once per frame
    void Update()
    {
        
        if (puerto.IsOpen)
        {
            try
            {
                anguloCamara(puerto.ReadByte());
                shoot(puerto.ReadByte());
                //tomarO(puerto.ReadByte());

                
            }
            catch (System.Exception)
            {

            }
        }

        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * velMovUD * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * velMovUD * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -velMovRL * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, velMovRL * Time.deltaTime);
   } 
       
     void shoot(int direccion)
    {
        if (direccion == 1 && Time.time > inicioDisparar)
        {
         	sonidoExtintor.PlayOneShot(myClip);   
            inicioDisparar = Time.time + tiempoDisparo;
            Rigidbody balaInstanc;

            balaInstanc = Instantiate(bala, lanzador.position, Quaternion.identity);
            balaInstanc.AddForce(lanzador.forward * 100 * VelDisparo);
         

        } else {
        	sonidoExtintor.Stop();
        }
     
    }

    void anguloCamara(int direccion)
    {
       //Abajo
        if (direccion == 2){
            transform.Rotate(-Vector3.right * velAnguloUD * Time.deltaTime);
        }
        //Arriba
       if (direccion == 3){
            transform.Rotate(Vector3.right * velAnguloUD * Time.deltaTime);
        }
         //Derecha
        if (direccion == 4){
            transform.Rotate(Vector3.up, velAnguloRL * Time.deltaTime);
        }
        //Izquierda
        if (direccion == 5){
            transform.Rotate(Vector3.up, -velAnguloRL * Time.deltaTime);
        }
       
    }

  //   void tomarO(int direccion){
  //   	if (direccion == 6){
  //           if (comb.gameObject.tag == "Objeto"){	

		    	

		//     if(transform.position != target[current].position){
		//          Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
		//           objeto.GetComponent<Rigidbody>().MovePosition(pos);  
		//           combustible.constraints = RigidbodyConstraints.FreezePosition;
		//           combustible.constraints = RigidbodyConstraints.FreezeRotation;  
		//           tomadoDejado = true;
		//           tomarDejar();  

		                  
		//          combustible.useGravity = false;	


		//         }
                 

		    	    	
		//      }  
  //       }
  //   }

  //    private void OnTriggerStay(Collider comb){		
  //    tomarO();    
		       
		       
		     
		// }

  //   public void tomarDejar(){
		//     if(tomadoDejado == true){
		//     objeto.SetParent(padreObjetoTomado);
		//     }else {
		//     objeto.SetParent(padreObjetoDejado);
		//     		    } 

		//    }
     

    

   
   
}