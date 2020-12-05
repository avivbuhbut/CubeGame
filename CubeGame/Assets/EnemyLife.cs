using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyLife : MonoBehaviour
{

    static int SphereLife = 100;
    static bool HitByThrowObj;
    public TextMeshPro EnemyLifeTMP;
    static int GlobalHitCounter = 0;
    public Vector3 moveDirection;
    bool ThrowFast;
    Transform HitByThrowTrans;
    // Start is called before the first frame update
    void Start()
    {
        EnemyLifeTMP.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
        GlobalHitCounter++;

        if (HitByThrowObj  && ThrowFast)
        {
       //     Debug.Log(" Time.deltaTime % 1 " + Time.deltaTime % 1);

            SphereLife = SphereLife - 10;
            EnemyLifeTMP.gameObject.SetActive(true);
            if(SphereLife< 100 && SphereLife > 50)
            {
                EnemyLifeTMP.text = SphereLife + "%";
                EnemyLifeTMP.color = Color.green;
                moveDirection = this.transform.position - HitByThrowTrans.position;
                this.transform.GetComponent<Rigidbody>().AddForce(moveDirection.normalized * -500f);
            }

            if (SphereLife < 50 && SphereLife > 20)
            {
                EnemyLifeTMP.text = SphereLife + "%";
                EnemyLifeTMP.color = Color.yellow;
                moveDirection = this.transform.position - HitByThrowTrans.position;
                this.transform.GetComponent<Rigidbody>().AddForce(moveDirection.normalized * -50);
            }

            if (SphereLife < 20 && SphereLife > 0)
            {
                EnemyLifeTMP.text = SphereLife + "%";
                EnemyLifeTMP.color = Color.red;
                moveDirection = this.transform.position - HitByThrowTrans.position;
                this.transform.GetComponent<Rigidbody>().AddForce(moveDirection.normalized * -50);
            }


            if (SphereLife <= 0)
            {
            this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.gameObject.GetComponent<MeshFilter>().mesh, this.transform.GetComponent<MeshDestroy>(), this.gameObject);

            }

        }
    }

     void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "ThrowPizzaObj" && collision.transform.name != "Broken" )
        {
            HitByThrowObj = true;
            HitByThrowTrans = collision.transform;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "ThrowPizzaObj")
        {
            HitByThrowObj = false;
        }
    }


     void OnTriggerEnter(Collider other)
    {
        Debug.Log("Magnitude:" + other.transform.GetComponent<Rigidbody>().velocity.magnitude);
        if (other.transform.tag== "ThrowPizzaObj"&& other.transform.GetComponent<Rigidbody>().velocity.magnitude > 15)
        {

            ThrowFast = true;
        }
        else
            ThrowFast = false;
    }


    // void OnTriggerEnter(Collider other)
    // {
    ////     if(other.transform.name == "ThrowPizzaObj" || Broken)
    // }
}
