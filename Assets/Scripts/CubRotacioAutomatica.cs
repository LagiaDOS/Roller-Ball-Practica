using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubRotacioAutomatica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 46) * Time.deltaTime);
    }
	
	
	
	private void OnTriggerEnter (Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
       {
            //other.gameObject.SetActive(false); 
	    	//contador++;
	    	//mostrarContador();	
	   }
    }
		
	

	
	
	
	
}
