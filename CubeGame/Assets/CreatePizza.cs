using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePizza : MonoBehaviour
{
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
        
    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.transform.tag == "DoughAndSauce" )
        {
            Destroy(DoughAndSauceGamObj);
          
            //PizzaBox1GamObj.transform.position = new Vector3()
            Instantiate(PizzaBox1GamObj, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            PizzaBox1GamObj.gameObject.SetActive(true);
            //  PizzaBox1GamObj.transform.GetComponent<Rigidbody>().velocity = PizzaBox1GamObj.transform.forward * 3;


        }
    }
}
