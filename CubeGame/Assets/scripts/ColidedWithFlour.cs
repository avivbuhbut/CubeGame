﻿using UnityEngine;

public class ColidedWithFlour : MonoBehaviour
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
        if (collision.gameObject.tag == "Flour")
            this.gameObject.SetActive(false);
    }
}
