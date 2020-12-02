using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOutCurrentCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Scroling wheele ZoomInAndOut
        if(Camera.main!=null)
        if (Input.GetKeyDown(KeyCode.C) && Camera.main.fieldOfView == 60)
        {
           // if (Camera.main.fieldOfView <= 50)
                Camera.main.fieldOfView = 80;
           // if (Camera.main.orthographicSize <= 20)
            //    Camera.main.orthographicSize += 0.5;

        }
        else if(Input.GetKeyDown(KeyCode.C) && Camera.main.fieldOfView == 80)
        {
            Camera.main.fieldOfView = 60;
        }
    

      //  if (Input.GetKeyDown(KeyCode.C) && Camera.main.transform.position.z == -4.99f)
     //   {


          //  Camera.main.transform.position = new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y,
          //     -7f);



        //}

    }



}
