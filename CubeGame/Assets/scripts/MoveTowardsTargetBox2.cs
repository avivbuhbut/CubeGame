using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTargetBox2 : MonoBehaviour
{


    public Transform PizzaBox2Trans;
    public Transform LeftBoundsEnemy;
    public Transform PizzaBoxesTrans;
    public Transform Cameras;

    public Camera PizzaBox2Cam;


    public bool ColidedWithPizza;
    public bool pizzaBox2InAir;

    // Start is called before the first frame update
    void Start()
    {
        ColidedWithPizza = false;

    }

    // Update is called once per frame
    void Update()
    {
        pizzaBox2InAir = PizzaBox2Trans.GetComponent<ScoreCount>().pizzaBox2InAir;

        if (!ColidedWithPizza && pizzaBox2InAir == false)
            transform.position = Vector3.MoveTowards(this.transform.position, PizzaBox2Trans.position, .6f * Time.deltaTime); // move towards the pizza box
        if (ColidedWithPizza && pizzaBox2InAir == false)
            transform.position = Vector3.MoveTowards(this.transform.position, LeftBoundsEnemy.position, .6f * Time.deltaTime); // move towards the left bound
        else
        {
            ColidedWithPizza = false;
            PizzaBox2Trans.transform.parent = null ;
            PizzaBox2Cam.transform.parent = Cameras;
        }
    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "PizzaBOX2")
        {
            ColidedWithPizza = true;
            Debug.Log("Colision with pizza box");
            PizzaBox2Trans.transform.parent = gameObject.transform;
            PizzaBox2Cam.transform.parent = gameObject.transform;
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
