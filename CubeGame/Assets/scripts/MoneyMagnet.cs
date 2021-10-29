﻿using System.Collections.Generic;
using UnityEngine;

public class MoneyMagnet : MonoBehaviour
{
    public static float  magnetForce = 200;

    List<Rigidbody> caughtRigidbodies = new List<Rigidbody>();

    void FixedUpdate()
    {
        for (int i = 0; i < caughtRigidbodies.Count; i++)
        {
            caughtRigidbodies[i].velocity = (transform.position - (caughtRigidbodies[i].transform.position + caughtRigidbodies[i].centerOfMass)) * magnetForce * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.transform.tag == "Money") // change accordint to needs
        {
            if (other.GetComponent<Rigidbody>())
            {
                Rigidbody r = other.GetComponent<Rigidbody>();

                if (!caughtRigidbodies.Contains(r))
                {
                    //Add Rigidbody
                    caughtRigidbodies.Add(r);
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.tag == "Money") 
        {// change accordint to needs
            if (other.GetComponent<Rigidbody>())
            {
                Rigidbody r = other.GetComponent<Rigidbody>();

                if (caughtRigidbodies.Contains(r))
                {
                    //Remove Rigidbody
                    caughtRigidbodies.Remove(r);
                }
            }
        }
    }
}
