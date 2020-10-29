using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColidedScript : MonoBehaviour
{

    public static int counter;


    // Start is called before the first frame update
    void Start()
    {


        // anim.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(counter);
    }



    public void OnTriggerEnter(Collider col)
    {


        if (col.gameObject.tag == "PizzaBox")
        {


            counter++;
            //  Debug.Log(counter);

        }








    }

}
