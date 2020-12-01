using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOutCamWhenDraw : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera ZoomOutCam;

    void Start()
    {
      //  Camera.main.gameObject.SetActive(true);
        ZoomOutCam.transform.gameObject.SetActive(false);
        //this.transform.GetComponent<ZoomOutCamWhenDraw>().enabled = false;
        //ZoomOutCam.gameObject.SetActive(false);
        //ZoomOutCam.GetComponent<FollowCamera2Script>().enabled = false;
    }
    int counter = 1;
    // Update is called once per frame
    void Update()
    {
        Debug.Log("indise");
        /*if player want to switch to drawing mode*/
        if (Input.GetKeyDown(KeyCode.C)&& counter == 1)
        {
            counter++;
            Debug.Log("indise");
            ZoomOutCam.transform.gameObject.SetActive(true);


            this.transform.GetComponent<ZoomOutCamWhenDraw>().enabled = true;
            ZoomOutCam.GetComponent<FollowCamera2Script>().enabled = true;
            ZoomOutCam.GetComponent<FollowCamera2Script>().target = this.transform;


        }
       else if (counter == 2 && Input.GetKeyDown(KeyCode.C))
        {
            Camera.main.transform.gameObject.SetActive(true);
            counter = 1;
        }
        /*
         else if(Input.GetKeyDown(KeyCode.C) && counter == 1)
        {

            ZoomOutCam.transform.gameObject.SetActive(true);
            Camera.main.enabled = false;
            Debug.Log("here");
           

            this.transform.GetComponent<ZoomOutCamWhenDraw>().enabled = true;
            ZoomOutCam.GetComponent<FollowCamera2Script>().enabled = true;
            ZoomOutCam.GetComponent<FollowCamera2Script>().target = this.transform;

            counter ++;
        }*/

        /*
         *    if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("indise");
            Camera.main.gameObject.SetActive(true);
            ZoomOutCam.transform.gameObject.SetActive(false);
            this.transform.GetComponent<ZoomOutCamWhenDraw>().enabled = false;
            ZoomOutCam.GetComponent<FollowCamera2Script>().enabled = false;
            ZoomOutCam.GetComponent<FollowCamera2Script>().target = this.transform;


        }
       */

    }
}
