using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thisObjColidedWithSphere : MonoBehaviour
{
    // Start is called before the first frame update
    bool PizzaThrowcolidedWithSphere;
    static int counterPizzaThrow = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PizzaThrowcolidedWithSphere && counterPizzaThrow > 80)
      {
            Debug.Log(counterPizzaThrow);
            counterPizzaThrow--;
            this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.gameObject.GetComponent<MeshFilter>().mesh,this.transform.GetComponent<MeshDestroy>(),this.gameObject);
       }
    }

     void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.name == "EnemySphere (1)")
        {
            this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.gameObject.GetComponent<MeshFilter>().mesh, this.transform.GetComponent<MeshDestroy>(), this.gameObject);

            PizzaThrowcolidedWithSphere = true;

        }

    }

    


}
