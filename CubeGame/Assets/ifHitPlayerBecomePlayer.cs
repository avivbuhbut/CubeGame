using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifHitPlayerBecomePlayer : MonoBehaviour
{

    //  public Transform Basket2GObject;

    public Camera PlayerCamera;
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
        if (collision.transform.tag == "Player" && CubeShifterScrpt.hit.transform == collision.transform)
        {
          
            this.gameObject.transform.GetComponent<PlayerMovment>().enabled = false;
            if (CubeShifterScrpt.hit.transform != null)
                collision.transform.GetComponent<PlayerMovment>().enabled = true;


            PlayerCamera.GetComponent<FollowCamera2Script>().target = collision.transform;

        }



    }
}
