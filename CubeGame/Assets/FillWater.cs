using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillWater : MonoBehaviour
{

    // Start is called before the first frame update

    public Transform WaterTrans;
    public Vector3 Water100pScale;
    public Vector3 fillWater;

    bool WaterOnShelf;
    void Start()
    {
        fillWater = new Vector3(0.001f, 0.001f, 0.001f);
       Water100pScale = GameObject.Find("Water").transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(WaterTrans!= null)
        if (WaterTrans.GetComponent<WaterColided>().WaterHitSauceShelff && WaterTrans.transform.localScale != Water100pScale)
            WaterTrans.localScale += fillWater;


        //if ()

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.name == "Water")
        {
           WaterOnShelf = true;
        }




    }


}
