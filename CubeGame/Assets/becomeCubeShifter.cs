using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class becomeCubeShifter : MonoBehaviour
{


    //  public Transform Basket2GObject;
    public static bool CubeSHifterIsNowPlayer;
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
        if (PlayerPressOnCubeShifter && Input.GetKeyDown(KeyCode.M) && CubeShifterScrpt.hit.transform.name != "CubeShifter2")
        {
            this.gameObject.transform.GetComponent<PlayerMovment>().enabled = false;
            if (CubeShifterScrpt.hit.transform != null)
                CubeShifterScrpt.hit.transform.GetComponent<PlayerMovment>().enabled = true;
            CubeSHifterIsNowPlayer = true;
            ifHitPlayerBecomePlayer.PlayerIsNowAcitvePlayer = false;

            PlayerCamera.GetComponent<FollowCamera2Script>().target = CubeShifterScrpt.hit.transform;
         
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "CubeShifter" && CubeShifterScrpt.hit.transform.name == "CubeShifter1" ) 
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
