﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBoneTestPlayerHand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        
        Debug.Log("Test");
        // = Quaternion.Euler(0, 0.2f, 0);
        
      // this.transform.localRotation = Quaternion.Euler(0.2f, 0,0);
        this.transform.rotation = Quaternion.Euler(0, 0.2f, 0);

    }
}
