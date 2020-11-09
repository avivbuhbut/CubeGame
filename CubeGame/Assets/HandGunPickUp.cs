using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunPickUp : MonoBehaviour
{
    public Transform WeaponHolderTrans;
    public Transform WeaponHolderTransLeftHand;
    public Transform HandGunTrans;

    public bool FirstTransition;

    bool isFacingRight = true;
    float LeftHandGunFacingDirectio;
    float RightHandGunFacingDirectio;

    // Start is called before the first frame update
    void Start()
    {
        FirstTransition = false;
       // HandGunTrans.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
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

            Debug.Log("LeftHandGunFacingDirectio" +LeftHandGunFacingDirectio);
            Debug.Log("RightHandGunFacingDirectio" + RightHandGunFacingDirectio);

            /*RIGHT HAND*/
            if (RightHandGunFacingDirectio == 0 || LeftHandGunFacingDirectio==0) //  gun faces right
            {

                HandGunTrans.transform.parent = WeaponHolderTrans;
                HandGunTrans.transform.position = new Vector3(WeaponHolderTrans.position.x, WeaponHolderTrans.position.y, WeaponHolderTrans.position.z);
                Debug.Log("Gun facing Right");
                //rotation
                Vector2 mousePos = Input.mousePosition;
                // mousePos.z = 5.23f;

                Vector2 objectPos = Camera.main.WorldToScreenPoint(WeaponHolderTrans.position);
                mousePos.x = mousePos.x - objectPos.x;
                mousePos.y = mousePos.y - objectPos.y;

                float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
                WeaponHolderTrans.rotation = Quaternion.Euler(new Vector3(0, 0, angle));






            }
            if (RightHandGunFacingDirectio == 180 || LeftHandGunFacingDirectio == 180) {//  gun faces right



                Debug.Log("LeftHandGunFacingDirectio" + LeftHandGunFacingDirectio);
              Debug.Log("RightHandGunFacingDirectio" + RightHandGunFacingDirectio);

                HandGunTrans.transform.parent = WeaponHolderTransLeftHand;
                HandGunTrans.transform.position = new Vector3(WeaponHolderTransLeftHand.position.x, WeaponHolderTransLeftHand.position.y, WeaponHolderTransLeftHand.position.z);


                //HandGunTrans.transform.rotation = Quaternion.Euler(new Vector3(0f,90f,0f));
                Vector2 objectPos = Camera.main.WorldToScreenPoint(WeaponHolderTransLeftHand.position);
                //  FaceLeft();
                Debug.Log("Gun facing Left");
                //rotation
                Vector2 mousePos = Input.mousePosition;
                // mousePos.z = 5.23f;



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
