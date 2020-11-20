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
        if (!(ColidedWithSouce))
            transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Sauce").transform.position, .9f * Time.deltaTime); // move towards the pizza box
       else
            transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("LeftBoundEnemy").transform.position, .9f * Time.deltaTime); 
    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.transform.tag== "Sauce")
        {
            ColidedWithSouce = true;
            GameObject.Find("CubeEnemy").transform.parent = GameObject.Find("Sauce").gameObject.transform;
        }
    }
}
