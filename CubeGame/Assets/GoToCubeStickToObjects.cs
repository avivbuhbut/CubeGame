using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToCubeStickToObjects : MonoBehaviour
{

    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);                    ///Very Useful Code! - tells the object name when clicked by the mouse

        // Casts the ray and get the first game object hit
        Physics.Raycast(ray, out hit);

      //  if (hit.transform.name == "GoToStickCube")
           // this.transform.GetComponent<Rigidbody>().isKinematic = false;


       // if(hit.transform.name == this.transform.name && Input.GetMouseButtonDown(0))
      //  {
       //     this.transform.GetComponent<Rigidbody>().isKinematic = false;
       //     this.transform.parent = null;
       // }

    }

     void OnCollisionEnter(Collision collision)
    {

        if(collision.transform.name == "CubeDistraction (3)")
        this.transform.GetComponent<Rigidbody>().isKinematic = true;
        this.transform.parent = collision.transform;
    }
}
