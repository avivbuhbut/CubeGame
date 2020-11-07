using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collisions : MonoBehaviour
{

    public ScoreCount ScoreCountScripl;


    public Camera Player1Cam;
    public GameObject Player1GamObj;
    public TextMeshPro Player1GlobalScoreTMP;
    public TextMeshPro Player1ControlsTMP;


    public Camera Player2Cam;
    public GameObject Player2GamObj;
    public TextMeshPro Player2GlobalScoreTMP;
    public TextMeshPro Player2ControlsTMP;




    public Transform PizzaBox3Trans;
    public GameObject PizzaBox3GamObj;
    public Camera PizzaBox3Cam;
    public TextMeshPro PizzaBox3GlobalScore;
    public TextMeshPro PizzaBox3LocalScore;
    public float currentPosX1;
    public float currentPosY1;
    public float currentPosZ1;
    public ScoreCount scoreCount;

    // Start is called before the first frame update
    void Start()
    {
        currentPosX1 = transform.position.x;
        currentPosY1 = transform.position.y;
        currentPosZ1 = transform.position.z;
        GameObject Box2GamObj = GameObject.Find("PizzaBOX2");
         scoreCount = Box2GamObj.GetComponent<ScoreCount>();
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnCollisionEnter(Collision collision)
    {
        // ADD THE OTHER BOUNDS







        if (collision.gameObject.tag == "Bounds") //&& vel.magnitude> pizzaSpeed)
        {
            if (Player1GamObj.activeSelf == true)
            {
                PizzaBox3Cam.gameObject.SetActive(false);
                Player1Cam.gameObject.SetActive(true);
                gameObject.transform.position = new Vector3(currentPosX1, currentPosY1, currentPosZ1);
                Player1GlobalScoreTMP.gameObject.SetActive(true);
                Player1ControlsTMP.gameObject.SetActive(true);
            }

            if (Player2GamObj.activeSelf == true)
            {
                PizzaBox3Cam.gameObject.SetActive(false);
                Player2Cam.gameObject.SetActive(true);
                gameObject.transform.position = new Vector3(currentPosX1, currentPosY1, currentPosZ1);
                Player2GlobalScoreTMP.gameObject.SetActive(true);
                Player2ControlsTMP.gameObject.SetActive(true);
            }


        }



        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "PizzaBox" || collision.gameObject.tag == "PlateBoundsP2" || collision.gameObject.tag == "Untagged")
        {
            if (Player1GamObj.activeSelf == true)
            {
                PizzaBox3Cam.gameObject.SetActive(false);
                Player1Cam.gameObject.SetActive(true);
                PizzaBox3GlobalScore.gameObject.SetActive(false);
                PizzaBox3LocalScore.gameObject.SetActive(false);
                Player1GlobalScoreTMP.gameObject.SetActive(true);
                Player1ControlsTMP.gameObject.SetActive(true);

            }

            if (Player2GamObj.activeSelf == true)
            {
                PizzaBox3Cam.gameObject.SetActive(false);
                Player2Cam.gameObject.SetActive(true);
                PizzaBox3GlobalScore.gameObject.SetActive(false);
                PizzaBox3LocalScore.gameObject.SetActive(false);
                Player2GlobalScoreTMP.gameObject.SetActive(true);
                Player2ControlsTMP.gameObject.SetActive(true);

            }



        }
    }

}
