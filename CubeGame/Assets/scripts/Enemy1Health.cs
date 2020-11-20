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



    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            PizzaSauceTrans.parent = GameObject.Find("PizzaIngridians").transform;
            //PizzaBox1Trans.parent = PizzaBoxesTrans; // if it wasent null the pizzaBox would destroy too.
         //s   PizzaBox1Cam.parent = Cameras;
            Destroy(this.gameObject);
        }
    }



}
