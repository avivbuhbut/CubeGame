using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColidedWithDough : MonoBehaviour
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
        if (collision.gameObject.tag == "Dough")
            this.gameObject.SetActive(false);
    }
}
