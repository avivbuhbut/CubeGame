using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickToOtherWood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.transform.name == "CubePlayerCreate(Clone)")
        {
          collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x, this.transform.position.y, collision.gameObject.transform.position.z);
            this.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         //   collision.gameObject.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
