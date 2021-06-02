using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaLight : MonoBehaviour
{




    public Transform LightTrans;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LightTrans.position = new Vector3(this.transform.position.x, this.transform.position.y + 3, this.transform.position.z);
    }
}
