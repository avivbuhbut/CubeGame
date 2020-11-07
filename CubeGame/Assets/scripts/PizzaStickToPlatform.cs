using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaStickToPlatform : MonoBehaviour
{

    public Camera box2Cam;

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

        if (collision.gameObject.tag == "FinishLineCube")
        {
            
            transform.parent = collision.transform;
            box2Cam.gameObject.SetActive(false);

        }


        if (collision.gameObject.tag == "TriggerCube")
        {
            Debug.Log("Cube touched pizza box");
            transform.parent = null;
        }



    }



    }
