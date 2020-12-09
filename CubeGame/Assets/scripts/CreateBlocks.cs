using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour
{

    public static int BlocksAvilable;
  //  public GameObject CubeGamObj;
    public GameObject CubeGamObj;
    public GameObject PizzaProtectorGamObj;
    private GameObject linehandler;
    private Vector3 mousepos;
    public GameObject ThrowObjGamObj;
    // Start is called before the first frame update
    void Start()
    {
       CubeGamObj.SetActive(false);
        PizzaProtectorGamObj.SetActive(false);
    }

   

    void Update()
    {
        ////////////////////////////////////////////FOR DEBUG ONLY (START LINE)/////////////////////////////////////////////////////////
        /*for debug onle*/
        if (Input.GetKey(KeyCode.Alpha6))
        {
            if (Input.GetMouseButtonDown(0))
            {


                PizzaProtectorGamObj.SetActive(true);
                mousepos = Input.mousePosition;
                mousepos.z = 14.5f;

                mousepos = Camera.main.ScreenToWorldPoint(mousepos);
                linehandler = Instantiate(PizzaProtectorGamObj, mousepos, Quaternion.identity) as GameObject;



                linehandler.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation |
                    RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
            }
        }



            /*for debug only*/
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
        ////////////////////////////////////////////FOR DEBUG ONLY (END LINE) /////////////////////////////////////////////////////////
        ///

        if (Input.GetKey(KeyCode.Alpha7))
        {
            
                CubeGamObj.SetActive(true);
                mousepos = Input.mousePosition;
                mousepos.z = 15.2f;

                mousepos = Camera.main.ScreenToWorldPoint(mousepos);
                linehandler = Instantiate(ThrowObjGamObj, mousepos, Quaternion.identity) as GameObject;
                linehandler.gameObject.name = "ThrowPizzaObj";
                linehandler.gameObject.tag = "ThrowPizzaObj";



                linehandler.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ |
                    RigidbodyConstraints.FreezePositionZ;

            
        }

        /*create a wood block*/
        if (Input.GetKey(KeyCode.B)) 
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

                if (hit.transform.name == "CubePlayerCreate(Clone)" || hit.transform.name == "PizzaPanelProtector(Clone)")
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
