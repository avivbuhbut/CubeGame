using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMoneyKinematic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(ColidedScript.counter == 3)
            this.transform.GetComponent<Rigidbody>().isKinematic = false;


    }



}
