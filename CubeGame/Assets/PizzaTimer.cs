using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PizzaTimer : MonoBehaviour
{

    public TextMeshPro PizzaTimerTMP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PizzaTimerTMP.color = Color.red;
        PizzaTimerTMP.text = (int)GameObject.Find("StoveBack").GetComponent<CreatePizza>().timeLeft + " S";

        if (GameObject.Find("StoveBack").GetComponent<CreatePizza>().timeLeft<10 && GameObject.Find("StoveBack").GetComponent<CreatePizza>().timeLeft > 5)
        {
            PizzaTimerTMP.color = Color.red;
            PizzaTimerTMP.text = (int)GameObject.Find("StoveBack").GetComponent<CreatePizza>().timeLeft + " S";
        }

        if (GameObject.Find("StoveBack").GetComponent<CreatePizza>().timeLeft < 5 && GameObject.Find("StoveBack").GetComponent<CreatePizza>().timeLeft > 0)
        {
            PizzaTimerTMP.color = Color.yellow;
            PizzaTimerTMP.text = (int)GameObject.Find("StoveBack").GetComponent<CreatePizza>().timeLeft + " S";
        }

        if (GameObject.Find("StoveBack").GetComponent<CreatePizza>().timeLeft < 2 && GameObject.Find("StoveBack").GetComponent<CreatePizza>().timeLeft > 0)
        {
            PizzaTimerTMP.color = Color.green;
            PizzaTimerTMP.text = (int)GameObject.Find("StoveBack").GetComponent<CreatePizza>().timeLeft + " S";
        }



    }
}
