using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakAnythingTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int counter = 0;

     void OnCollisionEnter(Collision collision)
    {
        if (counter < 10)
        {
            if (collision.transform.tag != "Player" && collision.transform.name != "Broken") { 
            collision.transform.GetComponent<MeshDestroy>().DestroyMesh(collision.transform.gameObject.GetComponent<MeshFilter>().mesh, collision.transform.GetComponent<MeshDestroy>(), collision.gameObject);
            counter++;
        }
            //collision.transform.GetComponent<MeshDestroy>().DestroyMesh(collision.transform.gameObject.GetComponent<MeshFilter>().mesh, collision.transform.GetComponent<MeshDestroy>(), collision.gameObject);

        }
        //try to make it break 5 times! 




        //  if(collision.transform.name == "Broken" && counter<10)
        //  if(collision.transform.name == "Broken" && counter<10)
        //  {
        //   collision.transform.GetComponent<MeshDestroy>().DestroyMesh(collision.transform.gameObject.GetComponent<MeshFilter>().mesh, collision.transform.GetComponent<MeshDestroy>(), collision.gameObject);

        //    counter++;
        //   }


    }
    
    void OnCollisionExit(Collision collision)
    {
        counter = 0;
    }
}
