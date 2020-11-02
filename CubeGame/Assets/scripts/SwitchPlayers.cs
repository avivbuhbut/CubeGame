using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayers : MonoBehaviour
{

    public GameObject Player;
    public GameObject Player2;
    public Camera PlayerCam;
    public Camera Player2Cam;
    // Start is called before the first frame update
    void Start()
    {

        Player.gameObject.SetActive(false);

        // Player2.SetActive(!Player2.activeInHierarchy);
        /// Player2.SetActive(!Player2.activeInHierarchy);
   
        //Player2.SetActive(Player2.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        //var Player = GameObject.Find("Player");
        // var Player2 = GameObject.Find("Player2");



        if (Input.GetKeyDown(KeyCode.P))
        {

            if (Player.active == true ) // player is now the main player ACTIVATE player2
            {
                // Player2Cam.enabled = true;
                // PlayerCam.enabled = false;
                Player.gameObject.SetActive(false);
                PlayerCam.gameObject.SetActive(false);
                Player2Cam.gameObject.SetActive(true);
                Player2.gameObject.SetActive(true);
                
            //    
            }
            else    // player2 is now the main player ACTIVATE player

            {
           


                Player2Cam.gameObject.SetActive(false);
                PlayerCam.gameObject.SetActive(true);
                Player2.gameObject.SetActive(false);
                Player.gameObject.SetActive(true);

            }




        }

    }




}