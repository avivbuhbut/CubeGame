using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneOrOriginal : MonoBehaviour
{
    public Camera PizzaBox1Cam;
    public Transform PizzaCloneTrans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((this.gameObject.transform.name == "PizzaBoxClone" +CreatePizza.counterPizzaGen ) &&
            (GameObject.Find("PizzaBoxClone" + CreatePizza.counterPizzaGen).transform.GetComponent<Rigidbody>().velocity.magnitude > 2) &&
            (!Input.GetKey(KeyCode.Mouse0)))
        {
            Debug.Log("PizzaBoxClone" + CreatePizza.counterPizzaGen);
            PizzaBox1Cam.GetComponent<FollowCamera2Script>().target = GameObject.Find("PizzaBoxClone" + CreatePizza.counterPizzaGen).transform;


        }



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
        }

    }
}
