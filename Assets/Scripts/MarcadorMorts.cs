using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MarcadorMorts : MonoBehaviour
{

    private int contador;
    public Text contadorM;


    // Start is called before the first frame update
    void Start()
    {
        contador=0;
        mostrarContador();
    }

    void Update()
    { }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {            contador++; mostrarContador(); }

    }


    private void mostrarContador()
    {
        contadorM.text = "Morts actuals: " + contador;
    }


}
