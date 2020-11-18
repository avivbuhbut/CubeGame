using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMoneyChild : MonoBehaviour
{

    public Transform PlayerMoneyBasketTrans;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.transform.name == "Money(Clone)")
        {
           other.gameObject.transform.parent = this.transform;
            //other.gameObject.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionX| RigidbodyConstraints.FreezePositionZ;
    

        }

    }

}