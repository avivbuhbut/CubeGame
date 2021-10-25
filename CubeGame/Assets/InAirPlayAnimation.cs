using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAirPlayAnimation : MonoBehaviour
{

    bool PlayerNotTouchingTheFloor;
    public Animator PlayerAnimator;
    bool PlayerTouchingPizza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (this.transform.GetComponent<Rigidbody>().velocity.magnitude > 0 && PlayerNotTouchingTheFloor )
        {

            PlayerAnimator.enabled = true;
            PlayerAnimator.SetBool("Activate", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);

        }

        /*
        if (this.transform.GetComponent<Rigidbody>().velocity.magnitude == 0 && PlayerTouchingPizza)
        {
            PlayerAnimator.enabled = true;

            PlayerAnimator.SetBool("Activate", false);
        }*/
    }


     void OnCollisionEnter(Collision collision)
    {

       // Debug.Log("Colided with: " + collision.transform.name);



        if (collision.transform.tag != "Floor")
        {
            PlayerNotTouchingTheFloor = true;
        }
        else
            PlayerNotTouchingTheFloor = false;


        if (collision.transform.name == "PizzaBOX2")
        {
            PlayerTouchingPizza = true;
        }
        else
            PlayerTouchingPizza = false;
    }
}
