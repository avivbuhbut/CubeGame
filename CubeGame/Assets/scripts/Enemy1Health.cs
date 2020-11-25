using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Health : MonoBehaviour
{
    // public Transform PizzaBox1Trans;
    public ParticleSystem ExplotionEnenyParticle;
    public ParticleSystem ExplotionEnenyParticle2;
    public float health = 50f;
  //  public Transform PizzaBox1Cam;
  //  public Transform Cameras;
  //  public Transform PizzaBoxesTrans;

    public Transform PizzaSauceTrans;
    public GameObject BuildingCube;
    Vector3 CurrentPosEnemy;
    Vector3 explosionPos;
    public float radius = 5.0F;
    public float power = 10.0F;


    void Start()
    {
        explosionPos = transform.position;
        BuildingCube.SetActive(false);
       ExplotionEnenyParticle.Stop();
        ExplotionEnenyParticle2.Stop();
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


            ExplotionEnenyParticle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            ExplotionEnenyParticle2.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            //  ExplotionEnenyParticle.transform.localScale = new Vector3(30,30,30);
            Debug.Log(this.gameObject.transform.name);

         //   this.gameObject.transform.GetComponent<MeshDestroy>().DestroyMesh(this.transform.gameObject.GetComponent<MeshFilter>().mesh, this.transform.GetComponent<MeshDestroy>(), this.gameObject);

            this.gameObject.transform.GetComponent<Rigidbody>().AddExplosionForce(power, explosionPos, radius, 3.0F);
            this.gameObject.SetActive(false);
            ExplotionEnenyParticle.Play();
            ExplotionEnenyParticle2.Play();
            BuildingCube.SetActive(true);
            Instantiate(BuildingCube, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity) ;


        
        }
    }



}
