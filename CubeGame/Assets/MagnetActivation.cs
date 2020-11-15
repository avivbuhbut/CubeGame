using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetActivation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
         this.transform.GetComponent<SphereCollider>().isTrigger = false; // good to "shoot" the attached objects
        //try taking the magnitoude down to zero in the magnet script

        if(Input.GetMouseButtonDown(0))
            this.transform.GetComponent<SphereCollider>().isTrigger = true;
        //try taking the magnitoude Up to 80 in the magnet script
    }
}
