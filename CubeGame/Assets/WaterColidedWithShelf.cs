using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WaterColidedWithShelf : MonoBehaviour
{




    public TextMeshPro WaterTMP;
    public bool WaterColidesWithEnemy;
    public bool ColidedWaterShelf;
    
    float LocalSizeX;
    int counterPresent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        /*Decresing presentage sauce*/
        if (WaterColidesWithEnemy && (!ColidedWaterShelf))
        {


            //   StartCoroutine("ExampleCoroutine");


            if (transform.localScale.x >= 0.9f)
            {
                Debug.Log("90");
                counterPresent = 90;
                WaterTMP.color = Color.red;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";
            }

            else if (transform.localScale.x >= 0.8f)
            {
                counterPresent = 80;
                WaterTMP.color = Color.red;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";
            }
            else if (transform.localScale.x >= 0.7f)
            {
                counterPresent = 70;
                WaterTMP.color = Color.red;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";
            }

            else if (transform.localScale.x >= 0.6f)
            {
                counterPresent = 60;
                WaterTMP.color = Color.red;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";
            }

            else if (transform.localScale.x >= 0.5f)
            {
                counterPresent = 50;
                WaterTMP.color = Color.red;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";
            }
            else if (transform.localScale.x >= 0.4f)
            {
                counterPresent = 40;
                WaterTMP.color = Color.red;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";
            }




        }



        /*incresing presentage sauce*/
        if (ColidedWaterShelf)
        {


            //   StartCoroutine("ExampleCoroutine");


            if (transform.localScale.x <= 0.4f)
            {

                counterPresent = 40;
                WaterTMP.color = Color.green;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";
            }

            else if (transform.localScale.x <= 0.5f)
            {

                counterPresent = 50;
                WaterTMP.color = Color.green;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";
            }
            else if (transform.localScale.x <= 0.6f)
            {

                counterPresent = 60;
                WaterTMP.color = Color.green;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";

            }

            else if (transform.localScale.x <= 0.7f)
            {

                counterPresent = 70;
                WaterTMP.color = Color.green;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";

            }


            else if (transform.localScale.x <= 0.8f)
            {

                counterPresent = 80;
                WaterTMP.color = Color.green;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";

            }
            else if (transform.localScale.x <= 0.9f)
            {

                counterPresent = 90;
                WaterTMP.color = Color.green;
                WaterTMP.text = "Pizza Sauce " + counterPresent + "%";

            }


            if (transform.localScale.x == 1)
            {
                WaterTMP.color = Color.white;
                WaterTMP.text = "Pizza Sauce";
            }
        }

        /*if the sauce is on the shelf*/
        /*
        if (transform.GetComponent<SauceColided>().SauceHitSauceShelff && transform.transform.localScale != GameObject.Find("fillPizzaSauce").transform.GetComponent<fillPizzaSauce>().PizzaSauce100pScale)
        {
            //StartCoroutine("ExampleCoroutine");

            counterPresent = counterPresent + 10;
            SouceTMP.color = Color.green;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
        }//else
      //  {
          //  SouceTMP.color = Color.white;
         //   SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
       // }*/



    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.name == "CubeEnemy"|| collision.gameObject.transform.name == "CubeEnemy(Clone)")
        {
            WaterColidesWithEnemy = true;

        }


        if (collision.gameObject.transform.name == "WaterShelf")
        {
            ColidedWaterShelf = true;

        }
    }



}

