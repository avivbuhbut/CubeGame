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
        if(CubeShifterScrpt.hit.transform!=null)
        Debug.Log(CubeShifterScrpt.hit.transform.name);

        if (Input.GetKeyDown(KeyCode.L) && CubeShifterScrpt.hit.transform.name == this.transform.name)
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
