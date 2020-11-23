using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colidedWithEnemy : MonoBehaviour
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
        if (collision.gameObject.transform.name == "CubeEnemy") {
            Debug.Log("EnemyHIt! " + this.gameObject.transform.name);

            GameObject.Find("CubeEnemy").transform.parent = this.gameObject.transform;
            }

    }


}
