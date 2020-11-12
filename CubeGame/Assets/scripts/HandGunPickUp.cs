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
          
                Debug.Log("Gun is in the RIGHT hand");

                RightHandHold();

          
            if (RightHandGunFacingDirectio == 180 || LeftHandGunFacingDirectio == 180) {//  gun faces left


                Debug.Log("Gun is in the LEFT hand");


                LeftHandHold();

            }

        }

    }


    public void LeftHandHold()
    {
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
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

    }


    public void RightHandHold()
    {



        HandGunTrans.transform.parent = WeaponHolderTrans;
        HandGunTrans.transform.position = new Vector3(WeaponHolderTrans.position.x, WeaponHolderTrans.position.y, WeaponHolderTrans.position.z);

        //rotation
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(WeaponHolderTrans.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

 
        WeaponHolderTrans.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

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
