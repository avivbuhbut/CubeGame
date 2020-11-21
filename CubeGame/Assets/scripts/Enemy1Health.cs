using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Health : MonoBehaviour
{
   // public Transform PizzaBox1Trans;
    public float health = 50f;
  //  public Transform PizzaBox1Cam;
  //  public Transform Cameras;
  //  public Transform PizzaBoxesTrans;

    public Transform PizzaSauceTrans;
    public GameObject BuildingCube;
    Vector3 CurrentPosEnemy;

     void Start()
    {
        BuildingCube.SetActive(false);
      
    }

     void Update()
    {
      //  Debug.Log(this.gameObject.name);
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
         

            // PizzaSauceTrans.parent = GameObject.Find("PizzaIngridians").transform;
            //PizzaBox1Trans.parent = PizzaBoxesTrans; // if it wasent null the pizzaBox would destroy too.
            //s   PizzaBox1Cam.parent = Cameras;
            //  Destroy(this.gameObject);
            this.gameObject.SetActive(false);
            BuildingCube.SetActive(true);
            Instantiate(BuildingCube, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity) ;


        
        }
    }



}
