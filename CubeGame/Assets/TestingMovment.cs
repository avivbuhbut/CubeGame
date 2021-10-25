using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
public class TestingMovment : MonoBehaviour
{
    UduinoManager manager;
    float speed = 3;
    public Animator animatorWalking;
   
    // Start is called before the first frame update
    void Start()
    {

        manager = UduinoManager.Instance;

        manager.pinMode(AnalogPin.A1, PinMode.Input);
        transform.rotation = Quaternion.Euler(0, 270, 0);

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        int value = manager.analogRead(AnalogPin.A1);






        if (value > 520)
        {
            animatorWalking.enabled = true;

            animatorWalking.SetBool("Activate", true);

            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World); //RIGHT
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (value < 510)
        {

                Debug.LogError("Pressing A");

                animatorWalking.enabled = true;

                animatorWalking.SetBool("Activate", true);
                transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World); //LEFT
                transform.rotation = Quaternion.Euler(0, -360, 0);


            }
            else
        {

            ///Invoke("DoSomething", 2);//this will happen after 2 seconds
            animatorWalking.SetBool("Activate", false);
             animatorWalking.enabled = false;

           // transform.rotation = Quaternion.Euler(0, 270, 0); // the player will face the camera
        }
    }
}
