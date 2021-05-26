using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentPlataforma : MonoBehaviour
{
    public Vector3 movement;
    public float speed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
       // plataforma = GetComponent<Transform>();
       //if (oscilancio == true) { moviment = -moviment; }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //I dont know why but (in FixedUpdate) works
        this.transform.Translate(movement * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "parada")
       {
            movement = -movement;
            Debug.Log("Moviment invertit");
        }
        Debug.Log("Ccollider other");
    }





}
