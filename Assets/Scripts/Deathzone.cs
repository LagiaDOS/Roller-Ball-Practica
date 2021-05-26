using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    //la zona es quina deathzone es toca, i a on et teleporta
    public int zona;
    public Rigidbody RBBola;
    public GameObject jugador;
    public Transform j;

    public int contadormorts;

    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {}


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        { 

        switch (zona)
        {
            case 1:   // 1 - Base
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(1.75f, 1.5f, 2.74f);
                break;

            case 2:   // 2 - Laberint
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(20.48f, 1.5f, 0.28f);
                break;

            case 3:   // 3 - Plataformes
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(-13.74f, 1.5f, 0.02f);
                break;

            case 4:   // 4 - Zona perill
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(0.02f, 1.5f, 13.54f);
                break;

            case 5:   // 5 - HALLIGAN WHERE ARE MY SCISORS
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(-0.03f, 1.5f, -6.98f);
                break;

            case 6:   // 6 - Debug fondo
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(1.75f, 1.5f, 2.74f);
                break;

            default:
                Debug.Log("Aixo no hauria de apareixer");
                break;
        }

        RBBola.velocity = new Vector3(0, 0, 0);

        }











    }








}
