using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCloneTransOnColid : MonoBehaviour
{
    // Start is called before the first frame update
    public static Transform ActiveCloneTrans;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnCollisionEnter(Collision collision)
    {


        if (collision.transform.name == "Player(Clone)")
            ActiveCloneTrans = collision.transform;
    }
}
