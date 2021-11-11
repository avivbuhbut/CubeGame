using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testRotationRighArm : MonoBehaviour
{
    float MoveUpX = 1;
    float MoveDownY = 1;
    float MoveDownZ = 1;

    // Update is called once per frame
    float rotateSpeed = 0.001f;
    bool FlashLightOn = false;
    double flashLightTimer = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    void Update()
    {

        if (Input.GetKey(KeyCode.F) )
        {
            //flashLightTimer Time.deltaTime * 0.8f;
            if (FlashLightOn == false)
            {
                this.transform.localRotation = Quaternion.Euler(70.9357071f, 106.977867f, 99.2737961f);

                FlashLightOn = true;
            }
            //else
            //{
            //    FlashLightOn = false;
            //    this.transform.localRotation = Quaternion.Euler(86.9416122f, 45.7645187f, 109.676224f);
            //}
        }


        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log(this.transform.localRotation.z);
            //MoveUpX = this.transform.localRotation.x  +0.03f;
            //MoveDownY = this.transform.localRotation.y +Time.deltaTime;
            //MoveDownZ = this.transform.localRotation.z + Time.deltaTime;
            //this.transform.localRotation = Quaternion.Euler(Vector3.left * Time.deltaTime);


         //   Quaternion currentRotation = transform.rotation;
         //   Quaternion wantedRotation = Quaternion.Euler(73.8658066f, 171.06662f, 152.001541f);
          //  transform.rotation = Quaternion.RotateTowards(currentRotation, wantedRotation, Time.deltaTime * rotateSpeed);

        }
        //this.transform.rotation = Quaternion.Euler(this.transform.rotation.x +30, this.transform.rotation.y, this.transform.rotation.z);



    }
}
