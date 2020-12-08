using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockWave : MonoBehaviour
{
    int magnetForce = 100;
       List<Rigidbody> caughtRigidbodies = new List<Rigidbody>();
    // Start is called before the first frame update
    void Start()
    {
        this.transform.GetComponent<SphereCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            this.transform.GetComponent<SphereCollider>().enabled = true;
            for (int i = 0; i < caughtRigidbodies.Count; i++)
            {
                Debug.Log("caughtRigidbodies[i]: " + caughtRigidbodies[i]);
                caughtRigidbodies[i].velocity = (transform.position - (caughtRigidbodies[i].transform.position + caughtRigidbodies[i].centerOfMass)) * magnetForce*0.4f * Time.deltaTime;
            }

        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            Debug.Log(" O key is now up");
            for (int i = 0; i < caughtRigidbodies.Count; i++)
            {
                Debug.Log("caughtRigidbodies[i]: " + caughtRigidbodies[i]);
                caughtRigidbodies[i].velocity = (transform.position - (caughtRigidbodies[i].transform.position + caughtRigidbodies[i].centerOfMass)) * -magnetForce*7 * Time.deltaTime;
            }
        }
    }

    void OnTriggerEnter(Collider other)
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

    void OnTriggerExit(Collider other)
    {


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
