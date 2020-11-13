using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Health : MonoBehaviour
{
    public Transform PizzaBox1Trans;
    public float health = 50f;



    
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            PizzaBox1Trans.parent = null; // if it wasent null the pizzaBox would destroy too.
            Destroy(this.gameObject);
        }
    }



}
