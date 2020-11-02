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

    public Camera PizzaCam;
    public GameObject PizzaBox;

   
    public static int GlobalScore;
    public  int localScore;
    
   public float speed;

    /*Player2 Texts*/
    public Text GlobalScoreTextPlayer2;
    public Text LocalScorePlayer2;
    public Text OutBoundsTextPlayer2;

  //  public Text boxText;

    /*Player texts*/
    public Text GlobalScoreTextPlayer;
    public Text LocalScorePlayer;
    public Text OutBoundsTextPlayer;


    public TextMeshPro pizzaBoxTextMesh;

    public RaycastHit hit;
    public Vector3 vel;

    public Rigidbody rigidbody;
    public Transform transform;
    // float pizzaSpeed = 20f;
    public float currentPosX ;
    public float currentPosY ;
    public float currentPosZ ;
    void Start()
    {
      //  boxText.enabled = false;
       pizzaBoxTextMesh.gameObject.SetActive(true);

        hit = new RaycastHit();
        OutBoundsTextPlayer.enabled =false;
        LocalScorePlayer.enabled = false;

        OutBoundsTextPlayer2.enabled = false;
        LocalScorePlayer2.enabled = false;


        //Text sets your text to say this message
        //  m_MyText.text = "This is my text";

        speed = rigidbody.velocity.magnitude;
        currentPosX = transform.position.x;
        currentPosY = transform.position.y;
        currentPosZ = transform.position.z;

        PizzaCam.gameObject.SetActive(false);
        player2GameObj.gameObject.SetActive(false);
        Player2CAM.gameObject.SetActive(false);


    }

    void Update()
    {



        //   LocalScorePlayer.enabled = false;
        // LocalScorePlayer2.enabled = false;



        
        GlobalScoreTextPlayer.text = "Total Score: " + GlobalScore;
        GlobalScoreTextPlayer2.text = "Total Score: " + GlobalScore;

        vel = rigidbody.velocity;

       
        //Press the space key to change the Text message
        /*
        if (Input.GetKey(KeyCode.Space))
        {
            m_MyText.text = "My text has now changed.";
        }*/


        /*checks if the box is in the air - if it is the score goes up*/
        if ((vel.magnitude > 8) && (!Input.GetKey(KeyCode.Mouse0)))
        {

           // boxText.enabled = true;
            pizzaBoxTextMesh.gameObject.SetActive(true);

           PizzaCam.gameObject.SetActive(true);
            Player1CAM.gameObject.SetActive(false);
            Player2CAM.gameObject.SetActive(false);
           

            LocalScorePlayer.enabled = true;
            LocalScorePlayer2.enabled = true;

            LocalScorePlayer.text = "Score: " + localScore;

            pizzaBoxTextMesh.text = "Local Score: " + localScore;

            localScore++;

      
          
          


            if (localScore < 100)
            {
                LocalScorePlayer.color = Color.red;
                LocalScorePlayer2.color = Color.red;
                pizzaBoxTextMesh.color = Color.red;
            }
            else if (localScore > 100)
            {
                boxInAir();
                LocalScorePlayer.color = Color.green;
                LocalScorePlayer2.color = Color.green;
                pizzaBoxTextMesh.color = Color.green;
            }

            if (localScore == 0)
            {
                LocalScorePlayer.color = Color.red;
                LocalScorePlayer2.color = Color.red;
            }


            //pizzaBoxTextMesh.gameObject.SetActive(false);
        }
        else
        {
            localScore = 0;
        }

        //player can touch each pizza box once !!! add code!
     //   boxText.enabled = false;






        GlobalScore += localScore/100;



       
    }


   



    void OnCollisionEnter(Collision collision)
    {
        // ADD THE OTHER BOUNDS


        if (collision.gameObject.tag == "Bounds") //&& vel.magnitude> pizzaSpeed)
        {

           
            StartCoroutine(ShowMessage(OutBoundsTextPlayer, "OUT OF BOUNDS!", 2));
            StartCoroutine(ShowMessage(OutBoundsTextPlayer2, "OUT OF BOUNDS!", 2));
            LocalScorePlayer.enabled = false;
            LocalScorePlayer2.enabled = false;
            Debug.Log("hit left bound");
            gameObject.transform.position = new Vector3(currentPosX, currentPosY, currentPosZ);
        }


        // if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "PizzaBox")
        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "PizzaBox" || collision.gameObject.tag == "Untagged" )
        {
            player2GameObj.gameObject.SetActive(false);


            LocalScorePlayer.enabled = false;
            LocalScorePlayer2.enabled = false;

            if (player2GameObj == true)
            {
                PizzaCam.gameObject.SetActive(false);
                Player1CAM.gameObject.SetActive(true);
                Player2CAM.gameObject.SetActive(false);
                player1GameObj.gameObject.SetActive(true);
                player2GameObj.gameObject.SetActive(false);
            }
            else
            {
                PizzaCam.gameObject.SetActive(false);
                Player1CAM.gameObject.SetActive(false);
                Player2CAM.gameObject.SetActive(true);
                player1GameObj.gameObject.SetActive(false);
                player2GameObj.gameObject.SetActive(true);
            }
        }



    }





    /*Writing text on screen for a small duration of time*/
    IEnumerator ShowMessage(Text Text, string message, float delay)
    {
        Text.text = message;
        Text.enabled = true;
        yield return new WaitForSeconds(delay);
        Text.enabled = false;
    }


    public static bool boxInAir()
    {
        return true;
    }
}
