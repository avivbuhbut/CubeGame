using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShifterKinematic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "CubeShifter")
        {
            collision.transform.GetComponent<Rigidbody>().isKinematic = true;
        }
    }


     void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "CubeShifter")
        {
            collision.transform.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
