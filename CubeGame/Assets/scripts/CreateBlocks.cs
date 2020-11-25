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


   

        /*for debug onle*/
        if (Input.GetKey(KeyCode.Alpha5))
        {
            if (Input.GetMouseButtonDown(0))
            {
                CubeGamObj.SetActive(true);
                mousepos = Input.mousePosition;
                mousepos.z = 14.5f;

                mousepos = Camera.main.ScreenToWorldPoint(mousepos);
                linehandler = Instantiate(CubeGamObj, mousepos, Quaternion.identity) as GameObject;
                linehandler.gameObject.name = "CubePlayerCreate(Clone)";


                linehandler.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation |
                    RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;

            }
        }


        if(Input.GetKey(KeyCode.B)) 
        if (BlocksAvilable > 0 )
        {
            if (Input.GetMouseButtonDown(0))
            {

                BlocksAvilable--; // every time createing a block
                   GameObject.Find("Player").transform.GetComponent<BlocksAvilableTMPControl>().PlayerBlocksAvilableTMP.text = "X" + CreateBlocks.BlocksAvilable + " Blocks";
                    CubeGamObj.SetActive(true);
                mousepos = Input.mousePosition;
                mousepos.z = 14.5f;

                mousepos = Camera.main.ScreenToWorldPoint(mousepos);
                linehandler = Instantiate(CubeGamObj, mousepos, Quaternion.identity) as GameObject;
                    linehandler.gameObject.name = "CubePlayerCreate(Clone)";


                    linehandler.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation |
                        RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
                }
        }

        /*delete a block*/
        if (Input.GetKey(KeyCode.H))
        {
            if (Input.GetMouseButtonDown(0))
            {
              // every time createing a block


                 	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);                    ///Very Useful Code! - tells the object name when clicked by the mouse
                	RaycastHit hit;
            	// Casts the ray and get the first game object hit
                	Physics.Raycast(ray, out hit);
   	                Debug.Log("This hit at " + hit.transform.name ); // till here

                if (hit.transform.name == "CubePlayerCreate(Clone)")
                {

                    BlocksAvilable++;
                    hit.transform.gameObject.SetActive(false);
                    GameObject.Find("Player").transform.GetComponent<BlocksAvilableTMPControl>().PlayerBlocksAvilableTMP.enabled = true;
                GameObject.Find("Player").transform.GetComponent<BlocksAvilableTMPControl>(). PlayerBlocksAvilableTMP.text = "X" + CreateBlocks.BlocksAvilable + " Blocks";
                }
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
