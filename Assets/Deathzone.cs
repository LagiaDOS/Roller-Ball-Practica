using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    //la zona es quina deathzone es toca, i a on et teleporta
    public int zona;

    public GameObject jugador;
    public Transform j;

    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {}


    private void OnTriggerEnter(Collider Player)
    {
     


        switch (zona)
        {
            case 1:   // 1 - Base
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(0.0f, 0.0f, 0.0f);
                break;

            case 2:   // 2 - Laberint
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(0.0f, 0.0f, 0.0f);
                break;

            case 3:   // 3 - Plataformes
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(0.0f, 0.0f, 0.0f);
                break; 

            case 4:   // 4 - Zona perill
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(0.0f, 0.0f, 0.0f);
                break;

            case 5:   // 5 - HALLIGAN WHERE ARE MY SCISORS
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(0.0f, 0.0f, 0.0f);
                break;

            case 6:   // 6 - Debug fondo
                Debug.Log("Teleportant a zona: " + zona);
                j.position = new Vector3(0.0f, 0.0f, 0.0f);
                break;
      
            default:
                Debug.Log("Aixo no hauria de apareixer");
                break;
        }





     
        








    }








}
