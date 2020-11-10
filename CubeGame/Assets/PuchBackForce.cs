using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuchBackForce : MonoBehaviour
{



    public float pushForce = 10;
    public Rigidbody HummerBoxRigidBody;
    public GameObject Player2GamObj;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(gameObject.transform.parent == Player2GamObj.transform)
            Player2GamObj.GetComponent<SC_RigidbodyMagnet>().enabled = false;

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "CubeDistraction")
        {
            Debug.Log("pushLeft");
            HummerBoxRigidBody.AddForce(Vector2.left * pushForce, ForceMode.Impulse);
            Player2GamObj.GetComponent<SC_RigidbodyMagnet>().enabled = true;
        }
    }

}
