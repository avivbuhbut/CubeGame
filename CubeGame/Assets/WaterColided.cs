using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterColided : MonoBehaviour
{


    public bool WaterHitFloor;
    public bool WaterHitSauceShelff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
            WaterHitFloor = true;
        else
            WaterHitFloor = false;

        if (collision.gameObject.name == "WaterShelf")
            WaterHitSauceShelff = true;
        else
            WaterHitSauceShelff = false;
    }
}
