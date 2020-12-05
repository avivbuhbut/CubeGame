using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartTimerEnterFirstChallange : MonoBehaviour
{

    bool PlayerPassThrow;
    bool PizzaBoxPassThrow;
    public TextMeshPro PlayerTimerTMP;
    public float timeLeft = 120f;
    // Start is called before the first frame update
    void Start()
    {
        PlayerTimerTMP.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        int Min;


      

        //  PlayerTimerTMP.text = "TIME LEFT: \n" + timeLeft;
        if (PlayerPassThrow&& PizzaBoxPassThrow)
        {

            timeLeft -= Time.deltaTime;
            Min = (int)timeLeft / 60;

            PlayerTimerTMP.gameObject.SetActive(true);
            if (timeLeft % 60 > 10 && timeLeft>0)
                PlayerTimerTMP.text = "TIME LEFT: \n" + Min + ":" + timeLeft % 60;
            if (timeLeft % 60 < 10 && timeLeft > 0)
            {
                PlayerTimerTMP.text = "TIME LEFT: \n" + Min + ":" + "0" + timeLeft % 60;
            }


            if(timeLeft ==0)
            {
                //GameObject.Find("Player").transform.position = new Vector3(15.05f, 11.47f, 10.11741f); // try to teleport to the start
              //  GameObject.Find("PizzaBox").transform.position = new Vector3(15.05f, 11.47f, 10.11741f);
            }

        }



    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Player")
        {
            PlayerPassThrow = true;

        }

        if (other.transform.tag == "PizzaBox")
        {
            PizzaBoxPassThrow = true;
        }
    }

    }
