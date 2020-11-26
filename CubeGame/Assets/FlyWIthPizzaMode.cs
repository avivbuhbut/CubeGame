using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyWIthPizzaMode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.F)){
        
                GameObject.Find("Player").transform.position = new Vector3(GameObject.FindWithTag("PizzaBox").transform.position.x, GameObject.FindWithTag("PizzaBox").transform.position.y + 1, GameObject.FindWithTag("PizzaBox").transform.position.z);
          
        }
        
    }
}
