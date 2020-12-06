using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLife : MonoBehaviour
{
    public static int PlayerLifeCounter = 100;
    public TextMeshPro PlayerLifeTMP;
    bool ColidedWithEnemy;
    Transform SphereTrans;
    Vector3 MoveDirection;
    Vector3 StartPosPlayer;

    public Camera RainCamera;

    // Start is called before the first frame update
    void Start()
    {

        PlayerLifeTMP.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //     Debug.Log(" Time.deltaTime % 1 " + Time.deltaTime % 1);

        if (ColidedWithEnemy )
        {
            PlayerLifeCounter = PlayerLifeCounter - 10;
            PlayerLifeTMP.gameObject.SetActive(true);
            if (PlayerLifeCounter < 100 && PlayerLifeCounter > 50)
            {
                PlayerLifeTMP.text = PlayerLifeCounter + "%";
                PlayerLifeTMP.color = Color.green;


            }

            if (PlayerLifeCounter < 50 && PlayerLifeCounter > 20)
            {
                PlayerLifeTMP.text = PlayerLifeCounter + "%";
                PlayerLifeTMP.color = Color.yellow;


            }

            if (PlayerLifeCounter < 20 && PlayerLifeCounter > 0)
            {
                PlayerLifeTMP.text = PlayerLifeCounter + "%";
                PlayerLifeTMP.color = Color.red;


            }


          //  if (PlayerLifeCounter <= 0)
          //  {
               // Debug.Log("Enter");
              //  int counter = 100;
              //  if (counter != 0)
              ////  {
               // //    this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.gameObject.GetComponent<MeshFilter>().mesh, this.transform.GetComponent<MeshDestroy>(), this.gameObject);
                //    counter--;
             //   }

         //   }

        }
    }


     void OnCollisionEnter(Collision collision)
    {
     
        if(collision.transform.tag == "SphereEnemy")
        {
            Debug.Log(collision.transform.tag);
            ColidedWithEnemy = true;
            // MoveDirection = this.transform.position - collision.transform.position;

            this.transform.GetComponent<Rigidbody>().AddForce(new Vector3(this.transform.position.x, 0, 0) * 20);
            this.transform.GetComponent<Rigidbody>().AddForce(new Vector3(-this.transform.position.x,0,0) * -20);
            this.transform.GetComponent<Rigidbody>().AddForce(new Vector3(0,-this.transform.position.y*0.4f, 0)*-20);
            this.transform.GetComponent<Rigidbody>().AddForce(new Vector3(0, this.transform.position.y * 0.4f, 0) * 20);
            //SphereTrans  = collision.transform;


        if(PlayerLifeCounter<=0)
                this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.gameObject.GetComponent<MeshFilter>().mesh, this.transform.GetComponent<MeshDestroy>(), this.gameObject);
            RainCamera.gameObject.SetActive(false);
        }
    }
    void OnCollisionExit(Collision collision)
    {

        if (collision.transform.tag == "SphereEnemy")
        {
            ColidedWithEnemy = false;
        }
    }


}
