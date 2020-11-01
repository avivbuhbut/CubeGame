using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCountPlayer2 : MonoBehaviour
{



    public static int GlobalScore;
    public int localScore;

    float speed;

    /*Player2 Texts*/
    public Text GlobalScoreTextPlayer2;
    public Text LocalScorePlayer2;
    public Text OutBoundsTextPlayer2;


    RaycastHit hit = new RaycastHit();
    Vector3 vel;

    public GameObject pizzaBox;
    public Rigidbody rigidbodyPizzaBox;
    public Transform transformPizzaBox;
    // float pizzaSpeed = 20f;
    float currentPosX = 0;
    float currentPosY = 0;
    float currentPosZ = 0;


    
    void Start()
    {

        OutBoundsTextPlayer2.enabled = false;
        LocalScorePlayer2.enabled = false;


        //Text sets your text to say this message
        //  m_MyText.text = "This is my text";

        speed = rigidbodyPizzaBox.velocity.magnitude;
        currentPosX = transformPizzaBox.position.x;
        currentPosY = transformPizzaBox.position.y;
        currentPosZ = transformPizzaBox.position.z;


      
    }

    void Update()
    {

     
        LocalScorePlayer2.enabled = false;

        GlobalScoreTextPlayer2.text = "Total Score: " + GlobalScore;

        vel = rigidbodyPizzaBox.velocity;


        //Press the space key to change the Text message
        /*
        if (Input.GetKey(KeyCode.Space))
        {
            m_MyText.text = "My text has now changed.";
        }*/


        /*checks if the box is in the air - if it is the score goes up*/
        if ((vel.magnitude > 5) && (!Input.GetKey(KeyCode.Mouse0)))
        {


            LocalScorePlayer2.enabled = true;

            LocalScorePlayer2.text = "Score: " + localScore;

           
            localScore++;

            if (localScore < 100)
                LocalScorePlayer2.color = Color.red;
            else if (localScore > 100)
            {
                boxInAir();
                LocalScorePlayer2.color = Color.green;
            }


        }
        else
        {
            localScore = 0;
        }

        //player can touch each pizza box once !!! add code!


        if (localScore == 0)
            LocalScorePlayer2.color = Color.red;




        GlobalScore += localScore / 100;


     
    }






    void OnCollisionEnter(Collision collision)
    {
        // ADD THE OTHER BOUNDS


        if (collision.gameObject.tag== "Bounds") //&& vel.magnitude> pizzaSpeed)
        {



            StartCoroutine(ShowMessage(OutBoundsTextPlayer2, "OUT OF BOUNDS!", 2));
            Debug.Log("hit left bound");
            pizzaBox.transform.position = new Vector3(currentPosX, currentPosY, currentPosZ);
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
