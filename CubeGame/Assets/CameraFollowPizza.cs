using UnityEngine;
using System.Collections;

public class CameraFollowPizza : ScoreCount
{

    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public GameObject pizzaBox;

    public Camera mainCam;
    public Vector3 offset;
    Vector3 targetPos;
    // Use this for initialization
    void Start()
    {
        targetPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (boxInAir())
        {
            // Player.gameObject.SetActive(false);
            //  PlayerCam.gameObject.SetActive(true);
          
            if (pizzaBox)
            {


                Vector3 posNoZ = transform.position;
                posNoZ.z = pizzaBox.transform.position.z;

                Vector3 targetDirection = (pizzaBox.transform.position - posNoZ);

                interpVelocity = targetDirection.magnitude * 5f;

                targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);

                transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.25f);

            }
        }
       

    }
}