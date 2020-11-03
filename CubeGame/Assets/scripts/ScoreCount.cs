using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreCount : MonoBehaviour
{

    public Camera Player1CAM;
    public Camera Player2CAM;

    public GameObject player1GameObj;
    public GameObject player2GameObj;






    public static int GlobalScore;
    public static int localScore;



    /*Player2 Texts*/
    public Text GlobalScoreTextPlayer2;
    public Text LocalScorePlayer2;
    public Text OutBoundsTextPlayer2;



    /*Player texts*/
    public TextMeshPro GlobalScoreTMPPlayer;
 
    public TextMeshPro OutBoundsTextPlayerTMP;


    public RaycastHit hit;


    /*Pizza Box1*/
    public Vector3 velBox1;
    public Camera CamBox1;
    public Rigidbody rigidbodyBox1;
    public Transform transformBox1;
    public TextMeshPro GlobalScoreTMPBox1;
    public TextMeshPro LocalScorepizzaBox1TMP;
    public float speedBox1;


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




    // float pizzaSpeed = 20f;

    void Start()
    {





        hit = new RaycastHit();
        OutBoundsTextPlayerTMP.enabled = false;



        OutBoundsTextPlayer2.enabled = false;
        LocalScorePlayer2.enabled = false;

        //Text sets your text to say this message
        //  m_MyText.text = "This is my text";

        /*pizza Box1 speed*/
        speedBox1 = rigidbodyBox1.velocity.magnitude;

        currentPosX = transform.position.x;
        currentPosY = transform.position.y;
        currentPosZ = transform.position.z;



        CamBox1.gameObject.SetActive(false);
        CamBox2.gameObject.SetActive(false);

        player2GameObj.gameObject.SetActive(false);
        Player2CAM.gameObject.SetActive(false);



        /*pizza text boxTMP*/
        GlobalScoreTMPBox1.gameObject.SetActive(false);
        LocalScorepizzaBox1TMP.gameObject.SetActive(false);

        /*Player1 text TMP*/
        GlobalScoreTMPPlayer.gameObject.SetActive(true);


        /*pizzaBox2*/
        speedBox2 = rigidbodyBox2.velocity.magnitude;
        GlobalScoreTMPBox2.gameObject.SetActive(false);
        LocalScorepizzaBox2TMP.gameObject.SetActive(false);
    }

    void Update()
    {



     
        // LocalScorePlayer2.enabled = false;





        GlobalScoreTextPlayer2.text = "Total Score: " + GlobalScore;

        GlobalScoreTMPPlayer.text = "Total Score: " + GlobalScore;
        GlobalScoreTMPBox1.text = "Total Score: " + GlobalScore;

        /*Box1 velocity*/
        velBox1 = rigidbodyBox1.velocity;


        /*Box2 velocity*/
        velBox2 = rigidbodyBox2.velocity;

      




        /*if Box 1 is in the air*/
        if ((velBox1.magnitude > 8) && (!Input.GetKey(KeyCode.Mouse0)))
        {


            GlobalScoreTMPPlayer.gameObject.SetActive(false);

            GlobalScoreTMPBox1.gameObject.SetActive(true);

            LocalScorepizzaBox1TMP.gameObject.SetActive(true);
            CamBox1.gameObject.SetActive(true);
            Player1CAM.gameObject.SetActive(false);
            Player2CAM.gameObject.SetActive(false);


        
            LocalScorePlayer2.enabled = true;

            //LocalScorePlayerTMP.text = "Score: " + localScore;


            LocalScorepizzaBox1TMP.text = "Local Score: " + localScore;


            localScore++;


            if (localScore < 100)
            {
             
                LocalScorePlayer2.color = Color.red;

                LocalScorepizzaBox1TMP.color = Color.red;



            }
            else if (localScore > 100)
            {

              
                LocalScorePlayer2.color = Color.green;

                LocalScorepizzaBox1TMP.color = Color.green;


            }



        }
        else
        {

            localScore = 0;

        }

        Debug.Log(localScore);


        /*if Box 2 is in the air*/
        if ((velBox2.magnitude > 8) && (!Input.GetKey(KeyCode.Mouse0)))
        {

            /*camera control*/
            CamBox1.gameObject.SetActive(false);
            CamBox2.gameObject.SetActive(true);
            Player1CAM.gameObject.SetActive(false);
            Player2CAM.gameObject.SetActive(false);


            /*text control*/
            LocalScorepizzaBox2TMP.gameObject.SetActive(true);
            GlobalScoreTMPPlayer.gameObject.SetActive(false);
            GlobalScoreTMPBox2.gameObject.SetActive(true);


            LocalScorepizzaBox2TMP.text = "Local Score: " + localScore;

            localScore++;

       


            if (localScore < 100)
            {




            }
            else if (localScore > 100)
            {




            }
            else
            {

                localScore = 0;

            }
        }



        GlobalScore += localScore / 100;




    }





    void OnCollisionEnter(Collision collision)
    {
        // ADD THE OTHER BOUNDS


        if (collision.gameObject.tag == "Bounds") //&& vel.magnitude> pizzaSpeed)
        {


            StartCoroutine(ShowMessage(OutBoundsTextPlayerTMP, "OUT OF BOUNDS!", 2));
            StartCoroutine(ShowMessage(OutBoundsTextPlayerTMP, "OUT OF BOUNDS!", 2));
       
            LocalScorePlayer2.enabled = false;
            GlobalScoreTMPBox1.gameObject.SetActive(false);
            LocalScorepizzaBox1TMP.gameObject.SetActive(false);
            LocalScorepizzaBox2TMP.gameObject.SetActive(false);
            GlobalScoreTMPPlayer.gameObject.SetActive(true);
            CamBox1.gameObject.SetActive(false);
            CamBox2.gameObject.SetActive(false);
            Player1CAM.gameObject.SetActive(true);

            Debug.Log("hit left bound");
            gameObject.transform.position = new Vector3(currentPosX, currentPosY, currentPosZ);
        }


        // if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "PizzaBox")
        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "PizzaBox" || collision.gameObject.tag == "Untagged")
        {
            player2GameObj.gameObject.SetActive(false);
            LocalScorepizzaBox1TMP.gameObject.SetActive(false);
            LocalScorepizzaBox2TMP.gameObject.SetActive(false);

          
            LocalScorePlayer2.enabled = false;
            GlobalScoreTMPBox1.gameObject.SetActive(false);

            GlobalScoreTMPPlayer.gameObject.SetActive(true);


            if (player2GameObj == true)
            {
                CamBox1.gameObject.SetActive(false);
                CamBox2.gameObject.SetActive(false);
                Player1CAM.gameObject.SetActive(true);
                Player2CAM.gameObject.SetActive(false);
                player1GameObj.gameObject.SetActive(true);
                player2GameObj.gameObject.SetActive(false);
                //  pizzaBox1TextMesh.gameObject.SetActive(true);

            }
            else
            {
                CamBox1.gameObject.SetActive(false);
                CamBox2.gameObject.SetActive(false);
                Player1CAM.gameObject.SetActive(false);
                Player2CAM.gameObject.SetActive(true);
                player1GameObj.gameObject.SetActive(false);
                player2GameObj.gameObject.SetActive(true);
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