using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbyBall : MonoBehaviour
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
        if(collision.transform.name == "DestructionBall")
        {
            this.transform.GetComponent<Rigidbody>().isKinematic = false;
            this.transform.GetComponent<Rigidbody>().useGravity = true;
 this.transform.GetComponent<Rigidbody>().AddForce(new Vector3(0,-this.transform.position.y*0.4f, 0));
        }
    }
}
