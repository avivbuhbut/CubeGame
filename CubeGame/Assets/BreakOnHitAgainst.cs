using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakOnHitAgainst : MonoBehaviour
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
        if(collision.transform.gameObject.tag == "Floor" || collision.transform.gameObject.name == "SauceShelf"
            || collision.transform.gameObject.name == "WaterShelf" || collision.transform.gameObject.name == "FlourShelf")
        {
            if (this.transform.GetComponent<Rigidbody>().velocity.magnitude > 5)
            {
                this.transform.GetComponent<MeshDestroy>().DestroyMesh(collision.transform.gameObject.GetComponent<MeshFilter>().mesh, collision.transform.GetComponent<MeshDestroy>(), collision.gameObject);
            }

        }
    }
}
