using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{


    public GameObject bullet;
    public float speed = 5f;
    public Transform AimTransform;
    public float Damage = 10f;



 
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            /*the ray will start from the AIMtransform and will shoot forward . out hit  - means unity will put all the information of the hit into the hit varible */
           if( Physics.Raycast(AimTransform.transform.position, AimTransform.transform.right, out hit))
            {

                Debug.Log(hit.transform.name);// print the object that the ray hit
                EnemyHealth enemyHelathScript = hit.transform.GetComponent<EnemyHealth>(); // im getting the enemy health of the enemy that got hit by the ray
                if(enemyHelathScript != null) //making sure i actually found the script
                {
                    enemyHelathScript.TakeDamage(Damage); // decresing the enemy health
                }
            }
        }
     }

}

