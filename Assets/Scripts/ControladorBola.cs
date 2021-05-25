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
    public float velSalt;

    public GameObject teleport;
    public Transform t;
    public Renderer rend;

    public int direccio;

    // Start is called before the first frame update
    void Start()
    { 
        rb = GetComponent<Rigidbody>();
      //  rend = GetComponent<Renderer>();
        contador = 0;
        rend.enabled = false;

        mostrarMarcador();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentH = Input.GetAxis("Horizontal");
        float movimentV = Input.GetAxis("Vertical");

        Vector3 moviment = new Vector3();

        switch (direccio)
            {
            case 0:
            // camera normal, camera esquerra, 0
            moviment = new Vector3(movimentH, 0.0f, movimentV); break;

            case 1:
            // camera adalt, horitzontal es vertical, 1
            moviment = new Vector3(movimentV, 0.0f, -movimentH); break;

            case 2:
            // camera dreta, 2
            moviment = new Vector3(-movimentH, 0.0f, -movimentV); break;
            }


        rb.AddForce(moviment * speed);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.01f)
        {rb.AddForce(Vector3.up * velSalt, ForceMode.Impulse);}



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
        if (contador>7)
        {
            Debug.Log("Contador mes gran que 7, es a dir: " + contador);
            rend.enabled = true;
            t.position = new Vector3(0.0f, 0.0f, 0.0f);
           
        }

        //camera normal, camera esquerra
        if (other.gameObject.CompareTag("CEsquerra"))
        {direccio = 0;}

        // camera adalt, horitzontal es vertical, 1
        if (other.gameObject.CompareTag("CAdalt"))
        {direccio = 1;}

        // camera dreta, 2
        if (other.gameObject.CompareTag("CDreta"))
        {direccio = 2;}


    }





    private void mostrarMarcador()
	{
		marcador.text = "Marcador: " + contador;
	}

}