using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMovment : MonoBehaviour
{
    float speed = 3;
    public Animator animatorWalking;
   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {



        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 8f, Space.Self);
            this.transform.GetComponent<Rigidbody>().mass = 0.3f;

        }



        if (Input.GetKey(KeyCode.D))
        {
            animatorWalking.enabled = true;

            animatorWalking.SetBool("Activate", true);

            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World); //RIGHT
            transform.rotation = Quaternion.Euler(0, 180, 0);
        } else if(Input.GetKey(KeyCode.A))
            {

                Debug.LogError("Pressing A");

                animatorWalking.enabled = true;

                animatorWalking.SetBool("Activate", true);
                transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World); //LEFT
                transform.rotation = Quaternion.Euler(0, -360, 0);


            }
            else
        {
            animatorWalking.SetBool("Activate", false);
             animatorWalking.enabled = false;

            transform.rotation = Quaternion.Euler(0, 270, 0);
        }
    }
}
