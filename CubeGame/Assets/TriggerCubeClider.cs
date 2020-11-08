using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeClider : MonoBehaviour
{

    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "PizzaBox")
            counter++;
        if (counter == 3)
        {
            Debug.Log("Counter is 3!");
       
            Destroy(this.gameObject);
            transform.parent = null;
        }


    }

}
