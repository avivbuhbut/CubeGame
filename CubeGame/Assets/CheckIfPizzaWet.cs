using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class CheckIfPizzaWet : MonoBehaviour
{
    bool RainHitPiiza;

    public RaycastHit hitDown;

    public RaycastHit hitUp;
    int counter = 0;
    public float TimeNotInRain;
    public bool pizzaIsNotInRain;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
             if (Physics.Raycast(this.transform.position, this.transform.TransformDirection(Vector3.down), out hitDown))
             {
            Debug.DrawRay(this.transform.position, this.transform.TransformDirection(Vector3.down) * hitDown.distance, Color.yellow);


             }

             if (Physics.Raycast(this.transform.position, this.transform.TransformDirection(Vector3.up), out hitUp))
             {
            Debug.DrawRay(this.transform.position, this.transform.TransformDirection(Vector3.up) * hitUp.distance, Color.yellow);
           // if (hit.transform.name != "Floor" && hit.transform.tag != "Bounds")
             //        this.gameObject.transform.GetComponent<Renderer>().material.DOColor(Color.white, 10f);
             }





        if (this.transform != null)
            if ((hitDown.transform.tag == "Floor" && hitUp.transform.tag != "Bounds"
           || hitDown.transform.tag != "Bounds" && hitUp.transform.tag == "Floor") && this.transform.GetComponent<Rigidbody>().velocity.magnitude == 0)
            {
                
                pizzaIsNotInRain = true;
                this.gameObject.transform.GetComponent<Renderer>().material.DOColor(Color.white, 10f);
            }
         







    }

     void   OnParticleCollision(GameObject other)
    {

      

  
        if (other.gameObject.name == "RainFallParticleSystem")
        {
            pizzaIsNotInRain = false;
            this.gameObject.transform.GetComponent<Renderer>().material.DOColor(Color.blue, 10f);
   
        }
     


    }

  



}
