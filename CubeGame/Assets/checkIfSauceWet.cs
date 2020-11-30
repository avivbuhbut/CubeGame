using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
public class checkIfSauceWet : MonoBehaviour
{

    public TextMeshPro SouceTMP;
    bool RainHitSauce;

    public RaycastHit hitDown;

    public RaycastHit hitUp;
    int counter = 0;
    public float TimeNotInRain;
    public bool SauceIsNotInRain;
    // Start is called before the first frame update
    public Vector3 Sauce100pScale;
    public Vector3 fillSauce;
    Vector3 scaleChangeSmaller;

    int counterPresent;

    void Start()
    {
        fillSauce = new Vector3(0.001f, 0.001f, 0.001f);
        Sauce100pScale = this.transform.localScale;
        scaleChangeSmaller = new Vector3(-0.001f, -0.001f, -0.001f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Physics.Raycast(this.transform.position, this.transform.TransformDirection(Vector3.down), out hitDown))
        {
            Debug.DrawRay(this.transform.position, this.transform.TransformDirection(Vector3.down) * hitDown.distance, Color.yellow);


        }

        if (Physics.Raycast(this.transform.position, this.transform.TransformDirection(Vector3.up), out hitUp))
        {
            Debug.DrawRay(this.transform.position, this.transform.TransformDirection(Vector3.up) * hitUp.distance, Color.yellow);
            // if (hit.transform.name != "Floor" && hit.transform.tag != "Bounds")
            //        this.gameObject.transform.GetComponent<Renderer>().material.DOColor(Color.white, 10f);
        }





        if (this.transform != null)
            if ((hitDown.transform.tag == "Floor" && hitUp.transform.tag != "Bounds"
           || hitDown.transform.tag != "Bounds" && hitUp.transform.tag == "Floor") &&
           this.transform.GetComponent<Rigidbody>().velocity.magnitude < 2 ||
           (hitDown.transform.tag == "CubeShifter" && hitUp.transform.tag == "CubeShifter")
           || (hitDown.transform.tag == "CubeShifter" && hitUp.transform.tag == "Floor")
                || (hitDown.transform.tag == "CubeShifter" && hitUp.transform.tag == "CubeShifter"))
            {

                if (this.transform.localScale.x < Sauce100pScale.x)
                {
                    this.transform.localScale += fillSauce;
                    showPrecentageSauceEcreasing();
                }

                SauceIsNotInRain = true;
                this.gameObject.transform.GetComponent<Renderer>().material.DOColor(Color.red, 10f);
            }








    }

    void OnParticleCollision(GameObject other)
    {




        if (other.gameObject.name == "RainFallParticleSystem")
        {


            if (this.transform.localScale.x > 0)
            {
                this.transform.localScale += scaleChangeSmaller;
                ShowPrecentageSauceDecreasing();
            }
            SauceIsNotInRain = false;
            this.gameObject.transform.GetComponent<Renderer>().material.DOColor(Color.blue, 10f);

        }



    }


    void showPrecentageSauceEcreasing()
    {

        /*Decresing presentage sauce*/



        //   StartCoroutine("ExampleCoroutine");

        if (transform.localScale.x >= 0.9f)
        {

            counterPresent = 90;
            SouceTMP.color = Color.yellow;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
        }

        else if (transform.localScale.x >= 0.8f)
        {
            counterPresent = 80;
            SouceTMP.color = Color.yellow;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
        }
        else if (transform.localScale.x >= 0.7f)
        {
            counterPresent = 70;
            SouceTMP.color = Color.yellow;
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
        if (transform.localScale.x == 1)
        {
            SouceTMP.color = Color.white;
            SouceTMP.text = "Pizza Sauce";
        }


    }

    void ShowPrecentageSauceDecreasing()
    {
        //   StartCoroutine("ExampleCoroutine");


        if (transform.localScale.x <= 0.4f)
        {

            counterPresent = 40;
            SouceTMP.color = Color.red;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
        }

        else if (transform.localScale.x <= 0.5f)
        {

            counterPresent = 50;
            SouceTMP.color = Color.red;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
        }
        else if (transform.localScale.x <= 0.6f)
        {

            counterPresent = 60;
            SouceTMP.color = Color.red;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";

        }

        else if (transform.localScale.x <= 0.7f)
        {

            counterPresent = 70;
            SouceTMP.color = Color.yellow;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";

        }


        else if (transform.localScale.x <= 0.8f)
        {

            counterPresent = 80;
            SouceTMP.color = Color.yellow;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";

        }
        else if (transform.localScale.x <= 0.9f)
        {

            counterPresent = 90;
            SouceTMP.color = Color.yellow;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";

        }

        else if ((transform.localScale.x > 0.9f) && (transform.localScale.x < 1))
        {
            SouceTMP.color = Color.yellow;
            SouceTMP.text = "Pizza Sauce ";
        }


        if (transform.localScale.x == 1)
        {
            SouceTMP.color = Color.white;
            SouceTMP.text = "Pizza Sauce";
        }

    }






}
