using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTargetBox1 : MonoBehaviour
{

    public Transform PizzaBox1Trans;
    public Transform LeftBoundsEnemy;

    public bool ColidedWithPizza;

    // Start is called before the first frame update
    void Start()
    {
        ColidedWithPizza = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(!ColidedWithPizza)
        transform.position = Vector3.MoveTowards(this.transform.position, PizzaBox1Trans.position, .6f * Time.deltaTime); // move towards the pizza box
        if (ColidedWithPizza)
            transform.position = Vector3.MoveTowards(this.transform.position, LeftBoundsEnemy.position, .6f * Time.deltaTime); // move towards the left bound


    }



     void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.name == "PizzaBOX1")
        {
            ColidedWithPizza = true;
            Debug.Log("Colision with pizza box");
            PizzaBox1Trans.transform.parent = gameObject.transform;
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
