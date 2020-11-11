using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeClider : MonoBehaviour
{

    public int counter;
    public Transform PizzaBox1Trans;
    public Transform PizzaBox2Trans;
    public Transform PizzaBox3Trans;
    public Transform PizzaBoxesTrans;

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
            PizzaBox1Trans.parent = PizzaBoxesTrans.transform;
            PizzaBox2Trans.parent = PizzaBoxesTrans.transform;
            PizzaBox3Trans.parent = PizzaBoxesTrans.transform;
            Destroy(this.gameObject);


        }


    }

}
