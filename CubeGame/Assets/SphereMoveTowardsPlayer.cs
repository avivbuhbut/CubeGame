using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoveTowardsPlayer : MonoBehaviour
{
    public Material PlayerRedMaterial;
    public Material PlayerGreenMaterial;


    public Material PizzaBoxMaterial;
    public bool PlayerIsInRadius;
    bool PizzaBoxInRadius;
    bool PlayerCloneInRadius;
    Transform Player;

    Transform PizzaBoxTrans;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform;
        this.transform.GetComponent<Renderer>().material.SetColor("_Color", Color.green);

    }

    // Update is called once per frame
    void Update()
    {
        PlayerInRadius();
        PlayerCloneInRadiusMethod();

       // EnemyInsidePlayerChangeColorPlayer();

       
            CahngeColorPizzaWhenInRadius();

        CancelDragRigDollWhenPizzaInRadius();

    }

    void CancelDragRigDollWhenPizzaInRadius()
    {
        if (PizzaBoxTrans != null && PizzaBoxInRadius)
        {
            if ((PizzaBoxTrans.GetComponent<Rigidbody>().velocity.magnitude > 1) && (!Input.GetKey(KeyCode.Mouse0)))
            {
                Debug.Log("Cancel rid");
                GameObject.Find("Player").GetComponent<DragRigidbody>().enabled = false;
                PizzaBoxTrans.GetComponent<Rigidbody>().mass = 50;
            }
            else
            {
                PizzaBoxTrans.GetComponent<Rigidbody>().mass = 1.4f;
            }

        }

        if (!PizzaBoxInRadius && PizzaBoxTrans!= null)
        {
            PizzaBoxTrans.GetComponent<Rigidbody>().mass = 1.4f;
            GameObject.Find("Player").GetComponent<DragRigidbody>().enabled = true;
            Debug.Log("enabled rid");
        }
    }

    //if ((velBox1.magnitude > 8) && (!Input.GetKey(KeyCode.Mouse0)))
    void CahngeColorPizzaWhenInRadius()
    {

        if (PizzaBoxInRadius)
            PizzaBoxTrans.GetComponent<Renderer>().material.color = Color.red;
   //     else
           // if (PizzaBoxTrans != null)
       //     PizzaBoxTrans.GetComponent<Renderer>().material.color = Color.;


    }


    void PlayerInRadius()
    {



        if (PlayerIsInRadius && Player!=null)
        {

            this.transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Player").transform.position, 2.8f * Time.deltaTime); // move towards the pizza box

            this.transform.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
        else
            this.transform.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }


    void PlayerCloneInRadiusMethod()
    {



        if (PlayerCloneInRadius)
        {

            this.transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Player(Clone)").transform.position, 2.8f * Time.deltaTime); // move towards the pizza box

            this.transform.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
        else
            this.transform.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }


    void EnemyInsidePlayerChangeColorPlayer()
    {
        if (this.transform.position == GameObject.Find("Player").transform.position)
        {
            GameObject.Find("Player").transform.GetComponent<Renderer>().material = PlayerRedMaterial;
            Debug.Log("now isinde player");
        }
       if(this.transform.position != GameObject.Find("Player").transform.position)
            GameObject.Find("Player").transform.GetComponent<Renderer>().material = PlayerGreenMaterial;
    }
 
     void OnTriggerEnter(Collider other)
    {

        if(other.transform.gameObject.name == "Player(Clone)")
        {
            PlayerCloneInRadius = true;
        }


        if (other.transform.gameObject.name == "Player")
        {
          
            PlayerIsInRadius = true;
        }

       if (other.transform.gameObject.tag == "PizzaBox")
       {
            Debug.Log("game object enter radius: " + other.transform.gameObject.name);
            PizzaBoxTrans = other.transform ;

            PizzaBoxInRadius = true;
        }
    }

     void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.name == "Player")
        {
            Debug.Log("Player Exit Sphere radius:" + other.transform.gameObject.name);
            PlayerIsInRadius = false;
        }

        if (other.transform.gameObject.tag == "PizzaBox")
        {
        
           
            Debug.Log("PizzaBox Exit Sphere radius:" + other.transform.gameObject.name);
            PizzaBoxInRadius = false;
        }


        if (other.transform.gameObject.name == "Player(Clone)")
        {
            PlayerCloneInRadius = false ;
        }

    }
}
