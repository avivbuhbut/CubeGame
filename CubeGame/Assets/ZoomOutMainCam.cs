using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOutMainCam : MonoBehaviour
{
    // Start is called before the first frame update
    public RaycastHit Hit;
    void Start()
    {
        Debug.Log("Camera.main.fieldOfView: " + Camera.main.fieldOfView);
        //Camera.main.fieldOfView = 100f;
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log()

       if (Hit.transform.tag == "PizzaBox")
        {
            Camera.main.fieldOfView = 100;
        }
        else
            Camera.main.fieldOfView = 60;

    }
}
