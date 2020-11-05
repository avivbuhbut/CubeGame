using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeGrandually : MonoBehaviour
{
    // Start is called before the first frame update

    Color lerpedColor = Color.white;

    void Start()
    {

    }

    void Update()
    {

        /*try somthing else to make it grasually change to change the house color in from dark to bright*/
        lerpedColor = Color.Lerp(Color.white, Color.black, Time.time*2);
        gameObject.GetComponent<MeshRenderer>().material.color = lerpedColor;
    }
}


