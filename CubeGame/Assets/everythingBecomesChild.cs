using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class everythingBecomesChild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(becomeCubeShifter.CubeSHifterIsNowPlayer == false)
        {
            GameObject.Find("Player").transform.parent = null;
            GameObject.Find("Player").transform.GetComponent<Rigidbody>().isKinematic = false;

            if (CreatePizza.counterPizzaGen ==1 && GameObject.FindWithTag("PizzaBox").transform.gameObject != null)
            {
                GameObject.FindWithTag("PizzaBox").transform.parent = null;
                GameObject.Find("PizzaBox").transform.GetComponent<Rigidbody>().isKinematic = false;
            }
        }*/
    }

     void OnCollisionEnter(Collision collision)
    {
       // if (becomeCubeShifter.CubeSHifterIsNowPlayer)
     //   {
          //  if (collision.transform.name == "Player" || collision.transform.tag == "PizzaBox")
          //  {
         //       collision.transform.parent = this.transform;
                //collision.transform.GetComponent<Rigidbody>().isKinematic = true;
           // }
        //}
    }

}
