using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPlayerRadiusRigBodyOn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Player" && Input.GetKey(KeyCode.O))
        {
            this.transform.GetComponent<Rigidbody>().useGravity = true;
        }

        if(other.transform.tag == "Floor")
            this.transform.GetComponent<Rigidbody>().isKinematic = true;

    }


    void OnTriggerExit(Collider other)
    {
        //this.transform.GetComponent<Rigidbody>().useGravity = false;
    }


}
