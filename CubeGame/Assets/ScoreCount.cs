using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{



    public static int GlobalScore;
    public int localScore;
    
    float speed;

    public Text GlobalScoreText;
    public Text LocalScore;
    public Text OutBoundsText;

    RaycastHit hit = new RaycastHit();
    Vector3 vel;

    public Rigidbody rigidbody;
    public Transform transform;
    // float pizzaSpeed = 20f;
    float currentPosX = 0;
    float currentPosY = 0;
    float currentPosZ = 0;
    void Start()
    {
        OutBoundsText.enabled =false;
        LocalScore.enabled = true;
        //Text sets your text to say this message
        //  m_MyText.text = "This is my text";

        speed = rigidbody.velocity.magnitude;
        currentPosX = transform.position.x;
        currentPosY = transform.position.y;
        currentPosZ = transform.position.z;

       

    }

    void Update()
    {


        LocalScore.enabled = false;

        GlobalScoreText.text = "Total Score: " + GlobalScore;

        vel = rigidbody.velocity;

       
        //Press the space key to change the Text message
        /*
        if (Input.GetKey(KeyCode.Space))
        {
            m_MyText.text = "My text has now changed.";
        }*/


        /*checks if the box is in the air - if it is the score goes up*/
        if ((vel.magnitude > 5) && (!Input.GetKey(KeyCode.Mouse0)))
        {


            LocalScore.enabled = true;

            LocalScore.text = "Score: " + localScore;

            Debug.Log(localScore);
            localScore++;

            if (localScore < 100)
                LocalScore.color = Color.red;
            else if (localScore > 100)
            {
                boxInAir();
                LocalScore.color = Color.green;
            }
            

        }
        else
        {
            localScore = 0;
        }

        //player can touch each pizza box once !!! add code!


             if (localScore == 0)
                LocalScore.color = Color.red;




            GlobalScore += localScore/100;

       
    }


   



    void OnCollisionEnter(Collision collision)
    {
        // ADD THE OTHER BOUNDS


        if (collision.gameObject.tag == "Bounds") //&& vel.magnitude> pizzaSpeed)
        {


            StartCoroutine(ShowMessage(OutBoundsText, "OUT OF BOUNDS!", 2));
            Debug.Log("hit left bound");
            gameObject.transform.position = new Vector3(currentPosX, currentPosY, currentPosZ);
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
