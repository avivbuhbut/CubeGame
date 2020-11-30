using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionLeftHand : MonoBehaviour
{

    public Transform WeaponHolderTransLeftHand;
    public Transform HandGunTrans;
    public Transform M1911;


  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      //  if (this.gameObject.transform.IsChildOf(WeaponHolderLeftHandTrans))
     ////   {
     //       M1911Trans.rotation = Quaternion.Euler(-2f, -275f, -2f);
    //       transform.gameObject.GetComponent<ColisionLeftHand>().enabled = false;
   //     }

    }
     void OnTriggerEnter(Collider other)
    {

        //  M1911Trans.Rotate(-2f, 280f, -2f);
    
     //   HandGunTrans.transform.position = new Vector3(WeaponHolderTransLeftHand.position.x, WeaponHolderTransLeftHand.position.y, WeaponHolderTransLeftHand.position.z);
     //   M1911.transform.position = new Vector3(WeaponHolderTransLeftHand.position.x, WeaponHolderTransLeftHand.position.y, WeaponHolderTransLeftHand.position.z);
     if(other.gameObject.name == "M1911" )
            M1911.localRotation = Quaternion.Euler(180, 180, -M1911.rotation.z);

    }
}
