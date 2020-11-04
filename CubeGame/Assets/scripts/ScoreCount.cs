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
    public int localScore;



    /*Player2 Texts*/
    public TextMeshPro GlobalScoreTextPlayer2;
    public TextMeshPro OutBoundsTextPlayer2;



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



    // float pizzaSpeed = 20f;

    void Start()
    {





        hit = new RaycastHit();
        OutBoundsTextPlayerTMP.enabled = false;
        OutBoundsTextPlayer2.enabled = false;



        OutBoundsTextPlayer2.enabled = false;

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

        /*Player2 text TMP*/
        GlobalScoreTextPlayer2.gameObject.SetActive(true);


        /*pizzaBox2*/
        speedBox2 = rigidbodyBox2.velocity.magnitude;
        GlobalScoreTMPBox2.gameObject.SetActive(false);
        LocalScorepizzaBox2TMP.gameObject.SetActive(false);
    }

    void Update()
    {


        GlobalScoreTextPlayer2.text = "Total Score: " + GlobalScore;

        GlobalScoreTMPPlayer.text = "Total Score: " + GlobalScore;
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

            /*Box Text Control*/
            GlobalScoreTMPBox1.gameObject.SetActive(true);
            LocalScorepizzaBox1TMP.gameObject.SetActive(true);

            /*Cameras Control*/
            CamBox1.gameObject.SetActive(true);
            Player1CAM.gameObject.SetActive(false);
            Player2CAM.gameObject.SetActive(false);


            //LocalScorePlayerTMP.text = "Score: " + localScore;
            GlobalScore += Box1LocalSocre / 100;

            LocalScorepizzaBox1TMP.text = "LocalSocre " + Box1LocalSocre;
            GlobalScoreTMPBox1.text = "GlobalSocre: " + GlobalScore;


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
            /*camera control*/
            CamBox1.gameObject.SetActive(false);
            CamBox2.gameObject.SetActive(true);
            Player1CAM.gameObject.SetActive(false);
            Player2CAM.gameObject.SetActive(false);


            /*text control*/
            LocalScorepizzaBox2TMP.gameObject.SetActive(true);
            GlobalScoreTMPPlayer.gameObject.SetActive(false);
            GlobalScoreTextPlayer2.gameObject.SetActive(false);
            GlobalScoreTMPBox2.gameObject.SetActive(true);

            ChangeBoxScoreTextColor(Box2LocalSocre, GlobalScoreTMPBox2, LocalScorepizzaBox2TMP);
         
            GlobalScore += Box2LocalSocre / 100;

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


            StartCoroutine(ShowMessage(OutBoundsTextPlayerTMP, "OUT OF BOUNDS!", 2));
            StartCoroutine(ShowMessage(OutBoundsTextPlayer2, "OUT OF BOUNDS!", 2));


            GlobalScoreTMPBox1.gameObject.SetActive(false);
            LocalScorepizzaBox1TMP.gameObject.SetActive(false);
            LocalScorepizzaBox2TMP.gameObject.SetActive(false);
            GlobalScoreTMPPlayer.gameObject.SetActive(true);
            GlobalScoreTextPlayer2.gameObject.SetActive(true);
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

            /*Box1 text */
            LocalScorepizzaBox1TMP.gameObject.SetActive(false);
            GlobalScoreTMPBox1.gameObject.SetActive(false);

            /*Box 2 text*/
            GlobalScoreTMPBox2.gameObject.SetActive(false);
            LocalScorepizzaBox2TMP.gameObject.SetActive(false);


            GlobalScoreTMPPlayer.gameObject.SetActive(true);
            GlobalScoreTextPlayer2.gameObject.SetActive(true);


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
    