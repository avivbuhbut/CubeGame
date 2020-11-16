using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childOfPlayer : MonoBehaviour
{

    public Rigidbody HammerCubeRigidBody;
    public Transform Player1Trans;
    public Rigidbody Player1Ridg;
    public GameObject Player1GamObj;

    public GameObject Player2GamObj;
    public Transform Player2Trans;
    public Rigidbody Player2Ridg;

  


    public float forceFactor = 10;


    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {


      
        OnMouseOver();
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" )
        {
            Player1Ridg.GetComponent<SphereCollider>().enabled = true;
            HammerCubeRigidBody.isKinematic = true;

            gameObject.transform.parent = Player1Trans;
            gameObject.transform.position = new Vector3(Player1Trans.position.x-1.5f, Player1Trans.position.y +2, Player1Trans.position.z);
     
        }

        if(collision.gameObject.tag == "Player2")
        {
            Player2Ridg.GetComponent<SphereCollider>().enabled = true;
            HammerCubeRigidBody.isKinematic = true;

            this.gameObject.transform.parent = Player2Trans;

            gameObject.transform.position = new Vector3(Player2Trans.position.x + 1, Player2Trans.position.y + 3, Player2Trans.position.z);


        }


      //  if (collision.gameObject.tag == "Floor")
      //  {
      //      gameObject.transform.parent = null;
       // }
        
        
        //    if (Input.GetMouseButtonDown(0) &&collision.gameObject.tag == "Floor" )
        //   {
        //      Player2Ridg.GetComponent<SphereCollider>().enabled = false;
        //    Player1Ridg.GetComponent<SphereCollider>().enabled = false;
        //    gameObject.transform.parent = null;
        // HammerCubeRigidBody.isKinematic = false;
        //   }

        /*Magnitute dosent work yet*/
        /* if(collision.gameObject.tag == "CubeDistraction")
         {
             if (gameObject.transform.parent == Player1Trans)
             {
                 Player1Ridg.AddForce((Player1Ridg.gameObject.transform.position - transform.position) * forceFactor * Time.smoothDeltaTime);

                 //  HammerCubeRigidBody.drag = 10f;
             }



             if (gameObject.transform.parent == Player2Trans)
             {
                 Player2Ridg.AddForce((Player2Ridg.gameObject.transform.position - transform.position) * forceFactor * Time.smoothDeltaTime);

                 //  HammerCubeRigidBody.drag = 10f;
             }

         }*/



    }


    void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0) )
        {
            Player2Ridg.GetComponent<SphereCollider>().enabled = false;
           Player1Ridg.GetComponent<SphereCollider>().enabled = false;
            gameObject.transform.parent = null;
            HammerCubeRigidBody.isKinematic = false;
           
        }

    }

 


}


