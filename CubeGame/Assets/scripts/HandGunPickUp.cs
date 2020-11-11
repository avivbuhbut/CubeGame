using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunPickUp : MonoBehaviour
{


    /*Fire Gun*/
    public Camera Player1Cam;
    public GameObject bullet;
    Vector3 clickPos;


    public Transform WeaponHolderTrans;
    public Transform WeaponHolderTransLeftHand;
    public Transform HandGunTrans;
    public Transform AimTrans;


    public float handGunStartRotx;
    public float handGunStartRoty;
    public float handGunStartRotz;

    public bool FirstTransition;

    bool isFacingRight = true;
    float LeftHandGunFacingDirectio;
    float RightHandGunFacingDirectio;

    // Start is called before the first frame update
    void Start()
    {
        FirstTransition = false;

        handGunStartRotx = WeaponHolderTrans.rotation.x;
        handGunStartRoty = WeaponHolderTrans.rotation.y;
        handGunStartRotz = WeaponHolderTrans.rotation.z;

        // HandGunTrans.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Mouse0))
            Fire();

        LeftHandGunFacingDirectio=  Mathf.Atan2(WeaponHolderTransLeftHand.transform.right.z, WeaponHolderTransLeftHand.transform.right.x) * Mathf.Rad2Deg;
        RightHandGunFacingDirectio = Mathf.Atan2(WeaponHolderTrans.transform.right.z, WeaponHolderTrans.transform.right.x) * Mathf.Rad2Deg;

        // Debug.Log("Player Pos: " + this.transform.position);

        if (Input.GetKey(KeyCode.Q))
        {
         //   HandGunTrans.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            HandGunTrans.transform.parent = null;
        }



        /*if the gun is in players hand , point to mouse pos*/
        if (HandGunTrans.transform.parent == WeaponHolderTrans || HandGunTrans.transform.parent == WeaponHolderTransLeftHand)
        {
       

            /*RIGHT HAND*/
            if (RightHandGunFacingDirectio == 0 || LeftHandGunFacingDirectio==0) //  gun faces right
            {



                Debug.Log("RightHandGunFacingDirectio" + RightHandGunFacingDirectio);
                HandGunTrans.transform.parent = WeaponHolderTrans;
                HandGunTrans.transform.position = new Vector3(WeaponHolderTrans.position.x, WeaponHolderTrans.position.y, WeaponHolderTrans.position.z);
                Debug.Log("Gun facing Right");
                //rotation
                Vector3 mousePos = Input.mousePosition;
                 mousePos.z = 5.23f;

                Vector3 objectPos = Camera.main.WorldToScreenPoint(WeaponHolderTrans.position);
                mousePos.x = mousePos.x - objectPos.x;
                mousePos.y = mousePos.y - objectPos.y;

                float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
                if (FirstTransition != true)
                {
                    Debug.Log("before first transition");
                    WeaponHolderTrans.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
                }
                else
                {
                    Debug.Log("after first transition");
                    WeaponHolderTrans.rotation = Quaternion.Euler(new Vector3(handGunStartRotx, handGunStartRoty, angle));
                    FirstTransition = false;
                }






            }
            if (RightHandGunFacingDirectio == 180 || LeftHandGunFacingDirectio == 180) {//  gun faces left


                Debug.Log("LeftHandGunFacingDirectio" + LeftHandGunFacingDirectio);

                FirstTransition = true;

                HandGunTrans.transform.parent = WeaponHolderTransLeftHand;
                HandGunTrans.transform.position = new Vector3(WeaponHolderTransLeftHand.position.x, WeaponHolderTransLeftHand.position.y, WeaponHolderTransLeftHand.position.z);


                //HandGunTrans.transform.rotation = Quaternion.Euler(new Vector3(0f,90f,0f));
                Vector3 objectPos = Camera.main.WorldToScreenPoint(WeaponHolderTransLeftHand.position);
                //  FaceLeft();
                Debug.Log("Gun facing Left");
                //rotation
                Vector3 mousePos = Input.mousePosition;
                 mousePos.z = 5.23f;



                mousePos.x = mousePos.x - objectPos.x;
                mousePos.y = mousePos.y- objectPos.y ;

                float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
                WeaponHolderTransLeftHand.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
  
                //Debug.Log("mousePos.y:" + mousePos.y);

                /* if (WeaponHolderTransLeftHand.rotation.y == 180)
                     Debug.Log("facing right");
                 else
                     Debug.Log("facing Left");
             }*/


            }

        }

    }





    void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            clickPos = Vector3.one;
            Vector3 punktA = new Vector3(1, 2, 0);
            Vector3 punktB = new Vector3(2, 1, 0);
            Vector3 punktC = new Vector3(3, 3, 0);
            Plane plane = new Plane(punktA, punktB, punktC);
            Ray ray = Player1Cam.ScreenPointToRay(Input.mousePosition);
            float DistanceToPlane;
            if (plane.Raycast(ray, out DistanceToPlane))
            {
                clickPos = ray.GetPoint(DistanceToPlane);
            }
            Vector3 finalClickPos = new Vector3(clickPos.x, clickPos.y, 1);
            Instantiate(bullet, AimTrans.transform.position, Quaternion.LookRotation(finalClickPos));

        }


    }



    



    void FaceRight()
    {
        if (!isFacingRight)
        {
            WeaponHolderTrans.transform.localScale = new Vector3(1, 1, 1);
            isFacingRight = true;
        }
    }

    void FaceLeft()
    {
        if (isFacingRight)
        {
            WeaponHolderTrans.transform.localScale = new Vector3(-1, 1, 1);
            isFacingRight = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "HandGun")
        {
          
        
            HandGunTrans.transform.parent = WeaponHolderTrans;
            HandGunTrans.transform.position = new Vector3(WeaponHolderTrans.position.x, WeaponHolderTrans.position.y, WeaponHolderTrans.position.z);
            // HandGunTrans.transform.localEulerAngles = new Vector3(0, 180f,180f);
           //HandGunTrans.GetComponent<Rigidbody>().useGravity = false;
            HandGunTrans.GetComponent<Rigidbody>().isKinematic =true;
            //  HandGunTrans.position = new Vector3(WeaponHolderTrans.position.x, WeaponHolderTrans.position.y, WeaponHolderTrans.position.z);
            //rotation
          
        }
    }
}
