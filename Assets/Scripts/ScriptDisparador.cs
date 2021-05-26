using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDisparador : MonoBehaviour
{
    public GameObject projectil;
    public float duracioP;
    public int delayP;
    private int crono = 0;
    
    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {

        //cada tans segons com delayP
        crono++;

        if (crono > delayP) { 

        GameObject TProjectil = Instantiate(projectil, transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        Rigidbody TRProjectil = TProjectil.GetComponent<Rigidbody>();

        Destroy(TRProjectil, duracioP);
        Destroy(TProjectil, duracioP);

        crono = 0;
        }

    }
}
