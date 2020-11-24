using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowPrecentageShrink : MonoBehaviour
{

    public TextMeshPro SouceTMP;
    public bool ColidesWithEnemy;
    public bool ColidedSauceShelf;
    float LocalSizeX;
    int counterPresent ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        /*Decresing presentage sauce*/
        if (ColidesWithEnemy && (!ColidedSauceShelf))
        {


            //   StartCoroutine("ExampleCoroutine");


            if (transform.localScale.x >= 0.9f)
            {

                counterPresent = 90;
                SouceTMP.color = Color.red;
                SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
            }

            else if (transform.localScale.x >= 0.8f)
            {
                counterPresent = 80;
                SouceTMP.color = Color.red;
                SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
            }
            else if (transform.localScale.x >= 0.7f)
            {
                counterPresent = 70;
                SouceTMP.color = Color.red;
                SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
            }

            else if (transform.localScale.x >= 0.6f)
            {
                counterPresent = 60;
                SouceTMP.color = Color.red;
                SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
            }

            else if (transform.localScale.x >= 0.5f)
            {
                counterPresent = 50;
                SouceTMP.color = Color.red;
                SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
            }
            else if (transform.localScale.x >= 0.4f)
            {
                counterPresent = 40;
                SouceTMP.color = Color.red;
                SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
            }




        }



            /*incresing presentage sauce*/
            if (ColidedSauceShelf)
            {


                //   StartCoroutine("ExampleCoroutine");


                if (transform.localScale.x <= 0.4f)
                {

                    counterPresent = 40;
                    SouceTMP.color = Color.green;
                    SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
                }

                else if (transform.localScale.x <= 0.5f)
                {

                    counterPresent = 50;
                    SouceTMP.color = Color.green;
                    SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
                }
                else if (transform.localScale.x <= 0.6f)
                {

                    counterPresent = 60;
                    SouceTMP.color = Color.green;
                    SouceTMP.text = "Pizza Sauce " + counterPresent + "%";

                }

                else if (transform.localScale.x <= 0.7f)
                {

                    counterPresent = 70;
                    SouceTMP.color = Color.green;
                    SouceTMP.text = "Pizza Sauce " + counterPresent + "%";

                }


                else if (transform.localScale.x <= 0.8f)
                {

                    counterPresent = 80;
                    SouceTMP.color = Color.green;
                    SouceTMP.text = "Pizza Sauce " + counterPresent + "%";

                }
                else if (transform.localScale.x <= 0.9f)
                {

                    counterPresent = 90;
                    SouceTMP.color = Color.green;
                    SouceTMP.text = "Pizza Sauce " + counterPresent + "%";

                }


            if (transform.localScale.x == 1) {
                SouceTMP.color = Color.white;
                SouceTMP.text = "Pizza Sauce";
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
            if (collision.gameObject.transform.name == "CubeEnemySauce" || collision.gameObject.transform.name == "CubeEnemySauce(Clone)")
            {
                ColidesWithEnemy = true;

            }


            if (collision.gameObject.transform.name == "SauceShelf")
            {
                ColidedSauceShelf = true;

            }
        }


    
    }
