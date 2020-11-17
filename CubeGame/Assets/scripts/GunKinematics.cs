using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunKinematics : MonoBehaviour
{

    public Transform HandGunTrans;
    public Transform M1911;
    // Start is called before the first frame update
    void Start()
    {
     //   HandGunTrans.GetComponent<Rigidbody>().isKinematic = true;
        //M1911.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Floor" || collision.gameObject.tag == "Player")
        {
            HandGunTrans.GetComponent<Rigidbody>().isKinematic = false;
            M1911.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
