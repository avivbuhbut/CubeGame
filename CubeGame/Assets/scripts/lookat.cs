﻿using UnityEngine;

public class lookat : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Input.mousePosition);
    }
}
