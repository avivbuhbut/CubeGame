using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhosMoving : MonoBehaviour
{





    /*Pizza Box1 updated pos*/
    public Vector3 VelBox1;
    public Rigidbody Box1Rigidbody;
    public Transform PizzaBox1;
    public float speedBox2;



    /*Pizza Box2 updated pos*/
    public Vector3 VelBox2;
    public Rigidbody Box2Rigidbody;
    public Transform PizzaBox2;

    public float speedBox1;


   




    // Start is called before the first frame update
    void Start()
    {

       

        speedBox1 = Box1Rigidbody.velocity.magnitude;
        speedBox2 = Box2Rigidbody.velocity.magnitude;




    }

    // Update is called once per frame
    void Update()
    {


        VelBox1 = Box1Rigidbody.velocity;
        VelBox2 = Box2Rigidbody.velocity;

        /*box1 is moving*/
        if (VelBox1.magnitude > 4)
        {
          
            Debug.Log("Box1 Is Moving!!");
        }


        /*box2 is moving*/
        if (VelBox2.magnitude > 4)
        {
   
            Debug.Log("Box2 Is Moving!!");
        }
  






    }

  
}
