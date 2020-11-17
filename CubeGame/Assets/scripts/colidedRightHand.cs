using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colidedRightHand : MonoBehaviour
{
    public Transform WeaponHolderTrans;

    public Transform HandGunTrans;
    public Transform M1911;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        //  M1911Trans.Rotate(-2f, 280f, -2f);

        //   HandGunTrans.transform.position = new Vector3(WeaponHolderTransLeftHand.position.x, WeaponHolderTransLeftHand.position.y, WeaponHolderTransLeftHand.position.z);
        //   M1911.transform.position = new Vector3(WeaponHolderTransLeftHand.position.x, WeaponHolderTransLeftHand.position.y, WeaponHolderTransLeftHand.position.z);
        if (other.gameObject.name == "M1911")
            M1911.rotation = Quaternion.Euler(-50f, -280f, -2f);

    }

}
