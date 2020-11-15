using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetChildOfPlayer : MonoBehaviour
{


    public Transform Player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
          //  this.gameObject.transform.parent = null;
           // this.gameObject.transform.GetComponent<MagnetActivation>().enabled = false;
        }
    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player2")
        {
         //   this.gameObject.transform.parent = Player2.transform;
         //   this.gameObject.transform.GetComponent<MagnetActivation>().enabled = true;
        }
    }
}
