using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderWithOtherSideTMP : MonoBehaviour
{
    public bool OtherTmpTouchFloor;
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
        if(other.gameObject.tag == "Floor" || other.gameObject.tag == "PizzaBox" || other.gameObject.tag == "PlateBoundsP2" || other.gameObject.tag == "Untagged" || other.gameObject.tag == "FinishLineCube"
            || other.gameObject.tag == "CubeDistraction" || other.gameObject.tag == "DoughAndSauce" || other.gameObject.tag == "Sauce" || other.gameObject.tag == "Water" || other.gameObject.tag == "HammerCube"
            || other.gameObject.tag == "Basket1" || other.gameObject.tag == "Player" || other.gameObject.tag == "Player2" || other.gameObject.tag == "CubeEnemySauce")
            OtherTmpTouchFloor = true;
    }

     void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Floor" || other.gameObject.tag == "PizzaBox" || other.gameObject.tag == "PlateBoundsP2" || other.gameObject.tag == "Untagged" || other.gameObject.tag == "FinishLineCube"
             || other.gameObject.tag == "CubeDistraction" || other.gameObject.tag == "DoughAndSauce" || other.gameObject.tag == "Sauce" || other.gameObject.tag == "Water" || other.gameObject.tag == "HammerCube"
             || other.gameObject.tag == "Basket1" || other.gameObject.tag == "Player" || other.gameObject.tag == "Player2" || other.gameObject.tag == "CubeEnemySauce")
            OtherTmpTouchFloor = false;
    }
}
