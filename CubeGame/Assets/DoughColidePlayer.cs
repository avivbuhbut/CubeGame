﻿using UnityEngine;

public class DoughColidePlayer : MonoBehaviour
{
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

        Debug.Log(collision.transform.name);
        
    }
}