using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCubeImpact : MonoBehaviour
{

   public Transform ControlledCubeTrans;
    bool ColidedControlledCube;
    bool ColidedeFirstTime;
    Vector3 MoveLeftDestVec;
    // Start is called before the first frame update
    void Start()
    {
        ColidedeFirstTime = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (ColidedControlledCube)
        {

            // step = 0.00002f * Time.deltaTime;

            //ControlledCubeTrans.position = new Vector3(ControlledCubeTrans.position.x - 1, ControlledCubeTrans.position.y, ControlledCubeTrans.position.z);

            ControlledCubeTrans.position = Vector3.Lerp(ControlledCubeTrans.position, MoveLeftDestVec, 0.8f* Time.deltaTime);
           // ControlledCubeTrans.position = Vector3.MoveTowards(MoveLeftDestVec, transform.position, step);

           if (Vector3.Distance(ControlledCubeTrans.position, MoveLeftDestVec) == 0)
            {
                ColidedControlledCube = false;
                ColidedeFirstTime = false;
                

               }
            }
        }
    

     void OnCollisionEnter(Collision collision)
    {
  
        if (collision.transform.tag == "ControlledCube" && ColidedeFirstTime ==false)
        {
            ColidedeFirstTime = true;
            MoveLeftDestVec = new Vector3(ControlledCubeTrans.position.x -10, ControlledCubeTrans.position.y, ControlledCubeTrans.position.z);
            ColidedControlledCube = true;
            ControlledCubeTrans = collision.transform;
        }
    }
}
