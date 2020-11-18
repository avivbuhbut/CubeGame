﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePizza : MonoBehaviour
{

    public static int counterPizzaGen = 0;
    //public GameObject DoughAndSauceGamObjClone;
    public GameObject DoughAndSauceGamObj;
    public GameObject PizzaBox1GamObj;



    // Start is called before the first frame update
    void Start()
    {
        PizzaBox1GamObj.gameObject.SetActive(false);
        DoughAndSauceGamObj.gameObject.SetActive(false);
        PizzaBox1GamObj.name = "PizzaBoxClone1";
    }

    // Update is called once per frame
    void Update()
    {
     
        Debug.Log("counterPizzaGen:" + counterPizzaGen);
    }

     void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.transform.name == "DoughAndSauce(Clone)" || collision.gameObject.transform.name == "DoughAndSauce")
        {
     
            counterPizzaGen++;


            if (counterPizzaGen < 2)
            {
       
                GameObject Clone =  Instantiate(PizzaBox1GamObj, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                Clone.transform.name = "PizzaBoxClone" + counterPizzaGen;
                PizzaBox1GamObj.gameObject.SetActive(true);
              //  GameObject.Find("DoughAndSauce(Clone)").SetActive(false);
                //      Destroy(GameObject.Find("DoughAndSauce(Clone)"));

            }
            else
            {
            

                GameObject Clone = Instantiate(PizzaBox1GamObj, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                Clone.transform.name = "PizzaBoxClone" + counterPizzaGen;
                Clone.transform.parent = PizzaBox1GamObj.transform.parent;
           
                //  Destroy(GameObject.Find("DoughAndSauce(Clone)"));


            }
        }
   

    

           


            //  PizzaBox1GamObj.transform.GetComponent<Rigidbody>().velocity = PizzaBox1GamObj.transform.forward * 3;


        
    }
}
