using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0F, moveVertical);
        //Note I'm not adding anything to the y vector here ^
        rb.velocity = movement * speed;
        if (Input.GetKey("space") && detectGround())
        {
            rb.AddForce(0.0F, 7000, 0.0F);
            //It seems like I'm adding way too much force on y vector, but even with that much I barely leave the ground. I need, like, 10,000 to get a good high jump.

        }
    }
    bool detectGround()
    {
        Vector3 down = transform.TransformDirection(Vector3.down);
        return Physics.Raycast(transform.position, down, .51F);
    }
}
