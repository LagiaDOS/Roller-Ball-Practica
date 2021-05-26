using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentBala : MonoBehaviour
{


    public Vector3 movement;
    public float speed = 2.0f;

    public int angleX;
    public int angleY;
    public int angleZ;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(angleX, angleY, angleZ);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(movement * Time.deltaTime * speed);
    }
}
