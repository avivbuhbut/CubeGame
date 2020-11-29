using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHitPlayerBecomeChild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.gameObject.transform.GetComponent<Rigidbody>().isKinematic = false;
            this.transform.parent = null;
        }
    }



     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.transform.name == "Player")
        {
       

            this.gameObject.transform.parent = collision.transform;
  
            this.gameObject.transform.GetComponent<Rigidbody>().isKinematic = true;




        }
    }
}
