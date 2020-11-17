using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraplingGun : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrapeable;
    public Transform GunTip , Player, CamGraplingGun;
    public float maxDistance = 1000f;
    private SpringJoint joint;


   

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }   


     void Update()
    {
        DrawRope();
        if (Input.GetMouseButtonDown(0))
        {
            StartGrapple();
        }else if (Input.GetMouseButtonUp(0))
        {
           StopGrapple();
        }

    }

    void StartGrapple()
    {
        RaycastHit hit;

        if (Physics.Raycast(GunTip.transform.position, GunTip.transform.forward, out hit)) { // shoot the ray from the tip of the grapling gun 


            Debug.Log("inside Raycast");


            grapplePoint = hit.point; // creating the grapling point

            joint = Player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplePoint;

            float distanceFromPoint = Vector3.Distance(Player.position, grapplePoint);


            joint.maxDistance = distanceFromPoint * 0.8f;
            joint.minDistance = distanceFromPoint * 0.2f;

            joint.spring = 4.5f;
            joint.damper = 7f;
            joint.massScale = 4.5f;
        }

        
    }


    void DrawRope()
    {
        lr.SetPosition(0,GunTip.position);
        lr.SetPosition(1, grapplePoint);
    }

    void StopGrapple()
    {

    }

}