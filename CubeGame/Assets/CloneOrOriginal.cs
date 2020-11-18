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

        if ((this.gameObject.transform.name == "PizzaBoxClone") &&
            (GameObject.Find("PizzaBoxClone").transform.GetComponent<Rigidbody>().velocity.magnitude > 2) &&
            (!Input.GetKey(KeyCode.Mouse0)))
        {
            Debug.Log("PizzaBOX1(Clone) is in the air");
            PizzaBox1Cam.GetComponent<FollowCamera2Script>().target = GameObject.Find("PizzaBoxClone").transform;
            Debug.Log("PizzaCloneTrans.pos.x: " + PizzaCloneTrans.transform.localPosition.x);
            //PizzaBox1Cam.enabled = true;
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
