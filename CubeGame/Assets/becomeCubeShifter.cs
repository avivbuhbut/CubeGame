using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class becomeCubeShifter : MonoBehaviour
{

  
    //  public Transform Basket2GObject;

    public Camera PlayerCamera;
    bool PlayerPressOnCubeShifter;
    // Start is called before the first frame update
    void Start()
    {
        if (CubeShifterScrpt.hit.transform != null)
        if (CubeShifterScrpt.hit.transform.tag == "CubeShifter")
            CubeShifterScrpt.hit.transform.GetComponent<PlayerMovment>().enabled = false;
        //  Basket2GObject.transform.GetComponent<PlayerMovment>().enabled = false;

    }

    // Update is called once per frame

    void Update()
    {
        if (PlayerPressOnCubeShifter && Input.GetKeyDown(KeyCode.L))
        {
            this.gameObject.transform.GetComponent<PlayerMovment>().enabled = false;
            if (CubeShifterScrpt.hit.transform != null)
                CubeShifterScrpt.hit.transform.GetComponent<PlayerMovment>().enabled = true;

         
            PlayerCamera.GetComponent<FollowCamera2Script>().target = CubeShifterScrpt.hit.transform;
         
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "CubeShifter" && CubeShifterScrpt.hit.transform == collision.transform) 
        {
            PlayerPressOnCubeShifter = true;
    
        
          
        }


      

        //  if(collision.gameObject.transform.tag == "Basket2")
        //   {
        // //     this.gameObject.transform.GetComponent<PlayerMovment>().enabled = false;
        //     Basket2GObject.transform.GetComponent<PlayerMovment>().enabled = true;
        //    PlayerCamera.GetComponent<FollowCamera2Script>().target = Basket2GObject.transform;
        // }

    }
}
