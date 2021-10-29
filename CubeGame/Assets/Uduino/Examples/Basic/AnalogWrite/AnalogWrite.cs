﻿using UnityEngine;
using Uduino;

public class AnalogWrite : MonoBehaviour {

    public int pin = 11;

    [Range(0, 255)]
    public int brightness;

	// Use this for initialization
	void Start () {
        UduinoManager.Instance.pinMode(pin, PinMode.PWM);
	}
	
	// Update is called once per frame
	void Update () {
        UduinoManager.Instance.analogWrite(11, brightness);
    }

}
