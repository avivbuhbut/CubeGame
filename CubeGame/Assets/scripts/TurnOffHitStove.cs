using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffHitStove : MonoBehaviour
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
        
       if(collision.gameObject.transform.tag == "Stove" && GameObject.Find("CubeCheckForRainColision").GetComponent<CubeCheckForRainHit>().hit.transform.name != "StoveCelling")
        {
            this.gameObject.SetActive(false);
        }
    }
}
