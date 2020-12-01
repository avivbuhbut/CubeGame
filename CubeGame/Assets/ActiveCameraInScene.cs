using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCameraInScene : MonoBehaviour
{

    public static Camera ActiveStaticCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.gameObject.activeSelf)
            ActiveStaticCam = Camera.main;

        if(GameObject.Find("ZoomOutForDrawCam").gameObject.activeSelf)
            ActiveStaticCam = GameObject.Find("ZoomOutForDrawCam").transform.GetComponent<Camera>();
    }
}
