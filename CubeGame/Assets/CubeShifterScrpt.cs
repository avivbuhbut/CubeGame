using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShifterScrpt : MonoBehaviour
{

    bool hitCubeShifterBool;
      public static Transform hitCubeTrans;
    public Vector3 DeafultSizeCubeShifter;
    public static RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        DeafultSizeCubeShifter = new Vector3(0.3571158f, 0.8636905f, 3.177702f);
    }

    // Update is called once per frame
    void Update()
    {

        checkIfUserPressedOnCubeShifter();


        if (hitCubeShifterBool)
        {

            /*maybe set up color lerping back and forth (or just changing till the player is no longer editing the cube)
             * so the player will know what cube is he editing*/
             if(hitCubeTrans!=null)
            if (hitCubeTrans.childCount == 1)
            {
                hitCubeTrans.GetChild(1).transform.localScale = ColidedWithAnotherCubeShifter.currentSize;
                if (Input.GetKeyDown(KeyCode.RightArrow)) //make the cube width grow
                    hitCubeTrans.parent.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x + 0.3f,
                            hitCubeTrans.parent.transform.localScale.y, hitCubeTrans.transform.localScale.z);


                if (Input.GetKeyDown(KeyCode.LeftArrow)) //make the cube width decreese
                    hitCubeTrans.parent.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x - 0.3f,
                            hitCubeTrans.parent.transform.localScale.y, hitCubeTrans.transform.localScale.z);

                if (Input.GetKeyDown(KeyCode.UpArrow)) //make the cube hight grow
                    hitCubeTrans.parent.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x,
                            hitCubeTrans.parent.transform.localScale.y + 0.3f, hitCubeTrans.transform.localScale.z);

                if (Input.GetKeyDown(KeyCode.DownArrow)) //make the cube hight decrese
                    hitCubeTrans.parent.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x,
                            hitCubeTrans.parent.transform.localScale.y - 0.3f, hitCubeTrans.transform.localScale.z);
            }
            else if (hitCubeTrans.childCount == 0)
            {

                if (Input.GetKeyDown(KeyCode.RightArrow)) //make the cube width grow
                    hitCubeTrans.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x + 0.3f,
                           hitCubeTrans.transform.localScale.y, hitCubeTrans.transform.localScale.z);


                if (Input.GetKeyDown(KeyCode.LeftArrow)) //make the cube width decreese
                    hitCubeTrans.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x - 0.3f,
                           hitCubeTrans.transform.localScale.y, hitCubeTrans.transform.localScale.z);

                if (Input.GetKeyDown(KeyCode.UpArrow)) //make the cube hight grow
                    hitCubeTrans.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x,
                           hitCubeTrans.transform.localScale.y + 0.3f, hitCubeTrans.transform.localScale.z);

                if (Input.GetKeyDown(KeyCode.DownArrow)) //make the cube hight decrese
                    hitCubeTrans.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x,
                           hitCubeTrans.transform.localScale.y - 0.3f, hitCubeTrans.transform.localScale.z);


            }
        }


        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
           // if(hitCubeTrans!= null)
            hitCubeTrans.transform.localScale = DeafultSizeCubeShifter;
        }


       

    }

    void checkIfUserPressedOnCubeShifter()
    {
        if (Input.GetMouseButtonDown(0))
        {


            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);                    ///Very Useful Code! - tells the object name when clicked by the mouse
      
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);

           
            if (hit.transform.tag == "CubeShifter" )
            {
                hitCubeShifterBool = true;

                hitCubeTrans = hit.transform;
            }


        }

    }
}
