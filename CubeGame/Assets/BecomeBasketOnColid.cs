using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeBasketOnColid : MonoBehaviour
{

    public Transform Basket1GObject;
    public Transform Basket2GObject;

    public Camera PlayerCamera;
    // Start is called before the first frame update
    void Start()
    {
        Basket1GObject.transform.GetComponent<PlayerMovment>().enabled = false;
        Basket2GObject.transform.GetComponent<PlayerMovment>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.tag == "Basket1")
        {
            this.gameObject.transform.GetComponent<PlayerMovment>().enabled = false;
            Basket1GObject.transform.GetComponent<PlayerMovment>().enabled = true;
   

            PlayerCamera.GetComponent<FollowCamera2Script>().target = Basket1GObject.transform;

        }

        if(collision.gameObject.transform.tag == "Basket2")
        {
            this.gameObject.transform.GetComponent<PlayerMovment>().enabled = false;
            Basket2GObject.transform.GetComponent<PlayerMovment>().enabled = true;
            PlayerCamera.GetComponent<FollowCamera2Script>().target = Basket2GObject.transform;
        }

    }
}
