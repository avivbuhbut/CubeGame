using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowPrecentageShrink : MonoBehaviour
{

    public TextMeshPro SouceTMP;
    public bool ColidesWithEnemy;
    float TimeTemp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*if the sauce is currently colides with the enemy*/
        if (ColidesWithEnemy)
        {
            TimeTemp += Time.time-0.3f;
            Debug.Log("Time.deltaTime " + Time.time);
            //   StartCoroutine("ExampleCoroutine");
          if(Time.time  == TimeTemp )
            counterPresent += counterPresent-10;
            SouceTMP.color = Color.red;
            SouceTMP.text = "Pizza Sauce " + counterPresent + "%";
        }

        /*if the sauce is on the shelf*/
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
       // }

    

    }

    int counterPresent = 100;
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.name == "CubeEnemy") {
            ColidesWithEnemy = true;
           
              }
    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
    //    Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.3f);
    }


    }
