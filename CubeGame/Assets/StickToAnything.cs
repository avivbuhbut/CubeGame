using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToAnything : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CubeShifterScrpt.hit.transform!=null)
        if (CubeShifterScrpt.hit.transform.name == "CubeShifter1" && Input.GetKey(KeyCode.L))
        {
            this.transform.GetComponent<Rigidbody>().isKinematic = false;
            this.transform.parent = null;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (CubeShifterScrpt.hit.transform != null)
            if (CubeShifterScrpt.hit.transform.name == "CubeShifter1" && Input.GetKey(KeyCode.K) || CubeShifterScrpt.hit.transform.name == "CubeShifter1(Clone)" && Input.GetKey(KeyCode.L))
            {
                Debug.Log(CubeShifterScrpt.hit.transform.name);
                this.transform.parent = collision.transform;
                this.transform.GetComponent<Rigidbody>().isKinematic = true;
            }
    }
    
}
