using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{



    public static int GlobalScore;
    public int localScore;
    
    float speed;

    public Text YourScoreText;
    public Text myText;
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
        //Text sets your text to say this message
        //  m_MyText.text = "This is my text";

        speed = rigidbody.velocity.magnitude;
        currentPosX = transform.position.x;
        currentPosY = transform.position.y;
        currentPosZ = transform.position.z;

    }

    void Update()
    {

       

        myText.text = "Score: " + localScore;
        YourScoreText.text = "Your Score: " + GlobalScore;

        vel = rigidbody.velocity;

       
        //Press the space key to change the Text message
        /*
        if (Input.GetKey(KeyCode.Space))
        {
            m_MyText.text = "My text has now changed.";
        }*/

        if ((vel.magnitude > 5) && (!Input.GetKey(KeyCode.Mouse0)))
        {
   
            localScore++;
        
        }
        else
        {
            localScore = 0;
        }

        //add code if a player recatch the box the score turns down in lots of ponts


        
        GlobalScore += localScore;

        
    }


   



    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Left Bound") //&& vel.magnitude> pizzaSpeed)
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
}
