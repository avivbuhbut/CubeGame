using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
public class DestroyEnemyOnHit : MonoBehaviour
{

    bool colidedWithSphere;
    int counter = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //  if(colidedWithSphere&& counter > 0)
     //   {
         //   counter--;
         //   this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.gameObject.GetComponent<MeshFilter>().mesh, this.transform.GetComponent<MeshDestroy>(), this.gameObject);
//}
    }
    
     void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "EnemySphere (1)")
        {
            colidedWithSphere = true;
         
        }
    }

}