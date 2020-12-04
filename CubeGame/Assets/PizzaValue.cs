using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PizzaValue : MonoBehaviour
{
    public float Timer = 10;
    public static int pizzaValue = 20;
    public TextMeshPro pizzaValueTmp;
    public TextMeshPro pizzaValueOtherSideTmp;

    bool PizzaHitFloor;
    // Start is called before the first frame update
    void Start()
    {
        pizzaValueTmp.enabled = false;
        pizzaValueOtherSideTmp.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.GetComponent<Rigidbody>().velocity.magnitude > 1)
        {
            pizzaValueTmp.enabled = false;
            pizzaValueOtherSideTmp.enabled = false;
        }

      


        if (this.transform.GetComponent<CheckIfPizzaWet>().pizzaIsNotInRain == false)
        {




            if ((int)Timer == 0)
            {

                if (pizzaValueOtherSideTmp.GetComponent<ColiderWithOtherSideTMP>().OtherTmpTouchFloor)
                {
                    pizzaValueTmp.enabled = true;
                    pizzaValueOtherSideTmp.enabled = false;
                    pizzaValueTmp.color = Color.green;
                    pizzaValueTmp.text = pizzaValue + "$";
                    pizzaValue = pizzaValue - 1;
                    Timer = 10;
                }
                else if(pizzaValueTmp.GetComponent<StartSideTmpColider>().regularTmpTouchFloor)
                {
                    pizzaValueTmp.enabled = false;
                    pizzaValueOtherSideTmp.enabled = true;
                    pizzaValueOtherSideTmp.color = Color.green;
                    pizzaValueOtherSideTmp.text = pizzaValue + "$";
                    pizzaValue = pizzaValue - 1;
                    Timer = 10;
                }
            }

            Timer = Timer - Time.deltaTime;
        }




    }


     void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Floor")
            PizzaHitFloor = true;
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Floor")
            PizzaHitFloor = false;
    }
}
