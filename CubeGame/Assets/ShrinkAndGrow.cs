using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkAndGrow : MonoBehaviour
{

    public float timer = 2;
    // Start is called before the first frame update

    public Vector3 CurrentScale;
    public Vector3 MaxSize;
    void Start()
    {
        CurrentScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
        MaxSize = new Vector3(1.67757f, 4.108144f, 1.028347f);
    }

    // Update is called once per frame
    void Update()
    {

        /*Grow sideways*/



        

            if (Input.GetKeyDown(KeyCode.Alpha8) && this.transform.localScale.x <= MaxSize.x)
            {



                this.transform.localScale = new Vector3(this.transform.localScale.x + 0.3f,
                    this.transform.localScale.y, this.transform.localScale.z);


            }






            if (Input.GetKeyDown(KeyCode.Alpha9)&& this.transform.localScale.y <= MaxSize.y)
            {



                this.transform.localScale = new Vector3(this.transform.localScale.x,
                    this.transform.localScale.y + 0.3f, this.transform.localScale.z);


            }


        

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            this.transform.localScale = CurrentScale;
        }


        
    }
}
