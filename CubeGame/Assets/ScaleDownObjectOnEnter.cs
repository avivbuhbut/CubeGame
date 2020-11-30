using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleDownObjectOnEnter : MonoBehaviour
{
    public Transform CubeShifterTrans;
    bool CubeShifterInBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N) && CubeShifterInBox)
        {
            Vector3 NewCubePos = new Vector3(this.transform.position.x - 2, this.transform.position.y, this.transform.position.z);
            GameObject CubeShifter = Instantiate(CubeShifterTrans.transform.gameObject,NewCubePos, Quaternion.identity) as GameObject;
          
            CubeShifter.transform.gameObject.SetActive(true);
            CubeShifterInBox = false;
        }

    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "CubeShifter")
        {
            other.transform.localScale = new Vector3(0.120554f, 0.09011137f, 0.1087186f);

            // other.transform.parent = this.transform;
            CubeShifterInBox = true;
            other.transform.gameObject.SetActive(false);
        }

    }
}
