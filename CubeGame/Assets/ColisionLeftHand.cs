using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionLeftHand : MonoBehaviour
{
    public Transform M1911Trans;
    public Transform WeaponHolderLeftHandTrans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (this.gameObject.transform.IsChildOf(WeaponHolderLeftHandTrans))
        {
            M1911Trans.rotation = Quaternion.Euler(-2f, -275f, -2f);
           transform.gameObject.GetComponent<ColisionLeftHand>().enabled = false;
        }

    }

     void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
