using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleportnivell2 : MonoBehaviour
{

    public int nivell;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Player)
    {


        switch (nivell)
        {
            case 1:   // 1 - Base
                Debug.Log("Teleportant a zona: ");
                break;
            default: break;

            case 2: // a nivel 2
                SceneManager.LoadScene("Mapa 2"); break;

            case 3: // a nivell final
                SceneManager.LoadScene("Mapa Final"); break;
        }

                


        

    }





}
