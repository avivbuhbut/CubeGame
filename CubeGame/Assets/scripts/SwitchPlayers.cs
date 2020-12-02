using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwitchPlayers : MonoBehaviour
{

    public GameObject Player;
    public GameObject Player2;
    public Camera PlayerCam;
    public Camera Player2Cam;

    /*Players text*/
    public TextMeshPro Player1Controls;
    public TextMeshPro Player2Controls;
    public TextMeshPro Player1GlobalScore;
    public TextMeshPro Player2GlobalScore;



    // Start is called before the first frame update
    void Start()
    {

        Player2Controls.gameObject.SetActive(false);
        Player2GlobalScore.gameObject.SetActive(false);
        //.gameObject.SetActive(true);
        Player1Controls.gameObject.SetActive(true);

        Player2Cam.gameObject.SetActive(false);
        Player2.gameObject.SetActive(false);
        PlayerCam.gameObject.SetActive(true);
        Player.gameObject.SetActive(true);
   
        
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
                Player1GlobalScore.gameObject.SetActive(false);
                Player1Controls.gameObject.SetActive(false);
                Player.gameObject.SetActive(false);
                PlayerCam.gameObject.SetActive(false);
                Player2Cam.gameObject.SetActive(true);
                Player2.gameObject.SetActive(true);
                Player2Controls.gameObject.SetActive(true);
                Player2GlobalScore.gameObject.SetActive(true);
                
            //    
            }
            else    // player2 is now the main player ACTIVATE player

            {



                Player1GlobalScore.gameObject.SetActive(true);
                Player1Controls.gameObject.SetActive(true);

                Player2Cam.gameObject.SetActive(false);
                PlayerCam.gameObject.SetActive(true);
                Player2.gameObject.SetActive(false);
                Player.gameObject.SetActive(true);

                Player2Controls.gameObject.SetActive(false);
                Player2GlobalScore.gameObject.SetActive(false);

            }




        }

    }




}