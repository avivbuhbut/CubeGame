using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStandsOnButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
           
         //   this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.GetComponent<MeshFilter>().mesh, this.transform.GetComponent<MeshDestroy>(), this.gameObject);
            //  this.gameObject.transform.GetComponent<Rigidbody>().AddExplosionForce(5, this.transform.position,10f,10f,ForceMode.Impulse);
        }
    }
}
