using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoveTowardsPlayer : MonoBehaviour
{
    public Material PlayerRedMaterial;
    bool PlayerIsInRadius; 
    // Start is called before the first frame update
    void Start()
    {
        this.transform.GetComponent<Renderer>().material.SetColor("_Color", Color.green);

    }

    // Update is called once per frame
    void Update()
    {


        if(this.transform.position == GameObject.Find("Player").transform.position)
        {
            GameObject.Find("Player").transform.GetComponent<Renderer>().material = PlayerRedMaterial;
            Debug.Log("now isinde player");
        }

        if (PlayerIsInRadius)
        {
     
            this.transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Player").transform.position, 1.7f * Time.deltaTime); // move towards the pizza box
       
            this.transform.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
        else
            this.transform.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }


 
     void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.name == "Player")
        {
            Debug.Log("In Sphere radius:" + other.transform.gameObject.name);
            PlayerIsInRadius = true;
        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.name == "Player")
        {
            Debug.Log("Player Exit Sphere radius:" + other.transform.gameObject.name);
            PlayerIsInRadius = false;
        }
    }
}
