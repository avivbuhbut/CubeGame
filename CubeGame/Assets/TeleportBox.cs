using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBox : ColidedScript
{
    // Start is called before the first frame update

    public float xposl;
    public float yposl;
    public float zposl;
  
    public Transform PizzaBox2;

    void Start()
    {
        xposl = transform.position.x;
        yposl = transform.position.y;
        zposl = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision)
    {

       if (counter ==3  && collision.gameObject.tag == "Finish")
            PizzaBox2.position = new Vector3(xposl, yposl, zposl);
       // Debug.Log("BOX2 FINISH!");
        //   
    }
   
}
