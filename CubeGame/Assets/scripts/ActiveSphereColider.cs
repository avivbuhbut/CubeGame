using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSphereColider : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform HammerCube;
    void Start()
    {
      //  gameObject.GetComponent<SphereCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.GetComponent<SphereCollider>().enabled = true;
        if((HammerCube.IsChildOf(this.gameObject.transform) == false))
            gameObject.GetComponent<SphereCollider>().enabled = false;



    }

     void OnCollisionEnter(Collision collision)
    {
        
     



    }
}
