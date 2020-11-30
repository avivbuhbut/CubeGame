using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColidedWithAnotherCubeShifter : MonoBehaviour
{
    public static bool ColidedWithAnotherCubeShifterbool;
    public static Transform ColidedWithTransCubeShifter;
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
        if(collision.gameObject.transform.tag == "CubeShifter")
        {

            ColidedWithTransCubeShifter = collision.transform;
            Debug.Log(ColidedWithTransCubeShifter.transform.name);
            ColidedWithAnotherCubeShifterbool = true;
        }

       
            GameObject.Find("Player").GetComponent<DragRigidbody>().enabled = true;
        this.transform.parent = null;


    }

     void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.transform.tag == "CubeShifter")
        {

            ColidedWithAnotherCubeShifterbool = false;
            ColidedWithTransCubeShifter = null;
        }
    }
}
