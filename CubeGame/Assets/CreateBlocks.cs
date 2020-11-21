using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour
{

    public static int BlocksAvilable;
  //  public GameObject CubeGamObj;
    public GameObject CubeGamObj;
    private GameObject linehandler;
    private Vector3 mousepos;
    // Start is called before the first frame update
    void Start()
    {
        CubeGamObj.SetActive(false);
    }

   

    void Update()
    {
        Debug.Log("BlocksAvilable: " + BlocksAvilable);

        if(Input.GetKey(KeyCode.B)) 
        if (BlocksAvilable > 0 )
        {
            if (Input.GetMouseButtonDown(0))
            {
                BlocksAvilable--; // every time createing a block
                CubeGamObj.SetActive(true);
                mousepos = Input.mousePosition;
                mousepos.z = 14.5f;

                mousepos = Camera.main.ScreenToWorldPoint(mousepos);
                linehandler = Instantiate(CubeGamObj, mousepos, Quaternion.identity) as GameObject;
            }
        }

        //CubeGamObj.GetComponent<Rigidbody>().isKinematic = false;
    }


    void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.transform.tag == "Floor")
         //   Instantiate(CubeGamObj, new Vector3(this.transform.position.x, 0, 0), Quaternion.identity);
    }
}
