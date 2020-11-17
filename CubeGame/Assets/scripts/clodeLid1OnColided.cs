using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clodeLid1OnColided : MonoBehaviour
{

    public Transform PlayerMoneyBasket;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.parent = null;
       // gameObject.transform.GetComponent<Rigidbody>().detectCollisions = true;
    }

    // Update is called once per frame
    void Update()
    {
     
      //  gameObject.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
        //  gameObject.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        // gameObject.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
    }


     void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Basket1")
        {
            gameObject.transform.parent = PlayerMoneyBasket.transform;

           gameObject.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            

        }
    }


     void OnMouseOver()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            gameObject.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;



            gameObject.transform.parent = null;
        
            // this.gameObject.transform.GetComponent<Rigidbody>().isKinematic = false ;
        }
    }
}
