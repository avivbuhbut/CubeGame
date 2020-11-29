using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colidedWithTriggerBecomeChild : MonoBehaviour
{
    // Start is called before the first frame update
    Transform onTriggerTrans;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //  if(GameObject.FindWithTag("CubeShifter").transform!= null)
      //  if (GameObject.FindWithTag("CubeShifter").GetComponent<CubeShifterScrpt>().hit.transform.tag != "CubeShifter")
       // {
       //     onTriggerTrans.transform.parent =null;
       //     onTriggerTrans.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
       // }
    }


     void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Player" || other.transform.tag == "PizzaBox")
        {
            onTriggerTrans = other.transform;
            other.transform.parent = this.transform;
            other.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
    
        
   
}
