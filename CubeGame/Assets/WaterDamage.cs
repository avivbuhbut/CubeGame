using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDamage : MonoBehaviour
{

    public float timeLeft = 8;
    float counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        // {
        //  counter++;
        //  Debug.Log(counter);
        //  MeshDestroy MeshDistroGamObj =    GameObject.Find("MeshDistroy").GetComponent<MeshDestroy>();


        timeLeft -= Time.deltaTime;


        if (timeLeft == 0)
        {
            this.transform.GetComponent<Rigidbody>().useGravity = true;
            this.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GameObject.Find("CubePlayerCreate(Clone)").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }

        if (timeLeft <= 10 && timeLeft > 0)
        {
       

            counter = 1;
       
        }


        if ((int)timeLeft <= 0 && counter < 100)
        {

            //counter++;
          //  if (counter == 2)
          //  {
      
           // }


     


            this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.GetComponent<MeshFilter>().mesh, this.transform.GetComponent<MeshDestroy>(), this.gameObject);
       
        }


    }
   
     void OnCollisionEnter(Collision collision)
    {
     
        if (collision.transform.gameObject.name == "CubePlayerCreate(Clone)")
        {
      
            if (collision.transform.gameObject != null )
                timeLeft += timeLeft *2 / 2;
        }
    
    }
}

