﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float health = 50f;
    // Start is called before the first frame update
    
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
            Destroy(this.gameObject);
    }
}
