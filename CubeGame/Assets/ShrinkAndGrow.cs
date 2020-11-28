using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkAndGrow : MonoBehaviour
{

    public float timer = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
        

            
                this.transform.localScale = new Vector3(this.transform.localScale.x +0.3f,
                    this.transform.localScale.y, this.transform.localScale.z);
          
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {



            this.transform.localScale = new Vector3(this.transform.localScale.x ,
                this.transform.localScale.y + 0.3f, this.transform.localScale.z);


        }
    }
}
