using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCameraPizzaBoxes : MonoBehaviour
{


    public Transform target1;
    public Transform target2;

    public Vector3 target_OffsetBox1;
    public Vector3 target_OffsetBox2;
    private void Start()
    {
        target_OffsetBox1 = transform.position - target1.position;
        target_OffsetBox2 = transform.position - target2.position;

    }
    void Update()
    {
        if (target1)
        {
            transform.position = Vector3.Lerp(transform.position, target1.position + target_OffsetBox1, 0.1f);
        }

        if (target2)
        {
            transform.position = Vector3.Lerp(transform.position, target2.position + target_OffsetBox1, 0.1f);
        }

    }


}
