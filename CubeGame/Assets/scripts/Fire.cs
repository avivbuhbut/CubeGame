using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float ImpactForce = 300f;
    public float speed = 5f;
    public float Damage = 10f;

    public Transform WeaponHolder;
    public Transform WeaponHolderLeftHand;
    public Transform AimTransform;

    public GameObject bullet;
    public GameObject ImpactEffect;

    public ParticleSystem ShellParticles;
    public ParticleSystem SmokeAfterShot;

    public RaycastHit hit;
    public AudioSource GunFireSound;
    // Start is called before the first frame update
    void Start()
    {
        ShellParticles.Stop();
        SmokeAfterShot.Stop();
        GunFireSound.Stop();
    }

    void Update()
    {


        if (Input.GetMouseButtonDown(0) &&( this.gameObject.transform.parent == WeaponHolder.transform) || Input.GetMouseButtonDown(0) && (this.gameObject.transform.parent == WeaponHolderLeftHand.transform))
        {
            /*play particals when shooting*/
            ShellParticles.Play();
            SmokeAfterShot.Play();
            GunFireSound.Play();


            /*the ray will start from the AIMtransform and will shoot forward . out hit  - means unity will put all the information of the hit into the hit varible */
           if ( Physics.Raycast(AimTransform.transform.position, AimTransform.transform.right, out hit))
            {



                EnamiesTakesDamge();


                if (hit.rigidbody != null)
                    hit.rigidbody.AddForce(hit.point * ImpactForce); // adding force to the impact


                GameObject impactG0 = Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));// hit.point is the point of impact
                Destroy(impactG0, 1f); // destroy the impact particals

            }

        }


    }

    public void EnamiesTakesDamge()
    {

        /*Enemy1TakeDamage*/
        Enemy1Health enemyHelathScript1 = hit.transform.GetComponent<Enemy1Health>(); // im getting the enemy health of the enemy that got hit by the ray
        if (enemyHelathScript1 != null) //making sure i actually found the script
        {
            enemyHelathScript1.TakeDamage(Damage); // decresing the enemy health
        }


        /*Enemy2TakeDamage*/
        Enemy2Health enemyHelathScript2 = hit.transform.GetComponent<Enemy2Health>(); // im getting the enemy health of the enemy that got hit by the ray
        if (enemyHelathScript2 != null) //making sure i actually found the script
        {
            enemyHelathScript2.TakeDamage(Damage); // decresing the enemy health
        }


        /*Enemy3TakeDamage*/
        Enemy3Health enemyHelathScript3 = hit.transform.GetComponent<Enemy3Health>(); // im getting the enemy health of the enemy that got hit by the ray
        if (enemyHelathScript3 != null) //making sure i actually found the script
        {
            enemyHelathScript3.TakeDamage(Damage); // decresing the enemy health
        }

    }


}

