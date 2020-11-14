using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTargetBox1 : MonoBehaviour
{

    public Transform PizzaBox1Trans;
    public Transform LeftBoundsEnemy;
    public Transform PizzaBoxesTrans;
    public Transform Cameras;


    public Camera PizzaBox1Cam;


    public bool ColidedWithPizza;
    public bool pizzaBox1InAir;

    // Start is called before the first frame update
    void Start()
    {
        ColidedWithPizza = false;
     //   PizzaBox1Trans.transform.parent = PizzaBoxesTrans;

    }

    // Update is called once per frame
    void Update()
    {
        pizzaBox1InAir = PizzaBox1Trans.GetComponent<ScoreCount>().pizzaBox1InAir;

       if (!(ColidedWithPizza) && pizzaBox1InAir == false)
            transform.position = Vector3.MoveTowards(this.transform.position, PizzaBox1Trans.position, .6f * Time.deltaTime); // move towards the pizza box
        if (ColidedWithPizza && pizzaBox1InAir == false)
           transform.position = Vector3.MoveTowards(this.transform.position, LeftBoundsEnemy.position, .6f * Time.deltaTime); // move towards the left bound
        
       if(pizzaBox1InAir == true) { 
          ColidedWithPizza = false;
         PizzaBox1Trans.transform.parent = PizzaBoxesTrans;
            PizzaBox1Cam.transform.parent = Cameras;


       }
    }




    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.name == "PizzaBOX1")
        {
            ColidedWithPizza = true;
            Debug.Log("Colision with pizza box");
            PizzaBox1Trans.transform.parent = gameObject.transform;
            PizzaBox1Cam.transform.parent = gameObject.transform;
            transform.position = Vector3.MoveTowards(this.transform.position, LeftBoundsEnemy.position, .6f * Time.deltaTime);
        }

     
    }

    /*

     void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject.tag != "Floor")
        {
            Debug.Log("Enemy is not touching the floor");
            gameObject.transform.parent = null;
            ColidedWithPizza = false;
        }
    }*/
}
