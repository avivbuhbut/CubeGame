using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleDownObjectOnEnter : MonoBehaviour
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
        if (other.gameObject.transform.tag == "CubeShifter")
        {
            other.transform.localScale = new Vector3(0.120554f, 0.09011137f, 0.1087186f);
           
            other.transform.parent = this.transform;
        }

    }
}
