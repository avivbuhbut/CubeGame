using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardsSuace : MonoBehaviour
{

    Vector3 scaleChangeBiger;
    Vector3 scaleChangeSmaller;

    bool ColidedWithSouce;
    // Start is called before the first frame update
    void Start()
    {
        scaleChangeBiger = new Vector3(0.001f, 0.001f, 0.001f);
        scaleChangeSmaller = new Vector3(-0.001f, -0.001f, -0.001f);
    }

    // Update is called once per frame
    void Update()
    {

        /*if the enemy didnt colided with the sauce move towards the sauce, else - move towards bounds*/
        if (!(ColidedWithSouce))
            transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Sauce").transform.position, .9f * Time.deltaTime); // move towards the pizza box
      // else
            //transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("LeftBoundEnemy").transform.position, .9f * Time.deltaTime);




        /*if the enemy is now dead make the sauce go to the original sauce parent agian*/
       if(GameObject.Find("CubeEnemy").GetComponent<Enemy1Health>().health == 0)
        {
            GameObject.Find("Sauce").gameObject.transform.parent = GameObject.Find("PizzaIngridians").gameObject.transform;
            ColidedWithSouce = false;
        }


        if (ColidedWithSouce)
        {
           // GameObject.Find("Sauce").transform.parent = null;
            GameObject.Find("CubeEnemy").transform.localScale += scaleChangeBiger;
            GameObject.Find("Sauce").transform.localScale += scaleChangeSmaller;

        }

    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.transform.tag== "Sauce")
        {
      
            ColidedWithSouce = true;

           // GameObject.Find("Sauce").gameObject.transform.parent = GameObject.Find("CubeEnemy").transform;
        }
    }
}
