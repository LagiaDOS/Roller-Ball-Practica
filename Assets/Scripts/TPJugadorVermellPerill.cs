using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPJugadorVermellPerill : MonoBehaviour
{

    public GameObject bola;
    public Transform b;
    public Rigidbody RBBola;

    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {}

    private void OnTriggerEnter(Collider Player)
    {

        Debug.Log("Teleportant fora del perill");
        b.position = new Vector3(0.02f, 1.5f, 13.54f);
        RBBola.velocity = new Vector3(0, 0, 0);

    }







}
