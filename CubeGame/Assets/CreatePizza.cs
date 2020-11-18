using System.Collections;
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
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("counterPizzaGen:" + counterPizzaGen);
    }

    int counter = 0;
    int counterClone = 0;
    
     void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.transform.name == "DoughAndSauce(Clone)")
        {
            counterClone++;
            counterPizzaGen++;


            if (counterClone < 2)
            {
       
                Instantiate(PizzaBox1GamObj, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);

                PizzaBox1GamObj.gameObject.SetActive(true);
              //  GameObject.Find("DoughAndSauce(Clone)").SetActive(false);
                //      Destroy(GameObject.Find("DoughAndSauce(Clone)"));

            }
            else
            {
            

                GameObject Clone = Instantiate(PizzaBox1GamObj, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                Clone.transform.name = "PizzaBoxClone" + counterClone;
                Clone.transform.parent = PizzaBox1GamObj.transform.parent;
           
                //  Destroy(GameObject.Find("DoughAndSauce(Clone)"));


            }
        }
   

    

        if(collision.gameObject.transform.name == "DoughAndSauce" )
        {

            counter++;
            counterPizzaGen++;



            if (counter < 2)
            {
        Instantiate(PizzaBox1GamObj, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            
                //    Destroy(DoughAndSauceGamObj);
                //  DoughAndSauceGamObj.SetActive(false);
                PizzaBox1GamObj.gameObject.SetActive(true);
            }
            else
            {
                counterPizzaGen += counter;

                GameObject Clone = Instantiate(PizzaBox1GamObj, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                Clone.transform.tag = "PizzaBoxClone" + counter;
                Clone.transform.parent = PizzaBox1GamObj.transform.parent;
              //  DoughAndSauceGamObj.SetActive(false);
             //   Destroy(DoughAndSauceGamObj);
             
            }



            //  PizzaBox1GamObj.transform.GetComponent<Rigidbody>().velocity = PizzaBox1GamObj.transform.forward * 3;


        }
    }
}
