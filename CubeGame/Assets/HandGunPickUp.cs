using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunPickUp : MonoBehaviour
{
    public Transform WeaponHolderTrans;
    public Transform HandGunTrans;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Q))
            transform.parent = null;

    }



     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "HandGun")
        {
            HandGunTrans.transform.parent = WeaponHolderTrans.transform;
            HandGunTrans.position = new Vector3(WeaponHolderTrans.position.x, WeaponHolderTrans.position.y, WeaponHolderTrans.position.z);

        }
    }
}
