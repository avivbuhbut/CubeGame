using UnityEngine;
using DG.Tweening;

public class thisObjColidedWithSphere : MonoBehaviour
{
    // Start is called before the first frame update
    bool PizzaThrowcolidedWithSphere;
    static int counterPizzaThrow = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PizzaThrowcolidedWithSphere && counterPizzaThrow > 80)
      {
            Debug.Log(counterPizzaThrow);
            counterPizzaThrow--;
            this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.gameObject.GetComponent<MeshFilter>().mesh,this.transform.GetComponent<MeshDestroy>(),this.gameObject);
       }
    }

     void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.name == "EnemySphere (1)")
        {
            this.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.gameObject.GetComponent<MeshFilter>().mesh, this.transform.GetComponent<MeshDestroy>(), this.gameObject);

            PizzaThrowcolidedWithSphere = true;

        }

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "SphereEnemy"&& (GameObject.Find("Player")!=null))
        {
            if ((GameObject.Find("EnemySphere (1)").GetComponent<SphereMoveTowardsPlayer>().PlayerIsInRadius))
            {
                this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ |
                       RigidbodyConstraints.FreezePositionZ;

            }else

                this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            /*
             *             else if ((GameObject.Find("EnemySphere (1)").GetComponent<SphereMoveTowardsPlayer>().PlayerCloneInRadius))
        {
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ |
                    RigidbodyConstraints.FreezePositionZ;

        }
        else if(!(GameObject.Find("EnemySphere (1)").GetComponent<SphereMoveTowardsPlayer>().PlayerCloneInRadius))
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;*/

            //this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            this.gameObject.transform.GetComponent<Renderer>().material.DOColor(Color.red, 10f);

        }


        if (other.transform.tag == "SphereEnemy" && (GameObject.Find("Player(Clone)").activeSelf))
        {
            if ((GameObject.Find("EnemySphere (1)").GetComponent<SphereMoveTowardsPlayer>().PlayerCloneInRadius))
            {
                this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ |
                       RigidbodyConstraints.FreezePositionZ;

            }
            else

                this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            /*
             *             else if ((GameObject.Find("EnemySphere (1)").GetComponent<SphereMoveTowardsPlayer>().PlayerCloneInRadius))
        {
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ |
                    RigidbodyConstraints.FreezePositionZ;

        }
        else if(!(GameObject.Find("EnemySphere (1)").GetComponent<SphereMoveTowardsPlayer>().PlayerCloneInRadius))
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;*/

            //this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            this.gameObject.transform.GetComponent<Renderer>().material.DOColor(Color.red, 10f);

        }



        //The not makes the problem
        // if (!((GameObject.Find("EnemySphere (1)").GetComponent<SphereMoveTowardsPlayer>().PlayerCloneInRadius) && other.transform.tag == "SphereEnemy"))
        //{
        //    Debug.Log("DFD");
        //     this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //  }
        //  else
        //      this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ |
        //      RigidbodyConstraints.FreezePositionZ;

        /* i think it should be this way
          if((GameObject.Find("EnemySphere (1)").GetComponent< SphereMoveTowardsPlayer>().PlayerIsInRadius) && other.transform.tag == "SphereEnemy"))
        {
         this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ |
                RigidbodyConstraints.FreezePositionZ;
      
        }else
              this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
         
         
         */




    }


        void OnTriggerExit(Collider other)
    {


        if (other.transform.tag == "SphereEnemy")
        {


            if ((GameObject.Find("EnemySphere (1)").GetComponent<SphereMoveTowardsPlayer>().PlayerCloneInRadius) && other.transform.tag == "SphereEnemy")
            {
                this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ |
                   RigidbodyConstraints.FreezePositionZ;
            }


            if ((GameObject.Find("EnemySphere (1)").GetComponent<SphereMoveTowardsPlayer>().PlayerIsInRadius) && other.transform.tag == "SphereEnemy")
            {
                this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ |
                   RigidbodyConstraints.FreezePositionZ;
            }

            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ |
                RigidbodyConstraints.FreezePositionZ;
            this.gameObject.transform.GetComponent<Renderer>().material.DOColor(Color.white, 10f);

        }
    }




}
