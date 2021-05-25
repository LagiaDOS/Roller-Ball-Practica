using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFijaCanvi : MonoBehaviour
{
    public int numcamera;

    public Camera MainCamera;
    public Camera CameraFija;

    public Transform c;

    public Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
     //   MainCamera.enabled = true;
        CameraFija.enabled = false;
        rend = GetComponent<Renderer>();
        rend.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider Player)
    {
        // cada numero es l'angle que correspon, fer el canvi de les cordenades de la CameraFija


        switch (numcamera)
        {
            case 0:// pasar a camera normal
                MainCamera.enabled = true;
                CameraFija.enabled = false;
                Debug.Log("Contador mes gran que 7, es a dir: ");
                break;
            case 1:
                MainCamera.enabled = false;
                CameraFija.enabled = true;
                c.position = new Vector3(23.93f, 0.94f, 0.0f);
                // c.transform.Rotate(0.0f, 90.0f, 0.0f);

                break;
            case 2:
                c.position = new Vector3(26.18f, 0.94f, -5.59f);
                c.transform.Rotate(0.0f, 90.0f, 0.0f);

                break;
            case 3:
                c.position = new Vector3(25.49f, 0.94f, 5.6f);
                c.transform.Rotate(0.0f, 90.0f, 0.0f);

                break;
            case 4:
                c.position = new Vector3(30.63f, 0.94f, 7.03f);
                c.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);

                break;
            case 5:
                c.position = new Vector3(31.78f, 0.94f, 8.79f);
                c.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);

                break;
            case 6:
                c.position = new Vector3(28.78f, 0.94f, -2.9f);
                c.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);

                break;
            case 7:
                c.position = new Vector3(33.23f, 0.94f, -3.85f);
                c.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);

                break;
            case 8:
                c.position = new Vector3(38.81f, 0.94f, 7.65f);
                c.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);

                break;
            case 9:
                c.position = new Vector3(36.28f, 0.78f, 4.05f);
                c.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);

                break;
            case 10:
                c.position = new Vector3(34.72f, 0.78f, -2.66f);
                c.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);

                break;
            case 11:
                c.position = new Vector3(38.4f, 0.78f, -3.26f);
                c.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);

                break;
            default:
                c.position = new Vector3(23.93f, 0.94f, 0.0f);

                break;
        }


    }






}
