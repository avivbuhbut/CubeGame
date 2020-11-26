using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAndPizzaEnter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player" && other.gameObject.tag == "PizzaBox")
        {
            Debug.Log("player and pizza box are on the button!");

        }
    }
}
