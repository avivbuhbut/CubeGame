using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket1ChildOfPlayer1 : MonoBehaviour
{

    public Transform Player1;
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
        if (collision.gameObject.transform.tag == "Player")
        {
            gameObject.transform.parent = Player1.transform;
            gameObject.transform.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.transform.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
