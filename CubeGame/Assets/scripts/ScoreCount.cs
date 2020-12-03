using System.Collections;
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
    public GameObject Box1;
    public Rigidbody rigidbodyBox1;
    public Transform transformBox1;
    public TextMeshPro GlobalScoreTMPBox1;
    public TextMeshPro LocalScorepizzaBox1TMP;
    public float speedBox1;
    public int Box1LocalSocre;
    public int Box1GlobalSocre;
    public static int Box1currentGreenPoints;
    public bool pizzaBox1InAir = false;


    public float currentPosX;
    public float currentPosY;
    public float currentPosZ;


    /*Pizza Box2*/
    public Vector3 velBox2;
    public Camera CamBox2;
    public GameObject Box2;
    public Rigidbody rigidbodyBox2;
    public Transform transformBox2;
    public TextMeshPro GlobalScoreTMPBox2;
    public TextMeshPro LocalScorepizzaBox2TMP;
    public float speedBox2;
    public int Box2LocalSocre;
    public int Box2GlobalSocre;
    public static int Box2currentGreenPoints;
    public bool pizzaBox2InAir = false;


    /*Pizza Box3*/
    public Vector3 velBox3;
    public Camera CamBox3;
    public GameObject Box3;
    public Rigidbody rigidbodyBox3;
    public Transform transformBox3;
    public TextMeshPro GlobalScoreTMPBox3;
    public TextMeshPro LocalScorepizzaBox3TMP;
    public float speedBox3;
    public int Box3LocalSocre;
    public int Box3GlobalSocre;
    public static int Box3currentGreenPoints;
    public bool pizzaBox3InAir = false;

    public RaycastHit hit;

 



    void Start()
    {
        Box3.SetActive(false);
        Box2.SetActive(false);
        

        hit = new RaycastHit();


        /*pizza Box1 speed && transform*/
        speedBox1 = rigidbodyBox1.velocity.magnitude;
        currentPosX = transform.position.x;
        currentPosY = transform.position.y;
        currentPosZ = transform.position.z;



        /*Cameras*/
        CamBox1.gameObject.SetActive(false);





        /*Player1 text TMP*/

        OutBoundsTextPlayerTMP.enabled = false;


        /*Player2 text TMP*/
        OutBoundsTextPlayer2.enabled = false;

        /*Player2 active*/
       player2GameObj.gameObject.SetActive(false);
        



        /*pizzaBox2*/
        speedBox2 = rigidbodyBox2.velocity.magnitude;
        GlobalScoreTMPBox2.gameObject.SetActive(false);
        LocalScorepizzaBox2TMP.gameObject.SetActive(false);

        /*pizzaBox2*/
        speedBox3 = rigidbodyBox3.velocity.magnitude;
        GlobalScoreTMPBox3.gameObject.SetActive(false);
        LocalScorepizzaBox3TMP.gameObject.SetActive(false);
    }

    void Update()
    {



        /*Global Score Player1*/
     //   GlobalScoreTMPPlayer.text = "Total Score: " + GlobalScore;


        /*Global Score Player2*/
        //GlobalScoreTextPlayer2.text = "Total Score: " + GlobalScore;

        /*Box1 velocity*/
        velBox1 = rigidbodyBox1.velocity;


        /*Box2 velocity*/
        velBox2 = rigidbodyBox2.velocity;

        /*Box3 velocity*/
        velBox3 = rigidbodyBox3.velocity;


        /*Box 1 is in the air GENERAL*/
        if ((velBox1.magnitude > 2) && (!Input.GetKey(KeyCode.Mouse0)))
            pizzaBox1InAir = true;
        else
            pizzaBox1InAir = false;


        /*if Box 1 is in the air*/
        if ((velBox1.magnitude > 8) && (!Input.GetKey(KeyCode.Mouse0)))
        {

            // tell the main camera to follow th pizza and when the pizza lend
            //come back to player

            /*Cameras Control*/
            //CamBox1.gameObject.SetActive(true);
           // Player1CAM.gameObject.SetActive(false);
        }
        else
        {

           // CamBox1.gameObject.SetActive(false);
           // Player1CAM.gameObject.SetActive(true);
            Box1currentGreenPoints = 0;
            Box1LocalSocre = 0;

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
            if (player1GameObj.activeSelf == true)
            {
     

                StartCoroutine(ShowMessage(OutBoundsTextPlayerTMP, "OUT OF BOUNDS!", 2));
            }
       

     



            /*Camera Contorl*/
            CamBox1.gameObject.SetActive(false);
            Player1CAM.gameObject.SetActive(true);

            Debug.Log("hit left bound");
            gameObject.transform.position = new Vector3(currentPosX, currentPosY, currentPosZ);
        }


        // if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "PizzaBox")
        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "PizzaBox" || collision.gameObject.tag == "PlateBoundsP2" || collision.gameObject.tag == "Untagged" || collision.gameObject.tag == "FinishLineCube"
            || collision.gameObject.tag == "CubeDistraction" || collision.gameObject.tag == "DoughAndSauce" || collision.gameObject.tag == "Sauce" || collision.gameObject.tag == "Water" || collision.gameObject.tag == "HammerCube"
            || collision.gameObject.tag == "Basket1" || collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player2" || collision.gameObject.tag == "CubeEnemySauce") ;

        {
       

       
            /*if player1 is currently active*/
            if (player1GameObj.activeSelf == true)
            {
                /*Boxs Camera Control*/
                CamBox1.gameObject.SetActive(false);



                /*Player1 Control Camera Control*/
                Player1CAM.gameObject.SetActive(true);
       

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
    