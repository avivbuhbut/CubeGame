using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetacheLid1 : MonoBehaviour
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
            this.gameObject.transform.parent = Basket1Trans.transform;

        }
    }


    void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        Debug.Log(gameObject.name);

    }
}

