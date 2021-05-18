using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentPlataformaVertical : MonoBehaviour
{

    public bool oscilancio;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
      
        double moviment;

        //va cap a endevant
        if (oscilancio == false)
        {
            for (int i = 0; i < 100; i++)
            {
                //teleportar el objecte propi una mica (+0.1)


                //ja ha arribat al limit, parem de anar en aquesta direccio i pasem a retrocedir
                if (i == 100) { oscilancio = true; }
            }
        }

        //va cap a enredere
        if (oscilancio == true)
        {
            for (int i = 0; i < 100; i++)
            {
                //teleportar el objecte propi una mica (-0.1)


                //ja ha arribat al limit, parem de anar en aquesta direccio i pasem a retrocedir
                if (i == 100) { oscilancio = false; }
            }
        }






    }




}
