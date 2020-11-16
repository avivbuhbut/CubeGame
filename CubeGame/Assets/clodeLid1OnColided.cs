using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clodeLid1OnColided : MonoBehaviour
{

    public Transform Basket1Trans;
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


        if (collision.gameObject.tag == "Basket1")
        {
            gameObject.transform.parent = Basket1Trans.transform;
            gameObject.transform.GetComponent<Rigidbody>().isKinematic = true;

        }
    }


     void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.parent = null;
        
            // this.gameObject.transform.GetComponent<Rigidbody>().isKinematic = false ;
        }
    }
}
