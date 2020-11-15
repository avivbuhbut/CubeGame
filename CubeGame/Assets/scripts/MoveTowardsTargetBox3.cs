using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTargetBox3: MonoBehaviour
{

    public Transform PizzaBox3Trans;
    public Transform LeftBoundsEnemy;
    public Transform PizzaBoxes;
    public Transform PizzaBox3Cam;
    public Transform Cameras;
    public bool ColidedWithPizza;
    public bool pizzaBox3InAir;

    // Start is called before the first frame update
    void Start()
    {
        ColidedWithPizza = false;
    
    }

    // Update is called once per frame
    void Update()
    {
        pizzaBox3InAir = PizzaBox3Trans.GetComponent<ScoreCount>().pizzaBox3InAir;

        if (!ColidedWithPizza && pizzaBox3InAir == false)
            transform.position = Vector3.MoveTowards(this.transform.position, PizzaBox3Trans.position, .6f * Time.deltaTime); // move towards the pizza box
        if (ColidedWithPizza && pizzaBox3InAir == false)
            transform.position = Vector3.MoveTowards(this.transform.position, LeftBoundsEnemy.position, .6f * Time.deltaTime); // move towards the left bound
        else
        {
            ColidedWithPizza = false;
            PizzaBox3Trans.transform.parent = null;
            PizzaBox3Cam.transform.parent = Cameras;

        }


         
    }



    void OnCollisionEnter(Collision collision)
    {



        if (collision.gameObject.name == "PizzaBOX3")
        {
            ColidedWithPizza = true;
         
            PizzaBox3Trans.transform.parent = gameObject.transform;
            PizzaBox3Cam.transform.parent = gameObject.transform; ;
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
