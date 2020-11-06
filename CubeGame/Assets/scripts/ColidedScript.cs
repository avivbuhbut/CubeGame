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
   
    }



    public void OnTriggerEnter(Collider col)
    {


        if (col.gameObject.tag == "PizzaBox")
        {


            counter++;
            //  Debug.Log(counter);

        }


        if (counter == 3)
            Debug.Log("Finish first part!");


        //PizzaBox2Trans.position = new Vector3(20.9f, -2.74677f, 10.26f);








    }

}
