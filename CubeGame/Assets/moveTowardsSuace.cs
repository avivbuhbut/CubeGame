using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsSuace : MonoBehaviour
{

    bool ColidedWithSouce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*if the enemy didnt colided with the sauce move towards the sauce, else - move towards bounds*/
        if (!(ColidedWithSouce))
            transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Sauce").transform.position, .9f * Time.deltaTime); // move towards the pizza box
       else
            transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("LeftBoundEnemy").transform.position, .9f * Time.deltaTime);


        /*if the enemy is now dead make the sauce go to the original sauce parent agian*/
       if(GameObject.Find("CubeEnemy").GetComponent<Enemy1Health>().health == 0)
        {
            GameObject.Find("Sauce").gameObject.transform.parent = GameObject.Find("PizzaIngridians").gameObject.transform;
        }

    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.transform.tag== "Sauce")
        {
      
            ColidedWithSouce = true;

            GameObject.Find("Sauce").gameObject.transform.parent = GameObject.Find("CubeEnemy").transform;
        }
    }
}
