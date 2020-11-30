using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifHitPlayerBecomePlayer : MonoBehaviour
{

    //  public Transform Basket2GObject;
    public static bool PlayerIsNowAcitvePlayer;
    public Camera PlayerCamera;
    bool thePlayerIsNotTHisCube;
    bool PressedOnAnotherCubeShifter;
    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && CubeShifterScrpt.hit.transform.name=="Player")
        {
            this.gameObject.transform.GetComponent<PlayerMovment>().enabled = false;
        
                GameObject.Find("Player").transform.GetComponent<PlayerMovment>().enabled = true;
            PlayerIsNowAcitvePlayer = true;
            becomeCubeShifter.CubeSHifterIsNowPlayer = false;
            PlayerCamera.GetComponent<FollowCamera2Script>().target = GameObject.Find("Player").transform;

            
        }
       

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "CubeShifter" && CubeShifterScrpt.hit.transform.name == "CubeShifter1")
        {
            PressedOnAnotherCubeShifter = true;
        }





    }
}
