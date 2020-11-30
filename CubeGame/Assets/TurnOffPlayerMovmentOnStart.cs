using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffPlayerMovmentOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.GetComponent<PlayerMovment>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
