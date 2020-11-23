using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fillPizzaSauce : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform SauceTrans;
   public Vector3 PizzaSauce100pScale;
   public Vector3 fillSauce;

    bool SuaceOnShelf;
    void Start()
    {
        fillSauce = new Vector3(0.001f, 0.001f, 0.001f);
        PizzaSauce100pScale = GameObject.Find("Sauce").transform.localScale;
    }

    // Update is called once per frame
    void Update() 
    {
    
        if (SauceTrans.GetComponent<SauceColided>().SauceHitSauceShelff && SauceTrans.transform.localScale != PizzaSauce100pScale)
            SauceTrans.localScale += fillSauce;


       //if ()
        
    }


void OnCollisionEnter(Collision collision)
{
        if (collision.gameObject.transform.name == "Sauce")
        {
            SuaceOnShelf = true;
        }
       



}
}
