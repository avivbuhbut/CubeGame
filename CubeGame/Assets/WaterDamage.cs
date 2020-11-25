using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDamage : MonoBehaviour
{

    public float timeLeft = 20;
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

        if (timeLeft <= 10 && timeLeft > 0)
        {
       
            Debug.Log((int)timeLeft);
            counter = 1;
       
        }


        if ((int)timeLeft <= 0 && counter < 100)
        {

            counter++;
            if (counter == 2)
            {
                this.transform.GetComponent<Rigidbody>().useGravity = true;
                this.transform.GetComponent<Rigidbody>().isKinematic = false;
            }


            Debug.Log("time finish counter " + counter);


            this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.gameObject.GetComponent<MeshFilter>().mesh, this.transform.gameObject.GetComponent<MeshDestroy>(), this.gameObject);

        }


    }
}

