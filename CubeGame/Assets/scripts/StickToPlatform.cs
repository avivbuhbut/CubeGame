using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToPlatform : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
            transform.parent = null;
    


    }



    void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject.tag == "ConveyorBelt")
        {
            Debug.Log("On ConveyorBelt!");
            transform.parent = collision.transform;

        }
    }

    /*
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "ConveyorBelt")
        {
            Debug.Log("Exit ConveyorBelt!");
            transform.parent = null;

        }
    }*/
}
