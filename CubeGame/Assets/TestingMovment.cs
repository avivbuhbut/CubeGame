using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMovment : MonoBehaviour
{

    public Animator animatorWalking;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animatorWalking.SetBool("Activate", true);
        }
    }
}
