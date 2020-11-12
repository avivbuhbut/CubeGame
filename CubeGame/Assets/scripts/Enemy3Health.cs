using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Health : MonoBehaviour
{
    public Transform PizzaBox3Trans;

    public float health = 50f;
    // Start is called before the first frame update

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            PizzaBox3Trans.parent = null;
            Destroy(this.gameObject);
        }
    }



}
