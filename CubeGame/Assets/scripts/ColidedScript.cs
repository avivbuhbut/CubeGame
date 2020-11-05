using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColidedScript : MonoBehaviour
{

    public static int counter;
    public GameObject PizzaBox2;
    
    

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
        

       // if(counter ==2)
          //  Instantiate(PizzaBox2, new Vector3(3.87f, -6.14387f, 10.27f), Quaternion.identity);
        //PizzaBox2Trans.position = new Vector3(20.9f, -2.74677f, 10.26f);








    }

}
