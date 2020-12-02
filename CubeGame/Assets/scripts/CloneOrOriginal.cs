using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneOrOriginal : MonoBehaviour
{
    public Camera PizzaBox1Cam;
    public Transform PizzaCloneTrans;
    private static Transform  CurrentTransformInAir;
    public int pizzaCounter ;

    public static string CurrentTransInAirName;
    // Start is called before the first frame update
    void Start()
    {
        CurrentTransformInAir = this.transform;
        pizzaCounter = CreatePizza.counterPizzaGen;

    }

    // Update is called once per frame
    void Update()
    {
  

    /*Fuck You Code - but thanks for working :)*/
     
       



        if ((GameObject.Find("PizzaBoxClone" + pizzaCounter) != null))
        {
            if ((GameObject.Find("PizzaBoxClone" + pizzaCounter).transform.GetComponent<Rigidbody>().velocity.magnitude > 2))
            {
              

                CurrentTransformInAir = (GameObject.Find("PizzaBoxClone" + pizzaCounter).transform);

                if ((CurrentTransformInAir.transform.GetComponent<Rigidbody>().velocity.magnitude > 2) &&
             (!Input.GetKey(KeyCode.Mouse0)))
                {
                    // Debug.Log("PizzaBoxCloneInAir: " + CurrentTransformInAir.transform.name);
                    PizzaBox1Cam.GetComponent<FollowCamera2Script>().target = CurrentTransformInAir.transform;


                }
            }
        }
        else
        {
            pizzaCounter--;

            if (pizzaCounter == 0)
                pizzaCounter = CreatePizza.counterPizzaGen;


        }


        /*
        if ((this.gameObject.transform.name == "PizzaBOX1(Clone)") &&
            (GameObject.Find("PizzaBOX1(Clone)").transform.GetComponent<Rigidbody>().velocity.magnitude > 2) &&
            (!Input.GetKey(KeyCode.Mouse0)))
        {
            Debug.Log("PizzaBOX1(Clone) is in the air");
            PizzaBox1Cam.GetComponent<FollowCamera2Script>().target = GameObject.Find("PizzaBOX1(Clone)").transform;
   

        }


        if ((this.gameObject.transform.name == "PizzaBOX1") &&
           (this.gameObject.transform.GetComponent<Rigidbody>().velocity.magnitude > 2) &&
           (!Input.GetKey(KeyCode.Mouse0)))
        {
            Debug.Log("PizzaBOX1 is in the air");
            PizzaBox1Cam.GetComponent<FollowCamera2Script>().target = this.gameObject.transform;
        }*/

    }


     void OnCollisionEnter(Collision collision)
   
    {
        if (collision.gameObject.transform.tag == "Floor")
            CurrentTransformInAir = null;


        {
           // Debug.Log("This pizza is not touching the floor" + this.gameObject);
           // CurrentTransformInAir = this.gameObject.transform;
        }
    }
}
