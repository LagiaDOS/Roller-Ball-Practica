using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentPlataformaHoritzontal : MonoBehaviour
{
    public bool oscilancio;
    public Transform plataforma;
    public float moviment;
    // Start is called before the first frame update
    void Start()
    {
        plataforma = GetComponent<Transform>();
        //if (oscilancio == true) { moviment = -moviment; }
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.z>-32 || this.transform.position.z<-42) { moviment = -moviment; }

        this.transform.Translate(new Vector3(0.0f, 0.0f, moviment));


        /*
        //va cap a endevant
        if (oscilancio == false)
        {
            for (int i = 0; i < 50; i++)
            {
                //teleportar el objecte propi una mica (+0.1)

                this.transform.Translate(new Vector3(0.0f, 0.0f, moviment));


              //  plataforma.position = new Vector3(23.93f, moviment, 0.0f);

                //ja ha arribat al limit, parem de anar en aquesta direccio i pasem a retrocedir
                if (i == 100){oscilancio = true; Debug.Log("oscilacio true"); }
            }
        }

        //va cap a enredere
        if (oscilancio == true)
        {
            for (int i = 0; i < 100; i++)
            {
                //teleportar el objecte propi una mica (-0.1)
                plataforma.position = new Vector3(0, 0f, 0f);

                //ja ha arribat al limit, parem de anar en aquesta direccio i pasem a retrocedir
                if (i == 100){oscilancio = false;}
            }
        }

        */





    }





}
