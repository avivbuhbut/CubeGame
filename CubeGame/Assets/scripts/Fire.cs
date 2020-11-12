using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public Transform WeaponHolder;
    public Transform WeaponHolderLeftHand;
    public GameObject bullet;
    public float speed = 5f;
    public Transform AimTransform;
    public float Damage = 10f;
    public ParticleSystem ShellParticles;
    public ParticleSystem SmokeAfterShot;
    public GameObject ImpactEffect;
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


        if (Input.GetMouseButtonDown(0) &&( this.gameObject.transform.parent == WeaponHolder.transform) || (this.gameObject.transform.parent == WeaponHolderLeftHand.transform))
        {
            ShellParticles.Play();
            SmokeAfterShot.Play();
            GunFireSound.Play();


            /*the ray will start from the AIMtransform and will shoot forward . out hit  - means unity will put all the information of the hit into the hit varible */
           if ( Physics.Raycast(AimTransform.transform.position, AimTransform.transform.right, out hit))
            {

                Debug.Log(hit.transform.name);// print the object that the ray hit
                EnemyHealth enemyHelathScript = hit.transform.GetComponent<EnemyHealth>(); // im getting the enemy health of the enemy that got hit by the ray
                if(enemyHelathScript != null) //making sure i actually found the script
                {
                    enemyHelathScript.TakeDamage(Damage); // decresing the enemy health
                }
            }

           GameObject impactG0 =   Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));// hit.point is the point of impact
            Destroy(impactG0, 1f);
        }
     }

}

