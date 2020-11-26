using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastActivePizzaBox : MonoBehaviour
{

    public static Transform LastPizzaActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.GetComponent<Rigidbody>().velocity.magnitude>0 && (!Input.GetKey(KeyCode.Mouse0)))
        {
            LastPizzaActive = this.transform;
        }
    }
}
