using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunColidedRightHand : MonoBehaviour
{

    public Transform M1911;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int colisionTimes = 0;
    void OnTriggerEnter(Collider other)
    {
        colisionTimes++;
        Debug.Log("Left on triggers: " + other.gameObject.name);
        //  M1911Trans.Rotate(-2f, 280f, -2f);

        //   HandGunTrans.transform.position = new Vector3(WeaponHolderTransLeftHand.position.x, WeaponHolderTransLeftHand.position.y, WeaponHolderTransLeftHand.position.z);
        //   M1911.transform.position = new Vector3(WeaponHolderTransLeftHand.position.x, WeaponHolderTransLeftHand.position.y, WeaponHolderTransLeftHand.position.z);
        if (other.gameObject.name == "M1911" && colisionTimes>=1)
            M1911.rotation = Quaternion.Euler(-2f, 275f, -2f);
    

    }

     void OnTriggerExit(Collider other)
    {
        colisionTimes = 0;
    }
}
