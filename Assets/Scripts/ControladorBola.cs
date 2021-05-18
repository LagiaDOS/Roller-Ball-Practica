using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorBola : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int contador;
	public Text marcador;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		contador= 0;
	    mostrarMarcador();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentH = Input.GetAxis("Horizontal");
        float movimentV = Input.GetAxis("Vertical");

        Vector3 moviment = new Vector3(movimentH, 0.0f, movimentV);
        rb.AddForce(moviment * speed);
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("enemic"))
        {
            other.gameObject.SetActive(false);
			contador++;
			mostrarMarcador();
		}

        //quant el contador sigui mes de 8, moure el teleport al centre del nivell
        if (contador>8) { }

    }


	private void mostrarMarcador()
	{
		marcador.text = "Marcador: " + contador;
	}

}