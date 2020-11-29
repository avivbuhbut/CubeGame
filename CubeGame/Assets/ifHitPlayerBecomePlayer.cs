using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifHitPlayerBecomePlayer : MonoBehaviour
{

    //  public Transform Basket2GObject;

    public Camera PlayerCamera;
    bool thePlayerIsNotTHisCube;
    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && this.transform.gameObject.activeSelf)
        {
            this.gameObject.transform.GetComponent<PlayerMovment>().enabled = false;
        
                GameObject.Find("Player").transform.GetComponent<PlayerMovment>().enabled = true;


            PlayerCamera.GetComponent<FollowCamera2Script>().target = GameObject.Find("Player").transform;

            
        }
       

    }


    void OnCollisionEnter(Collision collision)
    {
     
        



    }
}
