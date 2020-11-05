﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreCount : MonoBehaviour
{

    /*Players1 and 2, Cameras and gameObjects */
    public Camera Player1CAM;
    public Camera Player2CAM;
    public GameObject player1GameObj;
    public GameObject player2GameObj;



    /*Global and Local Scores*/
    public static int GlobalScore;
    public int localScore;



    /*Player2 Texts*/
    public TextMeshPro GlobalScoreTextPlayer2;
    public TextMeshPro OutBoundsTextPlayer2;
    public TextMeshPro Plsyer2Contrls;


    /*Player texts*/
    public TextMeshPro GlobalScoreTMPPlayer;
    public TextMeshPro OutBoundsTextPlayerTMP;
    public TextMeshPro Plsyer1Contrls;


    /*Pizza Box1*/
    public Vector3 velBox1;
    public Camera CamBox1;
    public Rigidbody rigidbodyBox1;
    public Transform transformBox1;
    public TextMeshPro GlobalScoreTMPBox1;
    public TextMeshPro LocalScorepizzaBox1TMP;
    public float speedBox1;
    public int Box1LocalSocre;
    public int Box1GlobalSocre;


    public float currentPosX;
    public float currentPosY;
    public float currentPosZ;


    /*Pizza Box2*/
    public Vector3 velBox2;
    public Camera CamBox2;
    public Rigidbody rigidbodyBox2;
    public Transform transformBox2;
    public TextMeshPro GlobalScoreTMPBox2;
    public TextMeshPro LocalScorepizzaBox2TMP;
    public float speedBox2;
    public int Box2LocalSocre;
    public int Box2GlobalSocre;

    public RaycastHit hit;



    void Start()
    {


        hit = new RaycastHit();


        /*pizza Box1 speed && transform*/
        speedBox1 = rigidbodyBox1.velocity.magnitude;
        currentPosX = transform.position.x;
        currentPosY = transform.position.y;
        currentPosZ = transform.position.z;

        /*pizza text boxTMP*/
        GlobalScoreTMPBox1.gameObject.SetActive(false);
        LocalScorepizzaBox1TMP.gameObject.SetActive(false);



        /*Cameras*/
        CamBox1.gameObject.SetActive(false);
        CamBox2.gameObject.SetActive(false);
        Player2CAM.gameObject.SetActive(false);




        /*Player1 text TMP*/
        GlobalScoreTMPPlayer.gameObject.SetActive(true);
        OutBoundsTextPlayerTMP.enabled = false;


        /*Player2 text TMP*/
        OutBoundsTextPlayer2.enabled = false;

        /*Player2 active*/
        player2GameObj.gameObject.SetActive(false);



        /*pizzaBox2*/
        speedBox2 = rigidbodyBox2.velocity.magnitude;
        GlobalScoreTMPBox2.gameObject.SetActive(false);
        LocalScorepizzaBox2TMP.gameObject.SetActive(false);
    }

    void Update()
    {



        /*Global Score Player1*/
        GlobalScoreTMPPlayer.text = "Total Score: " + GlobalScore;


        /*Global Score Player2*/
        GlobalScoreTextPlayer2.text = "Total Score: " + GlobalScore;

        /*Box1 velocity*/
        velBox1 = rigidbodyBox1.velocity;


        /*Box2 velocity*/
        velBox2 = rigidbodyBox2.velocity;

      

        /*if Box 1 is in the air*/
        if ((velBox1.magnitude > 8) && (!Input.GetKey(KeyCode.Mouse0)))
        {
            Box1LocalSocre++;


            /*Player Text Control*/
            GlobalScoreTMPPlayer.gameObject.SetActive(false);
            GlobalScoreTextPlayer2.gameObject.SetActive(false);
            Plsyer1Contrls.gameObject.SetActive(false);
            Plsyer2Contrls.gameObject.SetActive(false);

            /*Box Text Control*/
            GlobalScoreTMPBox1.gameObject.SetActive(true);
            LocalScorepizzaBox1TMP.gameObject.SetActive(true);

            /*Cameras Control*/
            CamBox1.gameObject.SetActive(true);
            Player1CAM.gameObject.SetActive(false);
            Player2CAM.gameObject.SetActive(false);
  

            GlobalScore += Box1LocalSocre / 100;

            /*Box1 TMP Local and Global*/
            LocalScorepizzaBox1TMP.text = "LocalSocre " + Box1LocalSocre;
            GlobalScoreTMPBox1.text = "GlobalSocre: " + GlobalScore;

            /*COLOR CONTROL*/
            if (Box1LocalSocre < 100)
            {

                LocalScorepizzaBox1TMP.color = Color.red;

            }
            else if (Box1LocalSocre > 100)
            {

                LocalScorepizzaBox1TMP.color = Color.green;


            }


        }
        else
        {

            Box1LocalSocre = 0;

        }




        /*if Box 2 is in the air*/
        if ((velBox2.magnitude > 8) && (!Input.GetKey(KeyCode.Mouse0)))
        {
            Box2LocalSocre++;

            /*Boxes Camera control*/
            CamBox1.gameObject.SetActive(false);
            CamBox2.gameObject.SetActive(true);

            /*Players Camera control*/
            Player1CAM.gameObject.SetActive(false);
            Player2CAM.gameObject.SetActive(false);


            /*Box2 text control*/
            LocalScorepizzaBox2TMP.gameObject.SetActive(true);
            GlobalScoreTMPBox2.gameObject.SetActive(true);

            /*Players Text Control*/
            GlobalScoreTMPPlayer.gameObject.SetActive(false);
            GlobalScoreTextPlayer2.gameObject.SetActive(false);
            Plsyer1Contrls.gameObject.SetActive(false);
            Plsyer2Contrls.gameObject.SetActive(false);

           
            /*Color Changeing Text Method*/
            ChangeBoxScoreTextColor(Box2LocalSocre, GlobalScoreTMPBox2, LocalScorepizzaBox2TMP);
         
            GlobalScore += Box2LocalSocre / 100;

            /*Box2 Local and Global TMP*/
            LocalScorepizzaBox2TMP.text = "LocalSocre " + Box2LocalSocre;
            GlobalScoreTMPBox2.text = "GlobalSocre: " + GlobalScore;



        }
        else
        {

            Box2LocalSocre = 0;


        }


    }



    public void ChangeBoxScoreTextColor(int BoxlocalScore, TextMeshPro GlobalScoreTMPBox, TextMeshPro LocalScoreTMPBox)
    {

        if (BoxlocalScore < 100)
        {
            LocalScoreTMPBox.color = Color.red;

        }
        else if (BoxlocalScore > 100)
        {
            LocalScoreTMPBox.color = Color.green;
        }



    }


    void OnCollisionEnter(Collision collision)
    {
        // ADD THE OTHER BOUNDS


        if (collision.gameObject.tag == "Bounds") //&& vel.magnitude> pizzaSpeed)
        {

              /*Players Out of Bounds Messages*/
            if(player1GameObj.activeSelf ==true)
                StartCoroutine(ShowMessage(OutBoundsTextPlayerTMP, "OUT OF BOUNDS!", 2));
            if (player2GameObj.activeSelf == true)
                StartCoroutine(ShowMessage(OutBoundsTextPlayer2, "OUT OF BOUNDS!", 2));

            /*Box1 Global and Local TMP Contol*/
            GlobalScoreTMPBox1.gameObject.SetActive(false);
            LocalScorepizzaBox1TMP.gameObject.SetActive(false);

            /*Box2 Global and Local TMP Contol*/
            LocalScorepizzaBox2TMP.gameObject.SetActive(false);

            /*Player1 Global TMP Contol*/
            GlobalScoreTMPPlayer.gameObject.SetActive(true);



            /*Camera Contorl*/
            CamBox1.gameObject.SetActive(false);
            CamBox2.gameObject.SetActive(false);
            Player1CAM.gameObject.SetActive(true);

            Debug.Log("hit left bound");
            gameObject.transform.position = new Vector3(currentPosX, currentPosY, currentPosZ);
        }


        // if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "PizzaBox")
        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "PizzaBox" || collision.gameObject.tag == "Untagged")
        {
          //  player2GameObj.gameObject.SetActive(false);

            /*Box1 text Control */
            LocalScorepizzaBox1TMP.gameObject.SetActive(false);
            GlobalScoreTMPBox1.gameObject.SetActive(false);

            /*Box 2 text Control*/
            GlobalScoreTMPBox2.gameObject.SetActive(false);
            LocalScorepizzaBox2TMP.gameObject.SetActive(false);

            /*Player1 Global TMP Contol*/
            GlobalScoreTMPPlayer.gameObject.SetActive(true);
           // GlobalScoreTextPlayer2.gameObject.SetActive(true);

            /*if player2 is currently active*/
            if (player2GameObj.activeSelf == true)
            {
                /*Boxs Camera Control*/
                CamBox1.gameObject.SetActive(false);
                CamBox2.gameObject.SetActive(false);

                /*Player2 Control Camera Control*/
                Player2CAM.gameObject.SetActive(true);
                player2GameObj.gameObject.SetActive(true);
                Plsyer2Contrls.gameObject.SetActive(true);
                GlobalScoreTextPlayer2.gameObject.SetActive(true);

                /*Player1 Control Camera Control*/
                Player1CAM.gameObject.SetActive(false);
                player1GameObj.gameObject.SetActive(false);
                Plsyer1Contrls.gameObject.SetActive(false);
                GlobalScoreTMPPlayer.gameObject.SetActive(false);
                   


                //  pizzaBox1TextMesh.gameObject.SetActive(true);

            }
            /*if player1 is currently active*/
            if (player1GameObj.activeSelf == true)
            {
                /*Boxs Camera Control*/
                CamBox1.gameObject.SetActive(false);
                CamBox2.gameObject.SetActive(false);

            

                /*Player2 Control Camera Control*/
                Player2CAM.gameObject.SetActive(false);
                player2GameObj.gameObject.SetActive(false);
                Plsyer2Contrls.gameObject.SetActive(false);
                GlobalScoreTextPlayer2.gameObject.SetActive(false);

                /*Player1 Control Camera Control*/
                Player1CAM.gameObject.SetActive(true);
                player1GameObj.gameObject.SetActive(true);
                Plsyer1Contrls.gameObject.SetActive(true);
                GlobalScoreTMPPlayer.gameObject.SetActive(true);

                //pizzaBox2TextMesh.gameObject.SetActive(false);

            }
        }


    }







    /*Writing text on screen for a small duration of time*/
    IEnumerator ShowMessage(TextMeshPro Text, string message, float delay)
    {
        Text.text = message;
        Text.enabled = true;
        yield return new WaitForSeconds(delay);
        Text.enabled = false;
    }


    public static bool boxInAir()
    {
        Debug.Log("box is in the air");
        return true;
    }
}
    