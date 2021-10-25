using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
public class ReadJoyStick : MonoBehaviour
{

    UduinoManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
           manager = UduinoManager.Instance;

        manager.pinMode(AnalogPin.A1, PinMode.Input);
    }

    // Update is called once per frame
    void Update()
    {

        int value = manager.analogRead(AnalogPin.A1);
//        Debug.Log(value);
        if(value > 516)
        {
           // transform.Translate(Vector3.right * Time.deltaTime * 3, Space.World);
        }
        //transform.Translate(Vector3.right * Time.deltaTime * value, Space.World);

    }
}
