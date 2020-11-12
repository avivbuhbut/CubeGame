using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMouseCursor : MonoBehaviour
{

    public Rigidbody m1911RidgBody;
    // Start is called before the first frame update
    void Start()
    {
       
        this.gameObject.GetComponent<MouseCursor>().enabled = false;
        //crosshair = null;
    }

    // Update is called once per frame
    void Update()
    {
      //  if (Input.GetKey(KeyCode.Q))
      //  {
            //Debug.Log("123");
           // this.gameObject.GetComponent<MouseCursor>().enabled = false;
            //crosshair = null;
       // }

    }

     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player" )
        {
            // this.m1911RidgBody.constraints = RigidbodyConstraints.None;
          //  m1911RidgBody.isKinematic = true;
            this.gameObject.GetComponent<MouseCursor>().enabled = true;
            this.gameObject.GetComponent<MouseCursor>().ActiveCrossHair();


        }

    }
}
