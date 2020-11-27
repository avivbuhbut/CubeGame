using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStandsOnButton : MonoBehaviour
{

    public float Timer;
    bool ColidedWithPlayer;

    public Vector3 MoveToPos;


    public Animator PressurePlateButtonAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  Timer = Time.time;

        if (ColidedWithPlayer)
        {

            PressurePlateButtonAnimator.SetBool("Active",true);


        }
        else
        {
            PressurePlateButtonAnimator.SetBool("Active", false);
        }


    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
           //GameObject.Find("Player").transform.parent = this.transform;
            ColidedWithPlayer = true;

        }
    }

     void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {

            //GameObject.Find("Player").transform.parent = null;
            ColidedWithPlayer = false;

        }
    }
}
