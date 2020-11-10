using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuchBackForce : MonoBehaviour
{



    public float pushForce = 10;
    public Rigidbody HummerBoxRigidBody;
    public GameObject Player2GamObj;
    public GameObject Player1GamObj;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       // LeftHandGunFacingDirectio = Mathf.Atan2(WeaponHolderTransLeftHand.transform.right.z, WeaponHolderTransLeftHand.transform.right.x) * Mathf.Rad2Deg;
       // RightHandGunFacingDirectio = Mathf.Atan2(WeaponHolderTrans.transform.right.z, WeaponHolderTrans.transform.right.x) * Mathf.Rad2Deg;



        if (gameObject.transform.parent == Player2GamObj.transform)
            Player2GamObj.GetComponent<SC_RigidbodyMagnet>().enabled = false;

        if (gameObject.transform.parent == Player1GamObj.transform)
            Player1GamObj.GetComponent<SC_RigidbodyMagnet>().enabled = false;

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "CubeDistraction" || other.gameObject.tag == "Untagged")
        {
            Debug.Log("pushLeft");
           
          //  HummerBoxRigidBody.AddForce(Vector2.left * pushForce, ForceMode.Impulse);
            /*add right direction*/
            Player2GamObj.GetComponent<SC_RigidbodyMagnet>().enabled = true;
            Player1GamObj.GetComponent<SC_RigidbodyMagnet>().enabled = true;
        }
    }

}
