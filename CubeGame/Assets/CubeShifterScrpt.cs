using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShifterScrpt : MonoBehaviour
{

    bool hitCubeShifterBool;
    Transform hitCubeTrans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        checkIfUserPressedOnCubeShifter();


        if (hitCubeShifterBool)
        {

            /*maybe set up color lerping back and forth (or just changing till the player is no longer editing the cube)
             * so the player will know what cube is he editing*/

            hitCubeTrans.transform.GetComponent<Material>().color = new Color();

            if (Input.GetKeyDown(KeyCode.Alpha8)) //make the cube width grow
            hitCubeTrans.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x + 0.3f,
                   hitCubeTrans.transform.localScale.y, hitCubeTrans.transform.localScale.z);


            if (Input.GetKeyDown(KeyCode.Alpha7)) //make the cube width decreese
                hitCubeTrans.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x - 0.3f,
                       hitCubeTrans.transform.localScale.y, hitCubeTrans.transform.localScale.z);

            if (Input.GetKeyDown(KeyCode.Alpha0)) //make the cube hight grow
                hitCubeTrans.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x ,
                       hitCubeTrans.transform.localScale.y + 0.3f, hitCubeTrans.transform.localScale.z);

            if (Input.GetKeyDown(KeyCode.Alpha9)) //make the cube hight decrese
                hitCubeTrans.transform.localScale = new Vector3(hitCubeTrans.transform.localScale.x,
                       hitCubeTrans.transform.localScale.y - 0.3f, hitCubeTrans.transform.localScale.z);
        }

 
    }

    void checkIfUserPressedOnCubeShifter()
    {
        if (Input.GetMouseButtonDown(0))
        {


            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);                    ///Very Useful Code! - tells the object name when clicked by the mouse
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            Debug.Log("This hit at " + hit.transform.tag); // till here

            if (hit.transform.tag == "CubeShifter")
            {
                hitCubeShifterBool = true;

                hitCubeTrans = hit.transform;
            }


        }

    }
}
