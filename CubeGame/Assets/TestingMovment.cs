using UnityEngine;
using Uduino;
public class TestingMovment : MonoBehaviour
{
    UduinoManager manager;
    float speed = 3;
    public Animator animatorWalking;
    public Transform LeftHandBone;
    public Transform RIghtHandBone;
    // Start is called before the first frame update
    void Start()
    {

        manager = UduinoManager.Instance;

        manager.pinMode(AnalogPin.A1, PinMode.Input);
        manager.pinMode(AnalogPin.A0, PinMode.Input);
        transform.rotation = Quaternion.Euler(0, 270, 0);

    }
    double Timer;
    // Update is called once per frame
    void FixedUpdate()
    {


        int value = manager.analogRead(AnalogPin.A1);

        int JS_UpDowVal = manager.analogRead(AnalogPin.A0);
        if (Input.GetKey(KeyCode.D))
        {
            animatorWalking.SetBool("Activate", false);
            float LeftArmMovSpeed = 0;
            if (JS_UpDowVal < 510)
            {


                LeftArmMovSpeed = 0.2f * Time.time;
                Debug.Log(LeftArmMovSpeed);
                Debug.Log(JS_UpDowVal);
                //  LeftHandBone.LookAt(this.LeftHandBone.position.x,this.LeftHandBone.position.y+2,this.LeftHandBone.position.z);
            }

        }
        else
        {



            if (value > 520 && !Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                //Timer = 0;
                animatorWalking.enabled = true;

                animatorWalking.SetBool("Activate", true);

                transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World); //RIGHT
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if (value < 510 && !Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow))
            {
               // Timer = 0;
                //Debug.LogError("Pressing A");

                animatorWalking.enabled = true;

                animatorWalking.SetBool("Activate", true);
                transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World); //LEFT
                transform.rotation = Quaternion.Euler(0, -360, 0);
                //transform.position = new Vector3(this.transform.position.x-1, this.transform.position.y, this.transform.position.z);

            }
            else
            {

                ///Invoke("DoSomething", 2);//this will happen after 2 seconds
                animatorWalking.SetBool("Activate", false);
                animatorWalking.enabled = false;
              //   Timer += Time.deltaTime * 0.8f;
              //  Debug.Log("Timer" + Timer);
             //   if(Timer>3)
               // transform.rotation = Quaternion.Euler(0, 270, 0); // the player will face the camera
            }

        }
    }
}
