using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyWIthPizzaMode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.F) && LastActivePizzaBox.LastPizzaActive.transform!= null)
        {


         Transform tran = LastActivePizzaBox.LastPizzaActive.transform;


            if (tran != null) ;
                GameObject.Find("Player").transform.position = new Vector3(tran.transform.position.x, tran.transform.position.y + 1, tran.transform.position.z);
         

        }
        
    }
}
